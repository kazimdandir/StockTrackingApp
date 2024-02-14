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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btn_addStock_Click(object sender, EventArgs e)
        {
            frmAddStock frmAS = new frmAddStock();
            frmAS.ShowDialog();
        }

        private void btn_stocks_Click(object sender, EventArgs e)
        {
            frmStocks frmS = new frmStocks();
            frmS.ShowDialog();
        }

        private void btn_updateStock_Click(object sender, EventArgs e)
        {
            frmUpdateStock frmUS = new frmUpdateStock();
            frmUS.ShowDialog();
        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Thread.Sleep(500);
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("İşlemlerinize devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK);
        }
    }
}
