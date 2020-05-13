using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSystem
{
    public partial class ContractPage : Form
    {
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";


        string conId;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        public ContractPage()
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
        private void DataGridViewDataLoad()
        {
            String sql1 = "select * from 签订协议";
            adp = new SqlDataAdapter(sql1, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];
        }
        private void ContractPage_Load(object sender, EventArgs e)
        {
            DataGridViewDataLoad();

        }

        private void ConSearchBT_Click(object sender, EventArgs e)
        {
            string ConId = ConBoxConId.Text.Trim();
           

            String sql4 = "Select * from 签订协议 where 1=1";
            if (!String.IsNullOrEmpty(ConId))
            {
                sql4 += " and 合同编号='" + ConId + "'";
            }
            adp = new SqlDataAdapter(sql4, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];
        }

       
        private void ConDeleBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在合同信息显示框中双击所要删除的合同所在行即可！", "提示");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除该合同信息？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                conId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
                Console.WriteLine(conId);
                string sql2 = "delete from 签订协议 where 合同编号='" + conId + "'";
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
            conn.Close();
        }
        private void ConExit_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void ConAddBT_Click(object sender, EventArgs e)
        {
            AddContract addCon = new AddContract();
            addCon.StartPosition = FormStartPosition.CenterScreen;
            addCon.ShowDialog();
            DataGridViewDataLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            UpdateCon updatecon = new UpdateCon(conId);
            updatecon.StartPosition = FormStartPosition.CenterScreen;
            updatecon.ShowDialog();
            DataGridViewDataLoad();
        }

        private void ConUpdateBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在合同信息显示框中双击所要修改的合同所在的行即可！", "提示");
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
