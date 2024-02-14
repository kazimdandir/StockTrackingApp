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
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        List<Product> pList = new List<Product>();
        frmHomePage frmHP = new frmHomePage();
        frmAddStock frmAS = new frmAddStock();  

        private void frmStocks_Load(object sender, EventArgs e)
        {
            Product p = new Product();
            pList = p.getProductsList();

            dataGV_stockList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGV_stockList.DataSource = null;
            dataGV_stockList.DataSource = pList;

            if (pList.Count == 0)
                MessageBox.Show("Herhangi bir ürün eklenmemiştir. Yeni ürün eklemek için 'Yeni Ürün Ekle' butonuna tıklayın.", "Uyarı", MessageBoxButtons.OK);
        }

        private void btn_newProductAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAS.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {      
            this.Close();
            frmHP.Show();
        }
    }
}
