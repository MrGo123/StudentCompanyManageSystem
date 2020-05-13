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
    public partial class AddStu : Form
    {
        
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";
       
        public AddStu()
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


        private void AddStuBT_Click(object sender, EventArgs e)
        {
            string UpStuNum = textBox1.Text.Trim();
            string StuName = textBox2.Text.Trim();
            string StuID = textBox3.Text.Trim();

            string AgeTemp = textBox4.Text.Trim();
            string StuPhone = textBox5.Text.Trim();
            string StuAca = textBox6.Text.Trim();
            string StuSub = textBox7.Text.Trim();
            if (String.IsNullOrEmpty(UpStuNum))
            {
                MessageBox.Show("学号不能为空！");
            }
            if (String.IsNullOrEmpty(StuName))
            {
                MessageBox.Show("姓名不能为空！");
            }
            if (String.IsNullOrEmpty(StuID))
            {
                MessageBox.Show("身份证号不能为空！");
            }

            if (String.IsNullOrEmpty(AgeTemp))
            {
                MessageBox.Show("年龄不能为空！");
            }
            if (String.IsNullOrEmpty(StuPhone))
            {
                MessageBox.Show("联系方式不能为空！");
            }
            if (String.IsNullOrEmpty(StuAca))
            {
                MessageBox.Show("姓名不能为空！");
            }

            if (String.IsNullOrEmpty(StuSub))
            {
                MessageBox.Show("专业不能为空！");
            }
            int StuAge;
            Int32.TryParse(AgeTemp, out StuAge);
            string sql = string.Format("insert into 毕业生 values( '{0}','{1}','{2}','{3}','{4}','{5}','{6}')", UpStuNum, StuID, StuName, StuAge, StuPhone, StuAca, StuSub);
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
