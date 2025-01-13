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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        void categoryList()
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {

            categoryList();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            categoryList();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            Categories categories = new Categories();
            categories.CategoryName = categoryName;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Yeni Kategori Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            categoryList();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var categoryId = db.Categories.Find(id);
            db.Categories.Remove(categoryId);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            categoryList();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);
            var values = db.Categories.Find(id);
            values.CategoryName = categoryName;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            categoryList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }
    }
}
