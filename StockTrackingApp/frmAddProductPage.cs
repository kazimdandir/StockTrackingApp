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

namespace StockTrackingApp
{
    public partial class frmAddProductPage : Form, IOperationService
    {
        public frmAddProductPage()
        {
            InitializeComponent();
            this.TopMost = true;
        } 

        DialogResult dialogResult;
        bool isAnyTextBoxEmpty;

        private void btn_addStock_Click(object sender, EventArgs e)
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

                Product p = new Product();
                Product productControl = p.getProduct(txt_productCode.Text.ToUpper());

                if (productControl != null)
                    MessageBox.Show($"{txt_productCode.Text} no'lu ürün stokta zaten vardır. Ürün kodunu kontrol ediniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string productCodeToAdd = txt_productCode.Text;

                    bool isProductDeleted = Product.DeletedProductList.Any(x => x.ProductCode == productCodeToAdd.ToUpper());

                    if (isProductDeleted)
                    {
                        MessageBox.Show("Eklemek istediğiniz ürün silinmiş, eklenemiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    p.ProductCode = txt_productCode.Text.ToUpper();
                    p.ProductName = txt_productName.Text;
                    p.ProductCount = int.Parse(txt_productCount.Text);
                    p.ProductPurchasePrice = Convert.ToDouble(txt_productPurchasePrice.Text);
                    p.ProductSalesPrice = Convert.ToDouble(txt_productSalePrice.Text);

                    p.addProduct(p);

                    dialogResult = MessageBox.Show("Ürün eklenmiştir. Yeni ürün girişi yapmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                        MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (dialogResult == DialogResult.No)
                        this.Close();
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
            priceValidation(sender, e, txt_productPurchasePrice);
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
