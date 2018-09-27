namespace Rent_a_Car
{
    partial class frmDodajVozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajVozilo));
            this.grpVozilo = new System.Windows.Forms.GroupBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.lblCijenaPoDanu = new System.Windows.Forms.Label();
            this.txtCijenaPoDanu = new System.Windows.Forms.TextBox();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.lblTipMotora = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblDatumRegistracije = new System.Windows.Forms.Label();
            this.cmbTipMotora = new System.Windows.Forms.ComboBox();
            this.tipMotoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSnagaMotora = new System.Windows.Forms.Label();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.lblBrojSjedala = new System.Windows.Forms.Label();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatumRegistriranja = new System.Windows.Forms.DateTimePicker();
            this.txtKilometri = new System.Windows.Forms.TextBox();
            this.txtBrojSjedala = new System.Windows.Forms.TextBox();
            this.txtSnagaMotora = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.grpVozilo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipMotoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVozilo
            // 
            this.grpVozilo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpVozilo.BackgroundImage")));
            this.grpVozilo.Controls.Add(this.txtGodinaProizvodnje);
            this.grpVozilo.Controls.Add(this.lblCijenaPoDanu);
            this.grpVozilo.Controls.Add(this.txtCijenaPoDanu);
            this.grpVozilo.Controls.Add(this.btnDodajVozilo);
            this.grpVozilo.Controls.Add(this.lblTipMotora);
            this.grpVozilo.Controls.Add(this.lblKategorija);
            this.grpVozilo.Controls.Add(this.lblDatumRegistracije);
            this.grpVozilo.Controls.Add(this.cmbTipMotora);
            this.grpVozilo.Controls.Add(this.lblSnagaMotora);
            this.grpVozilo.Controls.Add(this.lblKilometri);
            this.grpVozilo.Controls.Add(this.lblBrojSjedala);
            this.grpVozilo.Controls.Add(this.lblGodinaProizvodnje);
            this.grpVozilo.Controls.Add(this.lblNaziv);
            this.grpVozilo.Controls.Add(this.lblRegistracija);
            this.grpVozilo.Controls.Add(this.cmbKategorija);
            this.grpVozilo.Controls.Add(this.dtpDatumRegistriranja);
            this.grpVozilo.Controls.Add(this.txtKilometri);
            this.grpVozilo.Controls.Add(this.txtBrojSjedala);
            this.grpVozilo.Controls.Add(this.txtSnagaMotora);
            this.grpVozilo.Controls.Add(this.txtNaziv);
            this.grpVozilo.Controls.Add(this.txtRegistracija);
            this.grpVozilo.Location = new System.Drawing.Point(221, 22);
            this.grpVozilo.Name = "grpVozilo";
            this.grpVozilo.Size = new System.Drawing.Size(546, 470);
            this.grpVozilo.TabIndex = 3;
            this.grpVozilo.TabStop = false;
            this.grpVozilo.Text = "Dodaj vozilo";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(208, 115);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(206, 22);
            this.txtGodinaProizvodnje.TabIndex = 23;
            // 
            // lblCijenaPoDanu
            // 
            this.lblCijenaPoDanu.AutoSize = true;
            this.lblCijenaPoDanu.BackColor = System.Drawing.Color.Transparent;
            this.lblCijenaPoDanu.Location = new System.Drawing.Point(34, 392);
            this.lblCijenaPoDanu.Name = "lblCijenaPoDanu";
            this.lblCijenaPoDanu.Size = new System.Drawing.Size(103, 17);
            this.lblCijenaPoDanu.TabIndex = 22;
            this.lblCijenaPoDanu.Text = "Cijena po danu";
            // 
            // txtCijenaPoDanu
            // 
            this.txtCijenaPoDanu.Location = new System.Drawing.Point(208, 387);
            this.txtCijenaPoDanu.Name = "txtCijenaPoDanu";
            this.txtCijenaPoDanu.Size = new System.Drawing.Size(206, 22);
            this.txtCijenaPoDanu.TabIndex = 21;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.Black;
            this.btnDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozilo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodajVozilo.Location = new System.Drawing.Point(208, 429);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(206, 35);
            this.btnDodajVozilo.TabIndex = 20;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // lblTipMotora
            // 
            this.lblTipMotora.AutoSize = true;
            this.lblTipMotora.BackColor = System.Drawing.Color.Transparent;
            this.lblTipMotora.Location = new System.Drawing.Point(34, 353);
            this.lblTipMotora.Name = "lblTipMotora";
            this.lblTipMotora.Size = new System.Drawing.Size(76, 17);
            this.lblTipMotora.TabIndex = 19;
            this.lblTipMotora.Text = "Tip motora";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorija.Location = new System.Drawing.Point(34, 313);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(112, 17);
            this.lblKategorija.TabIndex = 17;
            this.lblKategorija.Text = "Kategorija vozila";
            // 
            // lblDatumRegistracije
            // 
            this.lblDatumRegistracije.AutoSize = true;
            this.lblDatumRegistracije.BackColor = System.Drawing.Color.Transparent;
            this.lblDatumRegistracije.Location = new System.Drawing.Point(34, 274);
            this.lblDatumRegistracije.Name = "lblDatumRegistracije";
            this.lblDatumRegistracije.Size = new System.Drawing.Size(122, 17);
            this.lblDatumRegistracije.TabIndex = 16;
            this.lblDatumRegistracije.Text = "Datum registracije";
            // 
            // cmbTipMotora
            // 
            this.cmbTipMotora.DataSource = this.tipMotoraBindingSource;
            this.cmbTipMotora.DisplayMember = "Naziv";
            this.cmbTipMotora.FormattingEnabled = true;
            this.cmbTipMotora.Location = new System.Drawing.Point(208, 346);
            this.cmbTipMotora.Name = "cmbTipMotora";
            this.cmbTipMotora.Size = new System.Drawing.Size(206, 24);
            this.cmbTipMotora.TabIndex = 15;
            this.cmbTipMotora.ValueMember = "TipMotoraID";
            // 
            // tipMotoraBindingSource
            // 
            this.tipMotoraBindingSource.DataSource = typeof(Rent_a_Car.TipMotora);
            // 
            // lblSnagaMotora
            // 
            this.lblSnagaMotora.AutoSize = true;
            this.lblSnagaMotora.BackColor = System.Drawing.Color.Transparent;
            this.lblSnagaMotora.Location = new System.Drawing.Point(34, 158);
            this.lblSnagaMotora.Name = "lblSnagaMotora";
            this.lblSnagaMotora.Size = new System.Drawing.Size(97, 17);
            this.lblSnagaMotora.TabIndex = 14;
            this.lblSnagaMotora.Text = "Snaga motora";
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.BackColor = System.Drawing.Color.Transparent;
            this.lblKilometri.Location = new System.Drawing.Point(34, 235);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(119, 17);
            this.lblKilometri.TabIndex = 13;
            this.lblKilometri.Text = "Prijeđeni kilometri";
            // 
            // lblBrojSjedala
            // 
            this.lblBrojSjedala.AutoSize = true;
            this.lblBrojSjedala.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojSjedala.Location = new System.Drawing.Point(35, 197);
            this.lblBrojSjedala.Name = "lblBrojSjedala";
            this.lblBrojSjedala.Size = new System.Drawing.Size(82, 17);
            this.lblBrojSjedala.TabIndex = 12;
            this.lblBrojSjedala.Text = "Broj sjedala";
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.BackColor = System.Drawing.Color.Transparent;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(34, 120);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(131, 17);
            this.lblGodinaProizvodnje.TabIndex = 11;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.BackColor = System.Drawing.Color.Transparent;
            this.lblNaziv.Location = new System.Drawing.Point(34, 83);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(83, 17);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv vozila";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistracija.Location = new System.Drawing.Point(34, 41);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(146, 17);
            this.lblRegistracija.TabIndex = 9;
            this.lblRegistracija.Text = "Registracijske oznake";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.DataSource = this.kategorijaBindingSource;
            this.cmbKategorija.DisplayMember = "Naziv";
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(208, 306);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(206, 24);
            this.cmbKategorija.TabIndex = 7;
            this.cmbKategorija.ValueMember = "KategorijaID";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = typeof(Rent_a_Car.Kategorija);
            // 
            // dtpDatumRegistriranja
            // 
            this.dtpDatumRegistriranja.Location = new System.Drawing.Point(208, 269);
            this.dtpDatumRegistriranja.Name = "dtpDatumRegistriranja";
            this.dtpDatumRegistriranja.Size = new System.Drawing.Size(206, 22);
            this.dtpDatumRegistriranja.TabIndex = 6;
            // 
            // txtKilometri
            // 
            this.txtKilometri.Location = new System.Drawing.Point(208, 230);
            this.txtKilometri.Name = "txtKilometri";
            this.txtKilometri.Size = new System.Drawing.Size(206, 22);
            this.txtKilometri.TabIndex = 5;
            // 
            // txtBrojSjedala
            // 
            this.txtBrojSjedala.Location = new System.Drawing.Point(208, 192);
            this.txtBrojSjedala.Name = "txtBrojSjedala";
            this.txtBrojSjedala.Size = new System.Drawing.Size(206, 22);
            this.txtBrojSjedala.TabIndex = 4;
            // 
            // txtSnagaMotora
            // 
            this.txtSnagaMotora.Location = new System.Drawing.Point(208, 153);
            this.txtSnagaMotora.Name = "txtSnagaMotora";
            this.txtSnagaMotora.Size = new System.Drawing.Size(206, 22);
            this.txtSnagaMotora.TabIndex = 3;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(208, 78);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(206, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(208, 38);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(206, 22);
            this.txtRegistracija.TabIndex = 0;
            this.txtRegistracija.Tag = "";
            this.txtRegistracija.TextChanged += new System.EventHandler(this.txtRegistracija_TextChanged);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.Black;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(26, 22);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(131, 32);
            this.btnNatrag.TabIndex = 4;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmDodajVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 515);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grpVozilo);
            this.Name = "frmDodajVozilo";
            this.Text = "Dodaj vozilo";
            this.Load += new System.EventHandler(this.frmDodajVozilo_Load);
            this.grpVozilo.ResumeLayout(false);
            this.grpVozilo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipMotoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVozilo;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.Label lblCijenaPoDanu;
        private System.Windows.Forms.TextBox txtCijenaPoDanu;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Label lblTipMotora;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblDatumRegistracije;
        private System.Windows.Forms.ComboBox cmbTipMotora;
        private System.Windows.Forms.Label lblSnagaMotora;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.Label lblBrojSjedala;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.DateTimePicker dtpDatumRegistriranja;
        private System.Windows.Forms.TextBox txtKilometri;
        private System.Windows.Forms.TextBox txtBrojSjedala;
        private System.Windows.Forms.TextBox txtSnagaMotora;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.BindingSource tipMotoraBindingSource;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.Button btnNatrag;
    }
}