namespace Rent_a_Car
{
    partial class frmIzvjestaj
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvjestaj));
            this.rpvPreglednik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvPreglednik
            // 
            this.rpvPreglednik.LocalReport.ReportEmbeddedResource = "Rent_a_Car.rptIIsplataPlace.rdlc";
            this.rpvPreglednik.Location = new System.Drawing.Point(43, 44);
            this.rpvPreglednik.Name = "rpvPreglednik";
            this.rpvPreglednik.ServerReport.BearerToken = null;
            this.rpvPreglednik.Size = new System.Drawing.Size(649, 296);
            this.rpvPreglednik.TabIndex = 0;
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvPreglednik);
            this.Name = "frmIzvjestaj";
            this.Text = "frmIzvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmIzvjestaj_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPreglednik;
    }
}