using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db=new FinancialCrmDbEntities1();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName=txtUserName.Text;
            string userPassword=txtUserPassword.Text;
            var userControl = db.Users.FirstOrDefault(x=>x.UserName==userName && x.Password==userPassword);
            if (userControl != null)
            {
                FrmDashboard frmDashboard = new FrmDashboard(); 
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
