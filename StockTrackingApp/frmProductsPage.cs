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
    public partial class frmProductsPage : Form
    {
        public frmProductsPage()
        {
            InitializeComponent();
        }

        List<Product> pList = new List<Product>();

        private void frmStocks_Load(object sender, EventArgs e)
        {
            Product p = new Product();
            pList = p.getProductsList();

            dataGV_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGV_productList.DataSource = null;
            dataGV_productList.DataSource = pList;
        }
    }
}
