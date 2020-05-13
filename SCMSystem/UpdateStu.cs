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
    public partial class UpdateStu : Form
    {
        string stuNum;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";
        private SqlDataReader reader;

        public UpdateStu(string stuNum)
        {
            this.stuNum = stuNum;
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


        private void UpdateStu_Load(object sender, EventArgs e)
        {
        }
        private void UpdateStuBT_Click(object sender, EventArgs e)
        {
           string UpStuNum = UpBoxStuNum.Text.Trim();
            string StuName = UpBoxStuName.Text.Trim();
            string StuID = UpBoxStuID.Text.Trim();
           
           string AgeTemp = UpBoxStuAge.Text.Trim();
            string StuPhone = UpBoxStuPhone.Text.Trim();
            string StuAca = UpBoxStuAca.Text.Trim();
            string StuSub = UpBoxStuSub.Text.Trim();
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
            string sql = string.Format("update 毕业生 set 学号='{0}',身份证号='{1}',姓名='{2}',年龄='{3}',联系方式='{4}',学院='{5}',专业='{6}' where 学号='{7}'", UpStuNum,StuID,StuName, StuAge, StuPhone, StuAca, StuSub,stuNum);
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
            this.Close();
        }

        private void UpdateCancleBT_Click(object sender, EventArgs e)
        {
           this.Close();
        }

      
    }
}
