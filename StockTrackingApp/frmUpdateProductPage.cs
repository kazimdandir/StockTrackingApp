using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class frmUpdateProductPage : Form, IOperationService
    {
        public frmUpdateProductPage()
        {
            InitializeComponent();
        }

        DialogResult dialogResult;
        Product p = new Product();
        bool isAnyTextBoxEmpty;

        private void btn_updateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                isAnyTextBoxEmpty = txt_productCode.Text.Trim().Length == 0 ||
                                    txt_productName.Text.Trim().Length == 0 ||
                                    txt_productCount.Text.Trim().Length == 0 ||
                                    txt_productPurchasePrice.Text.Trim().Length == 0 ||
                                    txt_productSalePrice.Text.Trim().Length == 0;

                if (isAnyTextBoxEmpty)
                {
                    MessageBox.Show("Herhangi bir kutucuğu boş bırakmamalısınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string productCodeToAdd = txt_productCode.Text;

                bool isProductDeleted = Product.DeletedProductList.Any(x => x.ProductCode == productCodeToAdd);

                if (isProductDeleted)
                {
                    MessageBox.Show("Eklemek istediğiniz ürün silinmiş, güncellenemiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Product selectedProduct = p.getProduct(txt_productCode.Text.ToUpper());

                string productCode = txt_productCode.Text.ToUpper();
                string productName = txt_productName.Text;
                int productCount = int.Parse(txt_productCount.Text);
                double productPurchasePrice = Convert.ToDouble(txt_productPurchasePrice.Text);
                double productSalesPrice = Convert.ToDouble(txt_productSalePrice.Text);

                if (selectedProduct != null)
                {
                    MessageBox.Show("Herhangi bir değişiklik yapılmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Product listControl = p.updateProductData(txt_productCode.Text, txt_productName.Text, int.Parse(txt_productCount.Text), Convert.ToDouble(txt_productPurchasePrice.Text), Convert.ToDouble(txt_productSalePrice.Text));

                if (listControl != null)
                {
                    dialogResult = MessageBox.Show("Güncelleme yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        dialogResult = MessageBox.Show($"{txt_productCode.Text} no'lu ürün stoğu güncellendi. Yeni bir güncelleme yapmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                            MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                        MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clearSelected_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string productCodeToDelete = txt_productCode.Text.ToUpper();

            bool isProductDeleted = Product.ProductList.Any(x => x.ProductCode == productCodeToDelete);

            if (isProductDeleted == false)
            {
                MessageBox.Show("Silinmek istenen ürün stokta bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dialogResult = MessageBox.Show($"{txt_productCode.Text} ürün stoğunu silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                p.deleteProductData(txt_productCode.Text);

                dialogResult = MessageBox.Show($"{txt_productCode.Text} ürün stoğu silinmiştir. Güncelleme işlemlerinize devam etmek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                    MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (dialogResult == DialogResult.No)
                    this.Close();
            }
            else if (dialogResult == DialogResult.No)
                this.Close();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {

            string productCodeToAdd = txt_productCode.Text.ToUpper(); ;

            bool isProductDeleted = Product.DeletedProductList.Any(x => x.ProductCode == productCodeToAdd);

            if (isProductDeleted)
            {
                MessageBox.Show("Eklemek istediğiniz ürün silinmiş, getirilemiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product selectedProduct = p.getProduct(txt_productCode.Text.ToUpper());

            bool productCodeControl = txt_productCode.Text.Trim().Length == 0;

            if (selectedProduct != null && productCodeControl == false)
            {
                txt_productName.Text = selectedProduct.ProductName;
                txt_productCount.Text = selectedProduct.ProductCount.ToString();
                txt_productPurchasePrice.Text = selectedProduct.ProductPurchasePrice.ToString();
                txt_productSalePrice.Text = selectedProduct.ProductSalesPrice.ToString();
            }
            else
                MessageBox.Show($"'{txt_productCode.Text.ToUpper()}' ürün kodu stoklarınızda bulunmamaktadır, kodu kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region TextBox Validations
        private void txt_productName_KeyPress(object sender, KeyPressEventArgs e)
        {
            nameValidation(sender, e);
        }

        private void txt_productCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            countValidation(sender, e, txt_productCount);
        }

        private void txt_productPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceValidation(sender, e, txt_productPurchasePrice);
        }

        private void txt_productSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            priceValidation(sender, e, txt_productSalePrice);
        }
        #endregion

        #region OperationServices
        public void clearSelected()
        {
            dialogResult = MessageBox.Show("Girdiğiniz bilgileri temizlemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txt_productCode.Clear();
                txt_productName.Clear();
                txt_productCount.Clear();
                txt_productPurchasePrice.Clear();
                txt_productSalePrice.Clear();
            }
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void nameValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void countValidation(object sender, KeyPressEventArgs e, TextBox txtProductCount)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == '0' && txtProductCount.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("Ürün adedi 0 olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void priceValidation(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == '0' && textBox.Text.Length == 0)
            {
                e.Handled = true;
                MessageBox.Show("Fiyat 0 olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
