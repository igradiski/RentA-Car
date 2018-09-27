namespace Rent_a_Car
{
    partial class SmjenaPlaca
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
            this.cbRadnikPlaca = new System.Windows.Forms.ComboBox();
            this.lblImeRadnikaPlaca = new System.Windows.Forms.Label();
            this.gbObracunPlace = new System.Windows.Forms.GroupBox();
            this.mcMjesec = new System.Windows.Forms.MonthCalendar();
            this.lblOdabirMjesecaPlaca = new System.Windows.Forms.Label();
            this.btnObracunaj = new System.Windows.Forms.Button();
            this.gbPlaniranjeSmjene = new System.Windows.Forms.GroupBox();
            this.mcSmjene = new System.Windows.Forms.MonthCalendar();
            this.lblOdabirMjesecaSmjena = new System.Windows.Forms.Label();
            this.lblImeRadnikaSmjena = new System.Windows.Forms.Label();
            this.cbRadnikSmjena = new System.Windows.Forms.ComboBox();
            this.btnPlaniranjeSmjene = new System.Windows.Forms.Button();
            this.gbObracunPlace.SuspendLayout();
            this.gbPlaniranjeSmjene.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRadnikPlaca
            // 
            this.cbRadnikPlaca.FormattingEnabled = true;
            this.cbRadnikPlaca.Location = new System.Drawing.Point(174, 30);
            this.cbRadnikPlaca.Name = "cbRadnikPlaca";
            this.cbRadnikPlaca.Size = new System.Drawing.Size(121, 21);
            this.cbRadnikPlaca.TabIndex = 0;
            // 
            // lblImeRadnikaPlaca
            // 
            this.lblImeRadnikaPlaca.AutoSize = true;
            this.lblImeRadnikaPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeRadnikaPlaca.Location = new System.Drawing.Point(6, 33);
            this.lblImeRadnikaPlaca.Name = "lblImeRadnikaPlaca";
            this.lblImeRadnikaPlaca.Size = new System.Drawing.Size(142, 17);
            this.lblImeRadnikaPlaca.TabIndex = 1;
            this.lblImeRadnikaPlaca.Text = "Ime i prezime radnika";
            // 
            // gbObracunPlace
            // 
            this.gbObracunPlace.Controls.Add(this.btnObracunaj);
            this.gbObracunPlace.Controls.Add(this.lblOdabirMjesecaPlaca);
            this.gbObracunPlace.Controls.Add(this.mcMjesec);
            this.gbObracunPlace.Controls.Add(this.lblImeRadnikaPlaca);
            this.gbObracunPlace.Controls.Add(this.cbRadnikPlaca);
            this.gbObracunPlace.Location = new System.Drawing.Point(29, 79);
            this.gbObracunPlace.Name = "gbObracunPlace";
            this.gbObracunPlace.Size = new System.Drawing.Size(417, 374);
            this.gbObracunPlace.TabIndex = 2;
            this.gbObracunPlace.TabStop = false;
            this.gbObracunPlace.Text = "Obracun place";
            // 
            // mcMjesec
            // 
            this.mcMjesec.Location = new System.Drawing.Point(174, 63);
            this.mcMjesec.Name = "mcMjesec";
            this.mcMjesec.TabIndex = 2;
            // 
            // lblOdabirMjesecaPlaca
            // 
            this.lblOdabirMjesecaPlaca.AutoSize = true;
            this.lblOdabirMjesecaPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabirMjesecaPlaca.Location = new System.Drawing.Point(6, 63);
            this.lblOdabirMjesecaPlaca.Name = "lblOdabirMjesecaPlaca";
            this.lblOdabirMjesecaPlaca.Size = new System.Drawing.Size(107, 17);
            this.lblOdabirMjesecaPlaca.TabIndex = 3;
            this.lblOdabirMjesecaPlaca.Text = "Odabir mjeseca";
            // 
            // btnObracunaj
            // 
            this.btnObracunaj.Location = new System.Drawing.Point(174, 286);
            this.btnObracunaj.Name = "btnObracunaj";
            this.btnObracunaj.Size = new System.Drawing.Size(199, 51);
            this.btnObracunaj.TabIndex = 4;
            this.btnObracunaj.Text = "Obracun";
            this.btnObracunaj.UseVisualStyleBackColor = true;
            this.btnObracunaj.Click += new System.EventHandler(this.OtvoriFormuZaObracun);
            // 
            // gbPlaniranjeSmjene
            // 
            this.gbPlaniranjeSmjene.Controls.Add(this.btnPlaniranjeSmjene);
            this.gbPlaniranjeSmjene.Controls.Add(this.lblImeRadnikaSmjena);
            this.gbPlaniranjeSmjene.Controls.Add(this.cbRadnikSmjena);
            this.gbPlaniranjeSmjene.Controls.Add(this.lblOdabirMjesecaSmjena);
            this.gbPlaniranjeSmjene.Controls.Add(this.mcSmjene);
            this.gbPlaniranjeSmjene.Location = new System.Drawing.Point(470, 79);
            this.gbPlaniranjeSmjene.Name = "gbPlaniranjeSmjene";
            this.gbPlaniranjeSmjene.Size = new System.Drawing.Size(450, 374);
            this.gbPlaniranjeSmjene.TabIndex = 3;
            this.gbPlaniranjeSmjene.TabStop = false;
            this.gbPlaniranjeSmjene.Text = "Planiranje smjena";
            // 
            // mcSmjene
            // 
            this.mcSmjene.Location = new System.Drawing.Point(192, 60);
            this.mcSmjene.Name = "mcSmjene";
            this.mcSmjene.TabIndex = 3;
            // 
            // lblOdabirMjesecaSmjena
            // 
            this.lblOdabirMjesecaSmjena.AutoSize = true;
            this.lblOdabirMjesecaSmjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabirMjesecaSmjena.Location = new System.Drawing.Point(24, 63);
            this.lblOdabirMjesecaSmjena.Name = "lblOdabirMjesecaSmjena";
            this.lblOdabirMjesecaSmjena.Size = new System.Drawing.Size(107, 17);
            this.lblOdabirMjesecaSmjena.TabIndex = 4;
            this.lblOdabirMjesecaSmjena.Text = "Odabir mjeseca";
            // 
            // lblImeRadnikaSmjena
            // 
            this.lblImeRadnikaSmjena.AutoSize = true;
            this.lblImeRadnikaSmjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeRadnikaSmjena.Location = new System.Drawing.Point(24, 30);
            this.lblImeRadnikaSmjena.Name = "lblImeRadnikaSmjena";
            this.lblImeRadnikaSmjena.Size = new System.Drawing.Size(142, 17);
            this.lblImeRadnikaSmjena.TabIndex = 6;
            this.lblImeRadnikaSmjena.Text = "Ime i prezime radnika";
            // 
            // cbRadnikSmjena
            // 
            this.cbRadnikSmjena.FormattingEnabled = true;
            this.cbRadnikSmjena.Location = new System.Drawing.Point(192, 27);
            this.cbRadnikSmjena.Name = "cbRadnikSmjena";
            this.cbRadnikSmjena.Size = new System.Drawing.Size(121, 21);
            this.cbRadnikSmjena.TabIndex = 5;
            // 
            // btnPlaniranjeSmjene
            // 
            this.btnPlaniranjeSmjene.Location = new System.Drawing.Point(192, 275);
            this.btnPlaniranjeSmjene.Name = "btnPlaniranjeSmjene";
            this.btnPlaniranjeSmjene.Size = new System.Drawing.Size(199, 51);
            this.btnPlaniranjeSmjene.TabIndex = 5;
            this.btnPlaniranjeSmjene.Text = "Planiraj smjenu";
            this.btnPlaniranjeSmjene.UseVisualStyleBackColor = true;
            this.btnPlaniranjeSmjene.Click += new System.EventHandler(this.OtvoriPlaniranjeSmjene);
            // 
            // SmjenaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 477);
            this.Controls.Add(this.gbPlaniranjeSmjene);
            this.Controls.Add(this.gbObracunPlace);
            this.Name = "SmjenaPlaca";
            this.Text = "SmjenaPlaca";
            this.gbObracunPlace.ResumeLayout(false);
            this.gbObracunPlace.PerformLayout();
            this.gbPlaniranjeSmjene.ResumeLayout(false);
            this.gbPlaniranjeSmjene.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRadnikPlaca;
        private System.Windows.Forms.Label lblImeRadnikaPlaca;
        private System.Windows.Forms.GroupBox gbObracunPlace;
        private System.Windows.Forms.Button btnObracunaj;
        private System.Windows.Forms.Label lblOdabirMjesecaPlaca;
        private System.Windows.Forms.MonthCalendar mcMjesec;
        private System.Windows.Forms.GroupBox gbPlaniranjeSmjene;
        private System.Windows.Forms.MonthCalendar mcSmjene;
        private System.Windows.Forms.Label lblImeRadnikaSmjena;
        private System.Windows.Forms.ComboBox cbRadnikSmjena;
        private System.Windows.Forms.Label lblOdabirMjesecaSmjena;
        private System.Windows.Forms.Button btnPlaniranjeSmjene;
    }
}