using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
     class NumericTextBox: TextBox 
    {
         public NumericTextBox() {
             this.KeyPress += new KeyPressEventHandler(TextBoxKeyPress);
         }
         protected void TextBoxKeyPress(object sender, KeyPressEventArgs e) {
             if (!char.IsDigit(e.KeyChar)) e.Handled = true;
         }
    }
}
