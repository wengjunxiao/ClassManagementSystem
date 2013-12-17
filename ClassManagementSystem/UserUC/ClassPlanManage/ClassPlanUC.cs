using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassManagementSystem.ClassPlanManage
{
    public partial class ClassPlanUC : UserControl
    {
        private DataTable searchTable = null;
        private string appendixPath = "";
        private event MyDelegate MyDG;

        public ClassPlanUC(mainForm mf)
        {
            InitializeComponent();
            this.MyDG += mf.SetPanel;
            this.InitControl();
            this.AppendixNameLab.Text = "";
            this.SearchAll();
        }

        //查询
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string planname = this.PlanNameTBox.Text.Trim();
            if (planname == "")
                this.SearchAll();
            else
                this.SearchByName(planname);
        }

        //录入
        private void InsertCpBtn_Click(object sender, EventArgs e)
        {
            this.DoInsert();
        }

        //撤销
        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.PlanNameTBox.Clear();
            this.AppendixNameLab.Text = "";
        }

        //删除记录
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.ClassPlandataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.ClassPlandataGridView.SelectedRows.Count; i++)
                {
                    string planid = this.ClassPlandataGridView.SelectedRows[i].Cells["工作计划编号"].Value.ToString();
                    if (!this.DelByID(planid))
                        MessageBox.Show("删除工作计划编号为" + planid + "的班委工作计划信息时出错！");
                }
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        //保存修改
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要修改这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
            {
                this.SearchAll();
                return;
            }
            this.DoModify();
        }

        //刷新表格
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.SearchAll();
        }

        private void DoModify()
        {
            if (this.ClassPlandataGridView.SelectedRows.Count > 0)
            {
                string planname = this.ClassPlandataGridView.SelectedRows[0].Cells["工作计划名称"].Value.ToString();
                string planid = this.ClassPlandataGridView.SelectedRows[0].Cells["工作计划编号"].Value.ToString();
                string sqlcmd = string.Format("update ClassPlan set PlanName = '{0}' where PlanID = {1}" , planname,int.Parse(planid));
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改班委工作计划信息失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        private bool DelByID(string planid)
        {
            string sqlcmd = string.Format("delete from ClassPlan where PlanID = '{0}'", planid);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }  
        
        private void DoInsert()
        {
            if (this.IsInputLegal())
            {
                string planname = this.PlanNameTBox.Text.Trim();
                if (this.AppendixNameLab.Text == "")
                {
                    string sqlcmd = string.Format("insert into ClassPlan(PlanName) values('{0}')", planname);
                    if (!DBModel.InsertCommand.insert(sqlcmd))
                    {
                        MessageBox.Show("班委工作计划信息录入失败！");
                        return;
                    }
                    MessageBox.Show("班委工作计划信息录入成功！");
                }
                else
                {
                    FileStream stream = new FileStream(this.appendixPath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    stream.Close();
                    if (!DBModel.InsertCommand.insert(planname,this.AppendixNameLab.Text,buffer))
                    {
                        MessageBox.Show("班委工作计划信息录入失败！");
                        return;
                    }
                    MessageBox.Show("班委工作计划信息录入成功！");
                    this.AppendixNameLab.Text = "";
                }
                this.SearchAll();
            }          
        }

        private void SearchAll()
        {
            string sqlcmd = "select PlanID as 工作计划编号,PlanName as 工作计划名称,AppendixName as 附件 from ClassPlan";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.ClassPlandataGridView.DataSource = this.searchTable;
        }

        private void SearchByName(string planname)
        {
            string sqlcmd = string.Format("select PlanID as 工作计划编号,PlanName as 工作计划名称,AppendixName as 附件 from ClassPlan where PlanName = '{0}'", planname);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到工作计划:" + planname + "的记录！");
                return;
            }
            this.ClassPlandataGridView.DataSource = this.searchTable;
        }

        private bool IsInputLegal()
        {
            if (this.PlanNameTBox.Text.Trim() == "")
            {
                MessageBox.Show("工作计划名称不能为空，请输入！");
                return false;
            }
            return true;
        }

        //设置班委工作计划编号不可修改
        private void ClassPlandataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.ClassPlandataGridView.ColumnCount;
            if (this.ClassPlandataGridView.CurrentCell.ColumnIndex == 0 || this.ClassPlandataGridView.CurrentCell.ColumnIndex == count - 1)
                this.ClassPlandataGridView.CurrentCell.ReadOnly = true;
            else
                this.ClassPlandataGridView.CurrentCell.ReadOnly = false;
        }

        private void AttachLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.AppendixopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.AppendixopenFileDialog.FileName.Length > 0)
                {
                    this.AppendixNameLab.Text = Path.GetFileName(this.AppendixopenFileDialog.FileName);
                    this.appendixPath = this.AppendixopenFileDialog.FileName;
                }
            }
        }

        private void OpenAppendixBtn_Click(object sender, EventArgs e)
        {
            string planid = this.ClassPlandataGridView.SelectedRows[0].Cells["工作计划编号"].Value.ToString();
            string sqlcmd1 = string.Format("select AppendixName from ClassPlan where PlanID = {0}", int.Parse(planid));
            string fname = DBModel.SelectCommand.getValue(sqlcmd1);
            if (fname == "")
            {
                MessageBox.Show("无工作计划附件！");
                return;
            }
            string sqlcmd2 = string.Format("select PlanAppendix from ClassPlan where PlanID = {0}", int.Parse(planid));
            byte[] bts = DBModel.SelectCommand.getBytesValue(sqlcmd2);
            string tempFName = Temp.TmpFileName;
            string exstr = "\\" + tempFName + fname.Substring(fname.LastIndexOf('.'));
            FileStream fs = new FileStream(exstr, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bts, 0, bts.Length);
            bw.Close();
            fs.Close();
            System.Diagnostics.Process.Start(exstr);
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if (this.ClassPlandataGridView.SelectedRows.Count > 0)
            {
                string planid = this.ClassPlandataGridView.SelectedRows[0].Cells["工作计划编号"].Value.ToString();
                string ppath = this.GetAppendixPath();
                if (ppath == null)
                    return;
                FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                stream.Close();
                if (!DBModel.UpdateCommand.updatePlanAppendix(int.Parse(planid), Path.GetFileName(ppath), buffer))
                {
                    MessageBox.Show("上传班级工作计划附件时出错！");
                }
                else
                {
                    MessageBox.Show("上传新附件成功！");
                    this.SearchAll();
                }
            }
        }

        private string GetAppendixPath()
        {
            string fpath = null;
            if (this.AppendixopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.AppendixopenFileDialog.FileName.Length > 0)
                {
                    fpath = this.AppendixopenFileDialog.FileName;
                }
            }
            return fpath;
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            for (int i = 0; i < this.tabControl1.TabCount; i++)
            {
                Rectangle recTab = tabControl1.GetTabRect(i);
                if (recTab.Contains(pt))
                {
                    if (this.MyDG != null)
                        this.MyDG();
                    return;
                }
            }
        }

        private void InitControl()
        {
            if (UserInfo.User.IsAdmin)
            {
                this.InsertCpBtn.Enabled = true;
                this.UploadBtn.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }
}
