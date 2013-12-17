using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassManagementSystem.ClassFileManage
{
    public partial class ClassFileUC : UserControl
    {
        private DataTable searchTable = null;
        private string appendixPath = "";
        private event MyDelegate MyDG;

        public ClassFileUC(mainForm mf)
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
            string ftheme = this.FileThemeTBox.Text.Trim();
            if (ftheme == "")
                this.SearchAll();
            else
                this.SearchByTheme(ftheme);
        }

        //录入
        private void InsertCfBtn_Click(object sender, EventArgs e)
        {
            this.DoInsert();
            this.AppendixNameLab.Text = "";
        }


        //撤销
        private void DrawBackBtn_Click(object sender, EventArgs e)
        {
            this.FileThemeTBox.Clear();
            this.AppendixNameLab.Text = "";
        }

        //删除记录
        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("您真的要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR != DialogResult.Yes)
                return;
            if (this.ClassFiledataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.ClassFiledataGridView.SelectedRows.Count; i++)
                {
                    string fileid = this.ClassFiledataGridView.SelectedRows[i].Cells["文档编号"].Value.ToString();
                    if (!this.DelByID(fileid))
                        MessageBox.Show("删除文档编号为：" + fileid + "的班级文档时出错！");
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

        private void DoInsert()
        {
            if (this.IsInputLegal())
            {
                string theme = this.FileThemeTBox.Text.Trim();
                if (this.AppendixNameLab.Text == "")
                {
                    string sqlcmd = string.Format("insert into ClassFile(FileTheme) values('{0}')", theme);
                    if (!DBModel.InsertCommand.insert(sqlcmd))
                    {
                        MessageBox.Show("班级文档录入失败！");
                        return;
                    }
                    MessageBox.Show("班级文档录入成功！");
                }
                else
                {
                    FileStream stream = new FileStream(this.appendixPath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);
                    stream.Close();
                    if (!DBModel.InsertCommand.insertFile(theme, this.AppendixNameLab.Text, buffer))
                    {
                        MessageBox.Show("班级文档录入失败！");
                        return;
                    }
                    MessageBox.Show("班级文档录入成功！");
                }
                this.SearchAll();
                this.AppendixNameLab.Text = "";
            }
        }

        private void DoModify()
        {
            if (this.ClassFiledataGridView.SelectedRows.Count > 0)
            {
                string theme = this.ClassFiledataGridView.SelectedRows[0].Cells["文档主题"].Value.ToString();
                string fileid = this.ClassFiledataGridView.SelectedRows[0].Cells["文档编号"].Value.ToString();
                string sqlcmd = string.Format("update ClassFile set FileTheme = '{0}' where FileID = '{1}'", theme, int.Parse(fileid));
                if (!DBModel.UpdateCommand.update(sqlcmd))
                    MessageBox.Show("修改班级文档信息失败！");
                this.SearchAll();
            }
            else
                MessageBox.Show("您未选中任何行！");
        }

        private bool DelByID(string fileid)
        {
            string sqlcmd = string.Format("delete from ClassFile where FileID = '{0}'", fileid);
            return DBModel.DeleteCommand.delete(sqlcmd);
        }  
        
        private void DoInsert(string file)
        {
            string sqlcmd = string.Format("insert into ClassFile(FileTheme) values('{0}')", file);
            if (!DBModel.InsertCommand.insert(sqlcmd))
            {
                MessageBox.Show("班级文档信息录入失败！");
                return;
            }
            MessageBox.Show("班级文档信息录入成功！");
            this.SearchAll();
        }

        private void SearchByTheme(string file)
        {
            string sqlcmd = string.Format("select FileID as 文档编号,FileTheme as 文档主题,AppendixName 附件 from ClassFile where FileTheme = '{0}'", file);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
            {
                MessageBox.Show("查询不到文档主题为：" + file + "的文档！");
                return;
            }
            this.ClassFiledataGridView.DataSource = this.searchTable;
        }

        private void SearchAll()
        {
            string sqlcmd = "select FileID as 文档编号,FileTheme as 文档主题,AppendixName 附件 from ClassFile";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            this.ClassFiledataGridView.DataSource = this.searchTable;
        }

        private bool IsInputLegal()
        {
            if (this.FileThemeTBox.Text.Trim() == "")
            {
                MessageBox.Show("文档主题不能为空，请输入！");
                return false;
            }
            return true;
        }

        //设置班级文档编号不可修改
        private void ClassFiledataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int count = this.ClassFiledataGridView.ColumnCount;
            if (this.ClassFiledataGridView.CurrentCell.ColumnIndex == 0 || this.ClassFiledataGridView.CurrentCell.ColumnIndex == count - 1)
                this.ClassFiledataGridView.CurrentCell.ReadOnly = true;
            else
                this.ClassFiledataGridView.CurrentCell.ReadOnly = false;
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

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            string fileid = this.ClassFiledataGridView.SelectedRows[0].Cells["文档编号"].Value.ToString();
            string sqlcmd1 = string.Format("select AppendixName from ClassFile where FileID = '{0}'", fileid);
            string fname = DBModel.SelectCommand.getValue(sqlcmd1);
            if (fname == "")
            {
                MessageBox.Show("无班级文档附件！");
                return;
            }
            string sqlcmd2 = string.Format("select FileAppendix from ClassFile where FileID = '{0}'", fileid);
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
            if (this.ClassFiledataGridView.SelectedRows.Count > 0)
            {
                string fileid = this.ClassFiledataGridView.SelectedRows[0].Cells["文档编号"].Value.ToString();
                string ppath = this.GetAppendixPath();
                if (ppath == null)
                    return;
                FileStream stream = new FileStream(ppath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, (int)stream.Length);
                stream.Close();
                if (!DBModel.UpdateCommand.updateFileAppendix(int.Parse(fileid), Path.GetFileName(ppath), buffer))
                {
                    MessageBox.Show("上传班级文档附件时出错！");
                }
                else
                {
                    MessageBox.Show("上传新文档成功！");
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
                this.InsertCfBtn.Enabled = true;
                this.UploadBtn.Enabled = true;
                this.DelBtn.Enabled = true;
                this.ModifyBtn.Enabled = true;
            }
        }
    }
}
