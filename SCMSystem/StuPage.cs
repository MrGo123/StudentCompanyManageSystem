using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSystem
{
    public partial class StuPage : Form
    {
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";
  
        
        string stuNum;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;

        public StuPage()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectString);
            //建立数据库连接
            try
            {
                //开启连接           
                conn.Open();    
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败!");
            }

        }

        private void StuPage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentCompanyDBDataSet1.毕业生”中
            DataGridViewDataLoad();
        }
        private void DataGridViewDataLoad()
        {
            String sql1 = "select * from 毕业生";
            adp = new SqlDataAdapter(sql1, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];
        }

        private void StuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StuAddBT_Click(object sender, EventArgs e)
        {
            AddStu addStu = new AddStu();
            addStu.StartPosition = FormStartPosition.CenterScreen;
            addStu.ShowDialog();
            DataGridViewDataLoad();
        }
        //按条件查询
        private void StuSearchBT_Click(object sender, EventArgs e)
        {
            string stuNum = GetBoxStuNum.Text.Trim();
            string stuName = GetBoxStuName.Text.Trim();
            string stuID = GetBoxStuID.Text.Trim();
            String sql4 = "Select * from 毕业生 where 1=1";
            if (!String.IsNullOrEmpty(stuNum))
            {
                sql4 += " and 学号=" + stuNum;
            }
            if (!String.IsNullOrEmpty(stuName))
            {
                sql4 += " and 姓名 like '%" + stuName + "%'";
            }
            if (!String.IsNullOrEmpty(stuID))
            {
                sql4 += " and 身份证号 like '%" + stuID + "%'";
            }
            adp = new SqlDataAdapter(sql4, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];
        }

        private void StuUpdateBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在学生信息显示框中单击所要删修改学生所在的那一行的任意文字区域即可！", "提示");
        }

        private void StuDeleBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在学生信息显示框中双击所要删除学生所在的那一行即可！", "提示");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除该学生信息？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                stuNum = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
                Console.WriteLine(stuNum);
                string sql2 = "delete from 毕业生 where 学号='" + stuNum+"'";
                cmd = new SqlCommand(sql2, conn);
                int count=cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            DataGridViewDataLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stuNum = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            UpdateStu updatestudent = new UpdateStu(stuNum);
            updatestudent.StartPosition = FormStartPosition.CenterScreen;
            updatestudent.ShowDialog();
            DataGridViewDataLoad();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }

   
    
}
