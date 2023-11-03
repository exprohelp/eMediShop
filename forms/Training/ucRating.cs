using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
namespace eMediShop.forms.Training
{
    public partial class ucRating : UserControl
    {
        int rate = 0;
        public event RatingEventHandler RateUpdated;
        public ucRating(int rating)
        {
            rate = rating;
            InitializeComponent();
        }
        private void ucRating_Load(object sender, EventArgs e)
        {

            int x = 3;
            PnlStar.Controls.Clear();
            for (int i = 1; i <= 5; i++)
            {
                RadButton btnRate = new RadButton();
                btnRate.Location = new System.Drawing.Point(x, 3);
                btnRate.Name = "btn" + 1;
                x = x + 25;
                btnRate.Tag = i.ToString();
                btnRate.Size = new System.Drawing.Size(22, 22);
                btnRate.TabIndex = 0;
                btnRate.Click += new System.EventHandler(btnRate_Click);
                ((Telerik.WinControls.UI.RadButtonElement)(btnRate.GetChildAt(0))).Text = "";
                ((Telerik.WinControls.UI.RadButtonElement)(btnRate.GetChildAt(0))).Shape = this.starShape1;

                if (i - 1 >= rate)
                    btnRate.ButtonElement.ButtonFillElement.BackColor = Color.AliceBlue;
                else
                    btnRate.ButtonElement.ButtonFillElement.BackColor = Color.Yellow;
                ((Telerik.WinControls.Primitives.FillPrimitive)(btnRate.GetChildAt(0).GetChildAt(0))).GradientStyle = GradientStyles.Solid;
                PnlStar.Controls.Add(btnRate);
            }
        }
        private void btnRate_Click(object sender, EventArgs e)
        {
            int clickRate = Convert.ToInt32(((RadButton)sender).Tag);
            for (int i = 0; i < 5; i++)
            {
                RadButton rb = (RadButton)PnlStar.Controls[i];
                if (i >= clickRate)
                    rb.ButtonElement.ButtonFillElement.BackColor = Color.AliceBlue;
                else
                    rb.ButtonElement.ButtonFillElement.BackColor = Color.Yellow;
                ((Telerik.WinControls.Primitives.FillPrimitive)(rb.GetChildAt(0).GetChildAt(0))).GradientStyle = GradientStyles.Solid;
            }
            RatingEventArgs ValuArgs = new RatingEventArgs(clickRate);
            RateUpdated(this, ValuArgs);
         }
    }
    public delegate void RatingEventHandler(object sender, RatingEventArgs e);
    public class  RatingEventArgs : System.EventArgs
    {
        private int rating;
        public RatingEventArgs(int rating)
        {
            this.rating = rating;

        }
        public int Rating
        {
            get
            {
                return rating;
            }
        }
    }
}
