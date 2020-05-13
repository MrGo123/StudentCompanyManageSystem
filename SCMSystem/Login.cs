using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSystem
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

      
       
        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUserPSW_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
           string strUName = "";
            string strUPassWord = "";
        //获取文本框中的值
            strUName = this.textUserName.Text.Trim();
            strUPassWord = this.textUserPSW.Text.Trim();
            if (strUName.Equals("") || strUPassWord.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                using (conn = new SqlConnection("Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True"))
                {
                    conn.Open();
                    String sql = "select * from UserInfo where Username = @Username and UserPSW = @UserPSW";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@Username", textUserName.Text));
              
                    cmd.Parameters.Add(new SqlParameter("@UserPSW", textUserPSW.Text));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MainPage main1 = new MainPage();
                        main1.StartPosition = FormStartPosition.CenterScreen;
                        main1.Show(); 
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，请重新输入！");
                    }
                    conn.Close();
                }
            }
 
       }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            System.Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
   
}