using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class frmUpdateStock : Form
    {
        public frmUpdateStock()
        {
            InitializeComponent();
        }

        DialogResult dialogResult;
        frmHomePage frmHP = new frmHomePage();
        Product p = new Product();

        private void btn_updateStock_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Güncelleme yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                p.updateProductData(txt_productCode.Text, txt_productName.Text, int.Parse(txt_productCount.Text), Convert.ToDouble(txt_productPurchasePrice.Text), Convert.ToDouble(txt_productSalePrice.Text));

                dialogResult = MessageBox.Show($"{txt_productName.Text} stoğu güncellendi. Yeni bir güncelleme yapmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                    MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                    frmHP.Show();
                }
            }
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
        }

        private void btn_clearSelected_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Girdiğiniz bilgileri temizlemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                ClearSelected();
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show($"{txt_productName.Text} stoğunu silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                p.deleteProductData(txt_productCode.Text);

                dialogResult = MessageBox.Show($"{txt_productName.Text} stoğu silinmiştir. Güncelleme işlemlerinize devam etmek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                    MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                    frmHP.Show();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                frmHP.Show();
            }
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            Product selectedProduct = p.getProduct(txt_productCode.Text);
            txt_productName.Text = selectedProduct.ProductName;
            txt_productCount.Text = selectedProduct.ProductCount.ToString();
            txt_productPurchasePrice.Text = selectedProduct.ProductPurchasePrice.ToString();  
            txt_productSalePrice.Text = selectedProduct.ProductSalesPrice.ToString();
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
