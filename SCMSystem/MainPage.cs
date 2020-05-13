using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Stu_Click(object sender, EventArgs e)
        {
            StuPage stu = new StuPage();
            stu.StartPosition = FormStartPosition.CenterScreen;
            stu.Show();
            
          
        }

        private void Company_Click(object sender, EventArgs e)
        {
            CompanyPage company = new CompanyPage();
            company.StartPosition = FormStartPosition.CenterScreen;
            company.Show();
           
        }

        private void Contract_Click(object sender, EventArgs e)
        {
            ContractPage contract = new ContractPage();
            contract.StartPosition = FormStartPosition.CenterScreen;
            contract.Show();
            
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
   
    
}
