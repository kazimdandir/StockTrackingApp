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
        string productCode, productName;
        int productCount;
        double productPurchasePrice, productSalesPrice;

        public int Id { get; set; }
        public string ProductCode { get => productCode; set => productCode = value.ToUpper(); }
        public string ProductName { get => productName; set => productName = value.ToUpper(); }
        public int ProductCount { get => productCount; set => productCount = Math.Abs(value); }
        public double ProductPurchasePrice { get => productPurchasePrice; set => productPurchasePrice = value; }
        public double ProductSalesPrice { get => productSalesPrice; set => productSalesPrice = value; }

        private int _nextId = 1;
        public Product()
        {
            if (ProductList != null && ProductList.Count > 0)
                _nextId = ProductList.Max(p => p.Id) +1;
            Id = _nextId++;
        }

        public static List<Product> ProductList = new List<Product>()
        {
            new Product() { Id = 1, ProductCode = "AB12345678", ProductName = "Mutfak Masası", ProductCount = 27, ProductPurchasePrice = 1050.49, ProductSalesPrice = 1500.87 },
            new Product() { Id = 2, ProductCode = "CD23456789", ProductName = "TV Sehpası", ProductCount = 14, ProductPurchasePrice = 2047.69, ProductSalesPrice = 3056.78 },
            new Product() { Id = 3, ProductCode = "EF34567890", ProductName = "Altın Bilezik", ProductCount = 56, ProductPurchasePrice = 7256.89, ProductSalesPrice = 11004.90 },
            new Product() { Id = 4, ProductCode = "GH45678901", ProductName = "Dizüstü Bilgisayar", ProductCount = 39, ProductPurchasePrice = 27650.50, ProductSalesPrice = 32500.50 },
            new Product() { Id = 5, ProductCode = "IJ56789012", ProductName = "Spor Ayakkabı", ProductCount = 83, ProductPurchasePrice = 1945.99, ProductSalesPrice = 2780.50 },
            new Product() { Id = 6, ProductCode = "KL67890123", ProductName = "Platin Yüzük", ProductCount = 42, ProductPurchasePrice = 12150.05, ProductSalesPrice = 16350.45 },
            new Product() { Id = 7, ProductCode = "MN78901234", ProductName = "Yoga Matı", ProductCount = 71, ProductPurchasePrice = 250.45, ProductSalesPrice = 375.85 },
            new Product() { Id = 8, ProductCode = "OP89012345", ProductName = "Kablosuz Kulaklık", ProductCount = 20, ProductPurchasePrice = 4050.99, ProductSalesPrice = 5204.45 },
            new Product() { Id = 9, ProductCode = "QR90123456", ProductName = "Şal", ProductCount = 65, ProductPurchasePrice = 350.05, ProductSalesPrice = 420.75 },
            new Product() { Id = 10, ProductCode = "ST01234567", ProductName = "Egzersiz Topu", ProductCount = 91, ProductPurchasePrice = 150.75, ProductSalesPrice = 300.45 }
        };

        public static List<Product> DeletedProductList = new List<Product>();

        public Product addProduct(Product product)
        {
            ProductList.Add(product);
            return product;
        }

        public List<Product> getProductsList()
        {
            return ProductList;
        }

        public Product getProduct(string productCode)
        {
            Product selectedProductCode = ProductList.FirstOrDefault(x => x.ProductCode == productCode);
            return selectedProductCode;
        }

        public Product updateProductData(string productCode, string productName, int productCount, double productPurchasePrice, double productSalesPrice)
        {
            Product productToUpdate = ProductList.FirstOrDefault(x => x.ProductCode == productCode.ToUpper());
            if (productToUpdate == null)
            {
                MessageBox.Show($"{productCode} kodlu ürün bulunamamıştır, ürün kodunu kontrol ediniz.");
                return null;
            }
            else
            {
                productToUpdate.ProductName = productName;
                productToUpdate.ProductCount = productCount;
                productToUpdate.ProductPurchasePrice = productPurchasePrice;
                productToUpdate.ProductSalesPrice = productSalesPrice;

                int index = ProductList.IndexOf(productToUpdate);
                ProductList[index] = productToUpdate;

                return productToUpdate;
            }
        }

        public bool deleteProductData(string productCode)
        {
            Product productToRemove = ProductList.FirstOrDefault(p => p.ProductCode == productCode.ToUpper());

            if (productToRemove == null)
                return false;

            DeletedProductList.Add(productToRemove);

            ProductList.Remove(productToRemove);

            return true;
        }
    }
}
