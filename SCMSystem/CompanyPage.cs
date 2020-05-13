using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSystem
{
    public partial class CompanyPage : Form
    {
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";


        string comId;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        public CompanyPage()
        {
           
            conn = new SqlConnection(ConnectString);
            //建立数据库连接
            try
            {       
                conn.Open();       
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败!");
            } 
            InitializeComponent();
        }

        private void CompanyPage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentCompanyDBDataSet1.公司”中。您可以根据需要移动或删除它。
            DataGridViewDataLoad();

        }
        private void DataGridViewDataLoad()
        {
            String sql1 = "select * from 公司";
            adp = new SqlDataAdapter(sql1, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];
        }


        private void ComSearch_Click(object sender, EventArgs e)
        {
            string ComId = ComBoxId.Text.Trim();
            string ComName = ComBoxName.Text.Trim();
           
            String sql4 = "Select * from 公司 where 1=1";
            if (!String.IsNullOrEmpty(ComId))
            {
                sql4 += " and 公司编号='" + ComId+"'";
            }
            if (!String.IsNullOrEmpty(ComName))
            {
                sql4 += " and 公司名称 like '%" + ComName + "%'";
            }
          
            adp = new SqlDataAdapter(sql4, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];
        }

        private void ComCancleBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComDeleteBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在公司信息显示框中双击所要删除所在行的任意文字区域即可！", "提示");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show("确定删除该公司信息？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                
                comId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
                Console.WriteLine(comId);
                string sql2 = "delete from 公司 where 公司编号='" + comId+"'";
                cmd = new SqlCommand(sql2, conn);
                int count = cmd.ExecuteNonQuery();
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
            comId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            UpdateCom updatecom = new UpdateCom(comId);
            updatecom.StartPosition = FormStartPosition.CenterScreen;
            updatecom.ShowDialog();
            DataGridViewDataLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在公司信息显示框中单击所要修改的公司所在行即可！", "提示");
        }

        private void AddComBT_Click(object sender, EventArgs e)
        {
            AddCom addCom = new AddCom();
            addCom.StartPosition = FormStartPosition.CenterScreen;
            addCom.ShowDialog();
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
