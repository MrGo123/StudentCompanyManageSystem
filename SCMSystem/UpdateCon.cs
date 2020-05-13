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
    public partial class UpdateCon : Form
    {
        string ConId;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";

        public UpdateCon(string conId)
        {
            this.ConId = conId;
            conn = new SqlConnection(ConnectString);

            try
            {
                //开启连接           
                conn.Open();
                // MessageBox.Show("数据库连接成功!");           
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败!");
            }
            InitializeComponent();
        }

        private void UpdateConBT_Click(object sender, EventArgs e)
        {
            string conId = textBox1.Text.Trim();
            string ConDate = textBox2.Text.Trim();
            string StuNum = textBox3.Text.Trim();
            string ComId = textBox4.Text.Trim();
            string Salary = textBox5.Text.Trim();
            if (String.IsNullOrEmpty(conId))
            {
                MessageBox.Show("合同编号不能为空！");
            }
            if (String.IsNullOrEmpty(ConDate))
            {
                MessageBox.Show("签订日期不能为空！");
            }
            if (String.IsNullOrEmpty(StuNum))
            {
                MessageBox.Show("毕业生学号不能为空！");
            }

            if (String.IsNullOrEmpty(ComId))
            {
                MessageBox.Show("公司编号不能为空！");
            }
            if (String.IsNullOrEmpty(Salary))
            {
                MessageBox.Show("薪资不能为空！");
            }
            string sql = string.Format("update 签订协议 set 合同编号='{0}',签订日期='{1}',毕业生学号='{2}',用人单位编号='{3}' ,薪资='{4}'   where 合同编号='{5}'", conId, ConDate, StuNum, ComId, Salary, ConId);
            cmd = new SqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            conn.Close();
            this.Close();



        }

        private void UpdateCancleBT_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
    }
}
