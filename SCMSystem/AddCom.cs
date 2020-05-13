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
    public partial class AddCom : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";
        public AddCom()
        {
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

        private void AddComBT_Click(object sender, EventArgs e)
        {
            string ComId = textBox1.Text.Trim();
            string ComName = textBox2.Text.Trim();
            string ComAddress = textBox3.Text.Trim();
            string ComPhone = textBox4.Text.Trim();
          
            if (String.IsNullOrEmpty(ComId))
            {
                MessageBox.Show("公司编号不能为空！");
            }
            if (String.IsNullOrEmpty(ComName))
            {
                MessageBox.Show("公司名称不能为空！");
            }
            if (String.IsNullOrEmpty(ComAddress))
            {
                MessageBox.Show("公司地址不能为空！");
            }

            if (String.IsNullOrEmpty(ComPhone))
            {
                MessageBox.Show("联系电话不能为空！");
            }
          
          
            string sql = string.Format("insert into 公司 values( '{0}','{1}','{2}','{3}')", ComId, ComName, ComAddress, ComPhone);
            cmd = new SqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            conn.Close();
            this.Close();
        }

        private void AddCancleBT_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

  
    }
}
