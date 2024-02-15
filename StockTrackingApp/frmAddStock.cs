using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StockTrackingApp
{
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        DialogResult dialogResult;
        frmHomePage frmHP = new frmHomePage();

        private void btn_addStock_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductCode = txt_productCode.Text;
                p.ProductName = txt_productName.Text;
                p.ProductCount = int.Parse(txt_productCount.Text);
                p.ProductPurchasePrice = Convert.ToDouble(txt_productPurchasePrice.Text);
                p.ProductSalesPrice = Convert.ToDouble(txt_productSalePrice.Text);

                p.addProduct(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK);
            }

            dialogResult = MessageBox.Show("Ürün eklenmiştir. Yeni ürün girişi yapmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
            }

            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                frmHP.Show();
            }
        }

        private void btn_clearSelected_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Girdiğiniz bilgileri temizlemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                ClearSelected();
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
        }

        void ClearSelected()
        {
            txt_productCode.Clear();
            txt_productName.Clear();
            txt_productCount.Clear();
            txt_productPurchasePrice.Clear();
            txt_productSalePrice.Clear();
        }

        #region TextBox Validations
        private void txt_productCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_productName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_productCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_productPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }
        private void txt_productSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }
        #endregion
    }
}
