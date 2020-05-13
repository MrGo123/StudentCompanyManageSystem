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
    public partial class UpdateCom : Form
    {
        string ComId;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet dat;
        string ConnectString = "Data Source=HZY\\MYSQLEXPRESS;Initial Catalog=StudentCompanyDB;Integrated Security=True";
       
        public UpdateCom(string ComId)
        {
            this.ComId = ComId;
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
        private void UpdateCom_Load(object sender, EventArgs e)
        {
          
        }
        private void UpdateComBT_Click(object sender, EventArgs e)
        {
            string comId = UpBoxComId.Text.Trim();
            string ComName = UpBoxComName.Text.Trim();
            string ComAddress = UpBoxComAddress.Text.Trim();
            string ComPhone = UpBoxComPhone.Text.Trim();

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
            string sql = string.Format("update 公司 set 公司编号='{0}',公司名称='{1}',公司地址='{2}',联系电话='{3}' where 公司编号='{4}'", comId, ComName, ComAddress, ComPhone,ComId);
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
