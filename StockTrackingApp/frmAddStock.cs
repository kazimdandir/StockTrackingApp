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
                Product productControl = p.getProduct(txt_productCode.Text);

                if (productControl != null)
                    MessageBox.Show($"{txt_productCode.Text} kodlu ürün stokta zaten vardır. Ürün kodunu kontrol ediniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string productCodeToAdd = txt_productCode.Text;

                    bool isProductDeleted = Product.DeletedStockList.Any(x => x.ProductCode == productCodeToAdd);

                    if (isProductDeleted)
                    {
                        MessageBox.Show("Eklemek istediğiniz ürün silinmiş, eklenemiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    p.ProductCode = txt_productCode.Text;
                    p.ProductName = txt_productName.Text;
                    p.ProductCount = int.Parse(txt_productCount.Text);
                    p.ProductPurchasePrice = Convert.ToDouble(txt_productPurchasePrice.Text);
                    p.ProductSalesPrice = Convert.ToDouble(txt_productSalePrice.Text);

                    p.addProduct(p);

                    dialogResult = MessageBox.Show("Ürün eklenmiştir. Yeni ürün girişi yapmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                        MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                        frmHP.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK);
            }
        }

        private void btn_clearSelected_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Girdiğiniz bilgileri temizlemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                ClearSelected();
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (e.KeyChar == '0' && txt_productCount.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("Ürün adedi 0 olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_productPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
            
            if (e.KeyChar == '0' && txt_productPurchasePrice.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("Ürün alış fiyatı 0 olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txt_productSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == '0' && txt_productSalePrice.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("Ürün alış fiyatı 0 olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
