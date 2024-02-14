using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public class Product
    {
        //string productCode, productName;
        //int productCount;
        //double productPurchasePrice, productSalesPrice;

        //public string ProductCode { get => productCode; set => productCode = value.ToUpper(); }
        //public string ProductName { get => productName; set => productName = value.Substring(0, 1).ToUpper() + value.Substring(1).ToUpper(); }

        //public int ProductCount
        //{
        //    get { return productCount; }
        //    set
        //    {
        //        if (productCount == 0)
        //            MessageBox.Show("Ürün adedi sıfır olmamalıdır!", "Uyarı", MessageBoxButtons.OK);
        //        else
        //            productCount = Math.Abs(value);
        //    }
        //}
        //public double ProductPurchasePrice
        //{
        //    get { return productPurchasePrice; }
        //    set
        //    {
        //        if (productPurchasePrice == 0)
        //            MessageBox.Show("Ürün alış fiyatı sıfır olmamalıdır!", "Uyarı", MessageBoxButtons.OK);
        //        else
        //            productPurchasePrice = Math.Abs(value);
        //    }
        //}
        //public double ProductSalesPrice
        //{
        //    get { return productSalesPrice; }
        //    set
        //    {
        //        if (productSalesPrice == 0)
        //            MessageBox.Show("Ürün satış sıfır olmamalıdır!", "Uyarı", MessageBoxButtons.OK);
        //        else
        //            productSalesPrice = Math.Abs(value);
        //    }
        //}

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public double ProductPurchasePrice { get; set; }
        public double ProductSalesPrice { get; set; }

        public static List<Product> StockList = new List<Product>();

        public Product addProduct(Product product)
        {
            StockList.Add(product);
            return product;
        }

        public List<Product> getProductsList()
        {
            return StockList;
        }

        public Product getProduct(string productCode)
        {
            Product selectedProductCode = StockList.FirstOrDefault(x => x.ProductCode == productCode);
            return selectedProductCode;
        }

        public Product updateProductData(string productCode, string productName, int productCount, double productPurchasePrice, double productSalesPrice)
        {
            Product productToUpdate = StockList.FirstOrDefault(x => x.ProductCode == productCode);
            if (productToUpdate == null)
            {
                MessageBox.Show($"{ProductCode} kodlu ürün bulunamamıştır, ürün kodunu kontrol ediniz.");
                return null;
            }
            else
            {
                productToUpdate.ProductName = productName;
                productToUpdate.ProductCount = productCount;
                productToUpdate.ProductPurchasePrice = productPurchasePrice;
                productToUpdate.ProductSalesPrice = productSalesPrice;

                int index = StockList.IndexOf(productToUpdate);
                StockList[index] = productToUpdate;

                return productToUpdate;
            }
        }

        public bool deleteProductData(string productCode)
        {
            Product productToRemove = StockList.FirstOrDefault(p => p.ProductCode == productCode);

            if (productToRemove == null)
                return false;

            StockList.Remove(productToRemove);

            return true;
        }
    }
}
