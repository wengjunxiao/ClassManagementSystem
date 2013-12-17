using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClassManagementSystem.StudentInfoManage
{
    public partial class SearchSInfoUC : UserControl
    {
        private DataTable searchTable = null;

        public SearchSInfoUC()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DoSearch();
        }

        private void DoSearch()
        {
            string sno = this.txtStuNo.Text.Trim();
            string sname = this.txtStuName.Text.Trim();
            if (sno == string.Empty && sname == string.Empty)
                this.SearchAll();
            else if (sno != string.Empty && sname == string.Empty)
                this.SearchByNo(sno);
            else if (sno == string.Empty && sname != string.Empty)
                this.SearchByName(sname);
            else
                this.SearchByNoAndName(sno, sname);
        }

        private void SearchAll()
        {
            string sqlcmd = "select Sno as 学号,Sname as 姓名,Sex as 性别,BirthDate as 出生日期,Class as 班级,Specialty as 专业,PhotoName as 照片名 from Students";
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("数据库中无任何学生信息！");
            else
                this.StudentsdataGridView.DataSource = this.searchTable;
        }

        private void SearchByName(string name)
        {
            string sqlcmd = string.Format("select Sno as 学号,Sname as 姓名,Sex as 性别,BirthDate as 出生日期,Class as 班级,Specialty as 专业,PhotoName as 照片名 from Students where Sname = '{0}'", name);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("数据库中无姓名为“" + name + "”的学生信息！");
            else
                this.StudentsdataGridView.DataSource = this.searchTable;
        }

        private void SearchByNo(string no)
        {
            string sqlcmd = string.Format("select Sno as 学号,Sname as 姓名,Sex as 性别,BirthDate as 出生日期,Class as 班级,Specialty as 专业,PhotoName as 照片名 from Students where Sno = '{0}'", no);
            this.searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("数据库中无学号为“" + no + "”的学生信息！");
            else
                this.StudentsdataGridView.DataSource = this.searchTable;
        }

        private void SearchByNoAndName(string no, string name)
        {
            string sqlcmd = string.Format("select Sno as 学号,Sname as 姓名,Sex as 性别,BirthDate as 出生日期,Class as 班级,Specialty as 专业,PhotoName as 照片名 from Students where Sno = '{0}' and Sname = '{1}'", no, name);
            DataTable searchTable = DBModel.SelectCommand.getTable(sqlcmd);
            if (this.searchTable.Rows.Count <= 0)
                MessageBox.Show("数据库中无学号为“" + no + "”,姓名为“" + name + "”学生信息！");
            else
                this.StudentsdataGridView.DataSource = this.searchTable;
        }

        private void txtStuNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoSearch();
            }
        }

        private void txtStuName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.DoSearch();
            }
        }

        //点击表格某行查看照片
        private void StudentsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sno = this.StudentsdataGridView.SelectedRows[0].Cells["学号"].Value.ToString();
            string sqlcmd1 = string.Format("select PhotoName from Students where Sno = '{0}'",sno);
            string fname = DBModel.SelectCommand.getValue(sqlcmd1);
            if (fname == "")
            {
                MessageBox.Show("该学生未上传过照片，无法查看！");
                return;
            }
            string sqlcmd2 = string.Format("select Photo from Students where Sno = '{0}'",sno);
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
    }
}
