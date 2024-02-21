using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public interface IOperationService
    {
        void clearSelected();
        void nameValidation(object sender, KeyPressEventArgs e);
        void countValidation(object sender, KeyPressEventArgs e, TextBox txtProductCount);
        void priceValidation(object sender, KeyPressEventArgs e, TextBox textBox);
    }
}
