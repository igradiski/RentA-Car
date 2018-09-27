namespace Rent_a_Car
{
    partial class frmRegistracija
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistracija));
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblMobitel = new System.Windows.Forms.Label();
            this.txtMobitel = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.lblOIB = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.cmbTipKorisnika = new System.Windows.Forms.ComboBox();
            this.tipKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTipKorisnika = new System.Windows.Forms.Label();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumRodenja = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.grpRegistracija = new System.Windows.Forms.GroupBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipKorisnikaBindingSource)).BeginInit();
            this.grpRegistracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Location = new System.Drawing.Point(39, 315);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 65;
            this.lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(160, 310);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(228, 22);
            this.txtMail.TabIndex = 64;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefon.Location = new System.Drawing.Point(39, 287);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(88, 17);
            this.lblTelefon.TabIndex = 63;
            this.lblTelefon.Text = "Broj telefona";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(160, 282);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(228, 22);
            this.txtTelefon.TabIndex = 62;
            // 
            // lblMobitel
            // 
            this.lblMobitel.AutoSize = true;
            this.lblMobitel.BackColor = System.Drawing.Color.Transparent;
            this.lblMobitel.Location = new System.Drawing.Point(39, 250);
            this.lblMobitel.Name = "lblMobitel";
            this.lblMobitel.Size = new System.Drawing.Size(90, 17);
            this.lblMobitel.TabIndex = 61;
            this.lblMobitel.Text = "Broj mobitela";
            // 
            // txtMobitel
            // 
            this.txtMobitel.Location = new System.Drawing.Point(160, 250);
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.Size = new System.Drawing.Size(228, 22);
            this.txtMobitel.TabIndex = 60;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresa.Location = new System.Drawing.Point(39, 222);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(53, 17);
            this.lblAdresa.TabIndex = 59;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(160, 217);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(228, 22);
            this.txtAdresa.TabIndex = 58;
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.BackColor = System.Drawing.Color.Transparent;
            this.lblOIB.Location = new System.Drawing.Point(39, 39);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(31, 17);
            this.lblOIB.TabIndex = 57;
            this.lblOIB.Text = "OIB";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(160, 36);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(228, 22);
            this.txtOIB.TabIndex = 56;
            this.txtOIB.TextChanged += new System.EventHandler(this.txtOIB_TextChanged);
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.BackColor = System.Drawing.Color.Black;
            this.btnRegistriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistriraj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistriraj.Location = new System.Drawing.Point(160, 413);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(228, 31);
            this.btnRegistriraj.TabIndex = 55;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = false;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // cmbTipKorisnika
            // 
            this.cmbTipKorisnika.DataSource = this.tipKorisnikaBindingSource;
            this.cmbTipKorisnika.DisplayMember = "Naziv";
            this.cmbTipKorisnika.FormattingEnabled = true;
            this.cmbTipKorisnika.Location = new System.Drawing.Point(160, 375);
            this.cmbTipKorisnika.Name = "cmbTipKorisnika";
            this.cmbTipKorisnika.Size = new System.Drawing.Size(228, 24);
            this.cmbTipKorisnika.TabIndex = 54;
            this.cmbTipKorisnika.ValueMember = "TipID";
            // 
            // tipKorisnikaBindingSource
            // 
            this.tipKorisnikaBindingSource.DataSource = typeof(Rent_a_Car.TipKorisnika);
            // 
            // lblTipKorisnika
            // 
            this.lblTipKorisnika.AutoSize = true;
            this.lblTipKorisnika.BackColor = System.Drawing.Color.Transparent;
            this.lblTipKorisnika.Location = new System.Drawing.Point(39, 382);
            this.lblTipKorisnika.Name = "lblTipKorisnika";
            this.lblTipKorisnika.Size = new System.Drawing.Size(88, 17);
            this.lblTipKorisnika.TabIndex = 53;
            this.lblTipKorisnika.Text = "Tip korisnika";
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.Location = new System.Drawing.Point(160, 189);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(228, 22);
            this.dtpDatumRodenja.TabIndex = 52;
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.BackColor = System.Drawing.Color.Transparent;
            this.lblDatumRodenja.Location = new System.Drawing.Point(39, 189);
            this.lblDatumRodenja.Name = "lblDatumRodenja";
            this.lblDatumRodenja.Size = new System.Drawing.Size(101, 17);
            this.lblDatumRodenja.TabIndex = 51;
            this.lblDatumRodenja.Text = "Datum rodenja";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.BackColor = System.Drawing.Color.Transparent;
            this.lblIBAN.Location = new System.Drawing.Point(39, 346);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(39, 17);
            this.lblIBAN.TabIndex = 50;
            this.lblIBAN.Text = "IBAN";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Location = new System.Drawing.Point(39, 157);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(57, 17);
            this.lblLozinka.TabIndex = 49;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(39, 125);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.lblKorisnickoIme.TabIndex = 48;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.Location = new System.Drawing.Point(39, 95);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 47;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Location = new System.Drawing.Point(39, 67);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 46;
            this.lblIme.Text = "Ime";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(160, 341);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(228, 22);
            this.txtIBAN.TabIndex = 45;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(160, 157);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(228, 22);
            this.txtLozinka.TabIndex = 44;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(160, 125);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(228, 22);
            this.txtKorisnickoIme.TabIndex = 43;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(160, 92);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(228, 22);
            this.txtPrezime.TabIndex = 42;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(160, 64);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(228, 22);
            this.txtIme.TabIndex = 41;
            // 
            // grpRegistracija
            // 
            this.grpRegistracija.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpRegistracija.BackgroundImage")));
            this.grpRegistracija.Controls.Add(this.lblOIB);
            this.grpRegistracija.Controls.Add(this.lblMail);
            this.grpRegistracija.Controls.Add(this.txtIme);
            this.grpRegistracija.Controls.Add(this.txtMail);
            this.grpRegistracija.Controls.Add(this.txtPrezime);
            this.grpRegistracija.Controls.Add(this.lblTelefon);
            this.grpRegistracija.Controls.Add(this.txtKorisnickoIme);
            this.grpRegistracija.Controls.Add(this.txtTelefon);
            this.grpRegistracija.Controls.Add(this.txtLozinka);
            this.grpRegistracija.Controls.Add(this.lblMobitel);
            this.grpRegistracija.Controls.Add(this.txtIBAN);
            this.grpRegistracija.Controls.Add(this.txtMobitel);
            this.grpRegistracija.Controls.Add(this.lblIme);
            this.grpRegistracija.Controls.Add(this.lblAdresa);
            this.grpRegistracija.Controls.Add(this.lblPrezime);
            this.grpRegistracija.Controls.Add(this.txtAdresa);
            this.grpRegistracija.Controls.Add(this.lblKorisnickoIme);
            this.grpRegistracija.Controls.Add(this.lblLozinka);
            this.grpRegistracija.Controls.Add(this.txtOIB);
            this.grpRegistracija.Controls.Add(this.lblIBAN);
            this.grpRegistracija.Controls.Add(this.btnRegistriraj);
            this.grpRegistracija.Controls.Add(this.lblDatumRodenja);
            this.grpRegistracija.Controls.Add(this.cmbTipKorisnika);
            this.grpRegistracija.Controls.Add(this.dtpDatumRodenja);
            this.grpRegistracija.Controls.Add(this.lblTipKorisnika);
            this.grpRegistracija.Location = new System.Drawing.Point(160, 12);
            this.grpRegistracija.Name = "grpRegistracija";
            this.grpRegistracija.Size = new System.Drawing.Size(477, 455);
            this.grpRegistracija.TabIndex = 66;
            this.grpRegistracija.TabStop = false;
            this.grpRegistracija.Text = "Registracija";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.Black;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(112, 32);
            this.btnNatrag.TabIndex = 67;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 496);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grpRegistracija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistracija";
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipKorisnikaBindingSource)).EndInit();
            this.grpRegistracija.ResumeLayout(false);
            this.grpRegistracija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblMobitel;
        private System.Windows.Forms.TextBox txtMobitel;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.ComboBox cmbTipKorisnika;
        private System.Windows.Forms.BindingSource tipKorisnikaBindingSource;
        private System.Windows.Forms.Label lblTipKorisnika;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.Label lblDatumRodenja;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox grpRegistracija;
        private System.Windows.Forms.Button btnNatrag;
    }
}