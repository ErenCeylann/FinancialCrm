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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        void userList()
        {
            var values = db.Users.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            userList();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;

            Users users = new Users();
            users.UserName = userName;
            users.Password = userPassword;
            db.Users.Add(users);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userList();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            var user = db.Users.Find(id);

            db.Users.Remove(user);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userList();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserPassword.Text;
            int id = int.Parse(txtUserId.Text);
            var users = db.Users.Find(id);

            users.UserName = userName;
            users.Password = userPassword;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
