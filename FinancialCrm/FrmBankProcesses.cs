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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            

            var ZiraatBankinComingMoney = db.BankProcesses.Where(x => x.BankId == 1).Sum(y => y.Amount).ToString();
            lblZiraatBankinComingMoney.Text = ZiraatBankinComingMoney.ToString();

            var vakifbankComingMoney = db.BankProcesses.Where(x => x.BankId == 2).Sum(y => y.Amount).ToString();
            lblVakifBankinComingMoney.Text = vakifbankComingMoney.ToString();

            var isbankasiComingMoney = db.BankProcesses.Where(x => x.BankId == 3).Sum(y => y.Amount).ToString();
            lblIşBankinComingMoney.Text = isbankasiComingMoney.ToString();

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + Convert.ToDateTime(bankProcess1.ProcessDate).ToShortDateString() + " Tarihinde " + " " + bankProcess1.Banks.BankTitle + " Hesabına" + " " + bankProcess1.Amount + " ₺ Gelmiştir.";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + Convert.ToDateTime(bankProcess2.ProcessDate).ToShortDateString() + " Tarihinde " + " " + bankProcess2.Banks.BankTitle + " Hesabına" + " " + bankProcess2.Amount + " ₺ Gelmiştir.";

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + Convert.ToDateTime(bankProcess3.ProcessDate).ToShortDateString() + " Tarihinde " + " " + bankProcess3.Banks.BankTitle + " Hesabına" + " " + bankProcess3.Amount + " ₺ Gelmiştir.";


            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + Convert.ToDateTime(bankProcess4.ProcessDate).ToShortDateString() + " Tarihinde " + " " + bankProcess4.Banks.BankTitle + " Hesabına" + " " + bankProcess4.Amount + " ₺ Gelmiştir.";


            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + Convert.ToDateTime(bankProcess5.ProcessDate).ToShortDateString() + " Tarihinde " + " " + bankProcess5.Banks.BankTitle + " Hesabına" + " " + bankProcess5.Amount + " ₺ Gelmiştir.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
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
