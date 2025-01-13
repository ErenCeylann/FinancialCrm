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
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmS_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.GroupBy(x => x.SpendingTitle).OrderByDescending(y => y.Count()).FirstOrDefault();

            lblMostSpending.Text = $"{values.Key}";

            var expensiveSpending = db.Spendings.OrderByDescending(x => x.SpendingAmount).Select(y => y.SpendingTitle).FirstOrDefault();
            lblExpensiveSpending.Text = expensiveSpending.ToString();

            var lastTime = db.Spendings.OrderByDescending(x => x.SpendingId).Select(y => y.SpendingTitle).FirstOrDefault();
            lblLastTimeSpending.Text = lastTime.ToString();

            var spending1 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(1).FirstOrDefault();
            lblSpending1.Text = spending1.SpendingTitle + "   " + spending1.SpendingAmount + "₺" + "           " + Convert.ToDateTime(spending1.SpengingDate).ToShortDateString();

            var spending2 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(2).Skip(1).FirstOrDefault();
            lblSpending2.Text = spending2.SpendingTitle + "   " + spending2.SpendingAmount + "₺" + "           " + Convert.ToDateTime(spending2.SpengingDate).ToShortDateString();

            var spending3 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(3).Skip(2).FirstOrDefault();
            lblSpending3.Text = spending3.SpendingTitle + "   " + spending3.SpendingAmount + "₺" + "           " + Convert.ToDateTime(spending3.SpengingDate).ToShortDateString();


            var spending4 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(4).Skip(3).FirstOrDefault();
            lblSpending4.Text = spending4.SpendingTitle + "   " + spending4.SpendingAmount + "₺" + "           " + Convert.ToDateTime(spending4.SpengingDate).ToShortDateString();


            var spending5 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(5).Skip(4).FirstOrDefault();
            lblSpending5.Text = spending5.SpendingTitle + "   " + spending5.SpendingAmount + "₺" + "           " + Convert.ToDateTime(spending5.SpengingDate).ToShortDateString();

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
            FrmBilling billing = new FrmBilling();
            billing.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }
    }
}
