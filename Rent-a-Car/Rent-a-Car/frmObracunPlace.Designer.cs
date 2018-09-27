namespace Rent_a_Car
{
    partial class frmObracunPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObracunPlace));
            this.lblDatum = new System.Windows.Forms.Label();
            this.dgvOdradeno = new System.Windows.Forms.DataGridView();
            this.grbObracun = new System.Windows.Forms.GroupBox();
            this.lblUkupnaPlaca = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.lblRadniDani = new System.Windows.Forms.Label();
            this.txtRadniDani = new System.Windows.Forms.TextBox();
            this.lblRadniSati = new System.Windows.Forms.Label();
            this.txtRadniSati = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lblTrenutniDatum = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdradeno)).BeginInit();
            this.grbObracun.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(27, 13);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum";
            // 
            // dgvOdradeno
            // 
            this.dgvOdradeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdradeno.Location = new System.Drawing.Point(349, 72);
            this.dgvOdradeno.Name = "dgvOdradeno";
            this.dgvOdradeno.Size = new System.Drawing.Size(426, 237);
            this.dgvOdradeno.TabIndex = 1;
            // 
            // grbObracun
            // 
            this.grbObracun.Controls.Add(this.lblUkupnaPlaca);
            this.grbObracun.Controls.Add(this.txtUkupno);
            this.grbObracun.Controls.Add(this.lblRadniDani);
            this.grbObracun.Controls.Add(this.txtRadniDani);
            this.grbObracun.Controls.Add(this.lblRadniSati);
            this.grbObracun.Controls.Add(this.txtRadniSati);
            this.grbObracun.Controls.Add(this.lblPlaca);
            this.grbObracun.Controls.Add(this.txtPlaca);
            this.grbObracun.Controls.Add(this.btnIspis);
            this.grbObracun.Controls.Add(this.btnIzracunaj);
            this.grbObracun.Location = new System.Drawing.Point(30, 71);
            this.grbObracun.Name = "grbObracun";
            this.grbObracun.Size = new System.Drawing.Size(304, 311);
            this.grbObracun.TabIndex = 2;
            this.grbObracun.TabStop = false;
            this.grbObracun.Text = "Obracun place";
            // 
            // lblUkupnaPlaca
            // 
            this.lblUkupnaPlaca.AutoSize = true;
            this.lblUkupnaPlaca.Location = new System.Drawing.Point(32, 221);
            this.lblUkupnaPlaca.Name = "lblUkupnaPlaca";
            this.lblUkupnaPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblUkupnaPlaca.TabIndex = 10;
            this.lblUkupnaPlaca.Text = "Placa:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(175, 218);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 9;
            // 
            // lblRadniDani
            // 
            this.lblRadniDani.AutoSize = true;
            this.lblRadniDani.Location = new System.Drawing.Point(32, 180);
            this.lblRadniDani.Name = "lblRadniDani";
            this.lblRadniDani.Size = new System.Drawing.Size(61, 13);
            this.lblRadniDani.TabIndex = 8;
            this.lblRadniDani.Text = "Radni dani:";
            // 
            // txtRadniDani
            // 
            this.txtRadniDani.Location = new System.Drawing.Point(175, 177);
            this.txtRadniDani.Name = "txtRadniDani";
            this.txtRadniDani.Size = new System.Drawing.Size(100, 20);
            this.txtRadniDani.TabIndex = 7;
            // 
            // lblRadniSati
            // 
            this.lblRadniSati.AutoSize = true;
            this.lblRadniSati.Location = new System.Drawing.Point(32, 124);
            this.lblRadniSati.Name = "lblRadniSati";
            this.lblRadniSati.Size = new System.Drawing.Size(57, 13);
            this.lblRadniSati.TabIndex = 6;
            this.lblRadniSati.Text = "Radni sati:";
            // 
            // txtRadniSati
            // 
            this.txtRadniSati.Location = new System.Drawing.Point(175, 121);
            this.txtRadniSati.Name = "txtRadniSati";
            this.txtRadniSati.Size = new System.Drawing.Size(100, 20);
            this.txtRadniSati.TabIndex = 5;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(32, 62);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(75, 13);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa po satu:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(175, 59);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 3;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(200, 272);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(55, 272);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 0;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lblTrenutniDatum
            // 
            this.lblTrenutniDatum.AutoSize = true;
            this.lblTrenutniDatum.Location = new System.Drawing.Point(116, 13);
            this.lblTrenutniDatum.Name = "lblTrenutniDatum";
            this.lblTrenutniDatum.Size = new System.Drawing.Size(41, 13);
            this.lblTrenutniDatum.TabIndex = 3;
            this.lblTrenutniDatum.Text = "Datum:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(116, 42);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 4;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // frmObracunPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 394);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblTrenutniDatum);
            this.Controls.Add(this.grbObracun);
            this.Controls.Add(this.dgvOdradeno);
            this.Controls.Add(this.lblDatum);
            this.Name = "frmObracunPlace";
            this.Text = "frmObracunPlace";
            this.Load += new System.EventHandler(this.frmObracunPlace_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmObracunPlace_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdradeno)).EndInit();
            this.grbObracun.ResumeLayout(false);
            this.grbObracun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DataGridView dgvOdradeno;
        private System.Windows.Forms.GroupBox grbObracun;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label lblTrenutniDatum;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblRadniDani;
        private System.Windows.Forms.TextBox txtRadniDani;
        private System.Windows.Forms.Label lblRadniSati;
        private System.Windows.Forms.TextBox txtRadniSati;
        private System.Windows.Forms.Label lblUkupnaPlaca;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label lblKorisnik;
    }
}