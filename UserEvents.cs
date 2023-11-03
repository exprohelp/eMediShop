using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMediShop
{
    public delegate void TextBoxKeyPressEventHandler(object sender, TextBoxKeyPressEventArgs e);
    public class TextBoxKeyPressEventArgs:EventArgs
    {
        string boxText = "";
        public TextBoxKeyPressEventArgs(string boxText)
        {
            this.boxText = boxText;
        }
        public string BoxText { get { return this.BoxText; } }
    }

    public delegate void EventCarrierHandler(object sender, EventCarrierArgs e);
    public class EventCarrierArgs : System.EventArgs
    {
        private string parameter;
        public EventCarrierArgs(string parameter)
        {
            this.parameter = parameter;
        }
        public string Paramenter { get { return this.parameter; } }
    }
}
