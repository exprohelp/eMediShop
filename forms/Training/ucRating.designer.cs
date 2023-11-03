namespace eMediShop.forms.Training
{
    partial class ucRating
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlStar = new Telerik.WinControls.UI.RadPanel();
            this.btn = new Telerik.WinControls.UI.RadButton();
            this.starShape1 = new Telerik.WinControls.UI.StarShape();
            this.object_6072c481_3ccf_4016_b6ba_2be0ec39159d = new Telerik.WinControls.RootRadElement();
            ((System.ComponentModel.ISupportInitialize)(this.PnlStar)).BeginInit();
            this.PnlStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlStar
            // 
            this.PnlStar.Controls.Add(this.btn);
            this.PnlStar.Location = new System.Drawing.Point(1, 1);
            this.PnlStar.Name = "PnlStar";
            this.PnlStar.Size = new System.Drawing.Size(141, 31);
            this.PnlStar.TabIndex = 5;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(22, 22);
            this.btn.TabIndex = 0;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn.GetChildAt(0))).Shape = this.starShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.AliceBlue;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.AliceBlue;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.AliceBlue;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.AliceBlue;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn.GetChildAt(0).GetChildAt(0))).ClipDrawing = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btn.GetChildAt(0).GetChildAt(0))).AngleTransform = 0F;
            // 
            // object_6072c481_3ccf_4016_b6ba_2be0ec39159d
            // 
            this.object_6072c481_3ccf_4016_b6ba_2be0ec39159d.Name = "object_6072c481_3ccf_4016_b6ba_2be0ec39159d";
            this.object_6072c481_3ccf_4016_b6ba_2be0ec39159d.StretchHorizontally = true;
            this.object_6072c481_3ccf_4016_b6ba_2be0ec39159d.StretchVertically = true;
            // 
            // ucRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlStar);
            this.Name = "ucRating";
            this.Size = new System.Drawing.Size(144, 34);
            this.Load += new System.EventHandler(this.ucRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PnlStar)).EndInit();
            this.PnlStar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PnlStar;
        private Telerik.WinControls.RootRadElement object_6072c481_3ccf_4016_b6ba_2be0ec39159d;
        private Telerik.WinControls.UI.RadButton btn;
        private Telerik.WinControls.UI.StarShape starShape1;
    }
}
