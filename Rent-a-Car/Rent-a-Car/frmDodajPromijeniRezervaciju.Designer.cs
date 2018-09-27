namespace Rent_a_Car
{
    partial class frmDodajPromijeniRezervaciju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajPromijeniRezervaciju));
            this.grpPodaciOkorisniku = new System.Windows.Forms.GroupBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.lblOIB = new System.Windows.Forms.Label();
            this.grpOdabirTerminaIVozila = new System.Windows.Forms.GroupBox();
            this.dtpDatumIVrijemeKraja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumIVrijemePocetka = new System.Windows.Forms.DateTimePicker();
            this.btnPregledDostupnihVozila = new System.Windows.Forms.Button();
            this.lblDatumIVrijemeKraja = new System.Windows.Forms.Label();
            this.lblDatumIVrijemePocetka = new System.Windows.Forms.Label();
            this.grpPodaciOVozilu = new System.Windows.Forms.GroupBox();
            this.lblkW = new System.Windows.Forms.Label();
            this.txtSnagaMotora = new System.Windows.Forms.TextBox();
            this.lblSnagaMotora = new System.Windows.Forms.Label();
            this.txtBrojSjedala = new System.Windows.Forms.TextBox();
            this.lblBrojSjedala = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.grpIzracunCijene = new System.Windows.Forms.GroupBox();
            this.lblCijenaPoDanuKn = new System.Windows.Forms.Label();
            this.lblUkupnaCijenaKn = new System.Windows.Forms.Label();
            this.lblCijenaSPDVKn = new System.Windows.Forms.Label();
            this.lblPDVKn = new System.Windows.Forms.Label();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.lblPDV = new System.Windows.Forms.Label();
            this.txtCijenaSPDV = new System.Windows.Forms.TextBox();
            this.lblCijenaSPDV = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.txtCijenaPoDanu = new System.Windows.Forms.TextBox();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.lblBrojDana = new System.Windows.Forms.Label();
            this.lblCijenaPoDanu = new System.Windows.Forms.Label();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.grpNapomena = new System.Windows.Forms.GroupBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.grpPodaciOkorisniku.SuspendLayout();
            this.grpOdabirTerminaIVozila.SuspendLayout();
            this.grpPodaciOVozilu.SuspendLayout();
            this.grpIzracunCijene.SuspendLayout();
            this.grpNapomena.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPodaciOkorisniku
            // 
            this.grpPodaciOkorisniku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPodaciOkorisniku.BackgroundImage")));
            this.grpPodaciOkorisniku.Controls.Add(this.txtPrezime);
            this.grpPodaciOkorisniku.Controls.Add(this.lblPrezime);
            this.grpPodaciOkorisniku.Controls.Add(this.txtIme);
            this.grpPodaciOkorisniku.Controls.Add(this.lblIme);
            this.grpPodaciOkorisniku.Controls.Add(this.txtOIB);
            this.grpPodaciOkorisniku.Controls.Add(this.lblOIB);
            this.grpPodaciOkorisniku.Location = new System.Drawing.Point(257, 14);
            this.grpPodaciOkorisniku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPodaciOkorisniku.Name = "grpPodaciOkorisniku";
            this.grpPodaciOkorisniku.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPodaciOkorisniku.Size = new System.Drawing.Size(533, 123);
            this.grpPodaciOkorisniku.TabIndex = 9;
            this.grpPodaciOkorisniku.TabStop = false;
            this.grpPodaciOkorisniku.Text = "Podaci o korisniku";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Enabled = false;
            this.txtPrezime.Location = new System.Drawing.Point(101, 78);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(245, 22);
            this.txtPrezime.TabIndex = 5;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.Location = new System.Drawing.Point(5, 80);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(101, 49);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(245, 22);
            this.txtIme.TabIndex = 3;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Location = new System.Drawing.Point(5, 52);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            // 
            // txtOIB
            // 
            this.txtOIB.Enabled = false;
            this.txtOIB.Location = new System.Drawing.Point(101, 21);
            this.txtOIB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(245, 22);
            this.txtOIB.TabIndex = 1;
            this.txtOIB.TextChanged += new System.EventHandler(this.txtOIB_TextChanged);
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.BackColor = System.Drawing.Color.Transparent;
            this.lblOIB.Location = new System.Drawing.Point(5, 25);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(35, 17);
            this.lblOIB.TabIndex = 0;
            this.lblOIB.Text = "OIB:";
            // 
            // grpOdabirTerminaIVozila
            // 
            this.grpOdabirTerminaIVozila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpOdabirTerminaIVozila.BackgroundImage")));
            this.grpOdabirTerminaIVozila.Controls.Add(this.dtpDatumIVrijemeKraja);
            this.grpOdabirTerminaIVozila.Controls.Add(this.dtpDatumIVrijemePocetka);
            this.grpOdabirTerminaIVozila.Controls.Add(this.btnPregledDostupnihVozila);
            this.grpOdabirTerminaIVozila.Controls.Add(this.lblDatumIVrijemeKraja);
            this.grpOdabirTerminaIVozila.Controls.Add(this.lblDatumIVrijemePocetka);
            this.grpOdabirTerminaIVozila.Location = new System.Drawing.Point(257, 142);
            this.grpOdabirTerminaIVozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOdabirTerminaIVozila.Name = "grpOdabirTerminaIVozila";
            this.grpOdabirTerminaIVozila.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOdabirTerminaIVozila.Size = new System.Drawing.Size(533, 128);
            this.grpOdabirTerminaIVozila.TabIndex = 10;
            this.grpOdabirTerminaIVozila.TabStop = false;
            this.grpOdabirTerminaIVozila.Text = "Odabir termina i vozila";
            // 
            // dtpDatumIVrijemeKraja
            // 
            this.dtpDatumIVrijemeKraja.Location = new System.Drawing.Point(176, 49);
            this.dtpDatumIVrijemeKraja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumIVrijemeKraja.Name = "dtpDatumIVrijemeKraja";
            this.dtpDatumIVrijemeKraja.Size = new System.Drawing.Size(245, 22);
            this.dtpDatumIVrijemeKraja.TabIndex = 6;
            this.dtpDatumIVrijemeKraja.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDatumIVrijemeKraja.ValueChanged += new System.EventHandler(this.dtpDatumIVrijemeKraja_ValueChanged);
            // 
            // dtpDatumIVrijemePocetka
            // 
            this.dtpDatumIVrijemePocetka.Location = new System.Drawing.Point(176, 17);
            this.dtpDatumIVrijemePocetka.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumIVrijemePocetka.Name = "dtpDatumIVrijemePocetka";
            this.dtpDatumIVrijemePocetka.Size = new System.Drawing.Size(245, 22);
            this.dtpDatumIVrijemePocetka.TabIndex = 5;
            this.dtpDatumIVrijemePocetka.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDatumIVrijemePocetka.ValueChanged += new System.EventHandler(this.dtpDatumIVrijemePocetka_ValueChanged);
            // 
            // btnPregledDostupnihVozila
            // 
            this.btnPregledDostupnihVozila.Location = new System.Drawing.Point(176, 81);
            this.btnPregledDostupnihVozila.Margin = new System.Windows.Forms.Padding(4);
            this.btnPregledDostupnihVozila.Name = "btnPregledDostupnihVozila";
            this.btnPregledDostupnihVozila.Size = new System.Drawing.Size(247, 28);
            this.btnPregledDostupnihVozila.TabIndex = 4;
            this.btnPregledDostupnihVozila.Text = "Pregled dostupnih vozila";
            this.btnPregledDostupnihVozila.UseVisualStyleBackColor = true;
            this.btnPregledDostupnihVozila.Click += new System.EventHandler(this.btnPregledDostupnihVozila_Click);
            // 
            // lblDatumIVrijemeKraja
            // 
            this.lblDatumIVrijemeKraja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumIVrijemeKraja.AutoSize = true;
            this.lblDatumIVrijemeKraja.BackColor = System.Drawing.Color.Transparent;
            this.lblDatumIVrijemeKraja.Location = new System.Drawing.Point(5, 54);
            this.lblDatumIVrijemeKraja.Name = "lblDatumIVrijemeKraja";
            this.lblDatumIVrijemeKraja.Size = new System.Drawing.Size(144, 17);
            this.lblDatumIVrijemeKraja.TabIndex = 2;
            this.lblDatumIVrijemeKraja.Text = "Datum i vrijeme kraja:";
            // 
            // lblDatumIVrijemePocetka
            // 
            this.lblDatumIVrijemePocetka.AutoSize = true;
            this.lblDatumIVrijemePocetka.BackColor = System.Drawing.Color.Transparent;
            this.lblDatumIVrijemePocetka.Location = new System.Drawing.Point(5, 25);
            this.lblDatumIVrijemePocetka.Name = "lblDatumIVrijemePocetka";
            this.lblDatumIVrijemePocetka.Size = new System.Drawing.Size(163, 17);
            this.lblDatumIVrijemePocetka.TabIndex = 0;
            this.lblDatumIVrijemePocetka.Text = "Datum i vrijeme početka:";
            // 
            // grpPodaciOVozilu
            // 
            this.grpPodaciOVozilu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPodaciOVozilu.BackgroundImage")));
            this.grpPodaciOVozilu.Controls.Add(this.lblkW);
            this.grpPodaciOVozilu.Controls.Add(this.txtSnagaMotora);
            this.grpPodaciOVozilu.Controls.Add(this.lblSnagaMotora);
            this.grpPodaciOVozilu.Controls.Add(this.txtBrojSjedala);
            this.grpPodaciOVozilu.Controls.Add(this.lblBrojSjedala);
            this.grpPodaciOVozilu.Controls.Add(this.txtTip);
            this.grpPodaciOVozilu.Controls.Add(this.lblTip);
            this.grpPodaciOVozilu.Controls.Add(this.txtModel);
            this.grpPodaciOVozilu.Controls.Add(this.lblModel);
            this.grpPodaciOVozilu.Controls.Add(this.txtRegistracija);
            this.grpPodaciOVozilu.Controls.Add(this.lblRegistracija);
            this.grpPodaciOVozilu.Location = new System.Drawing.Point(257, 274);
            this.grpPodaciOVozilu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPodaciOVozilu.Name = "grpPodaciOVozilu";
            this.grpPodaciOVozilu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPodaciOVozilu.Size = new System.Drawing.Size(533, 172);
            this.grpPodaciOVozilu.TabIndex = 11;
            this.grpPodaciOVozilu.TabStop = false;
            this.grpPodaciOVozilu.Text = "Podaci o vozilu";
            // 
            // lblkW
            // 
            this.lblkW.AutoSize = true;
            this.lblkW.Location = new System.Drawing.Point(369, 110);
            this.lblkW.Name = "lblkW";
            this.lblkW.Size = new System.Drawing.Size(28, 17);
            this.lblkW.TabIndex = 16;
            this.lblkW.Text = "kW";
            // 
            // txtSnagaMotora
            // 
            this.txtSnagaMotora.Enabled = false;
            this.txtSnagaMotora.Location = new System.Drawing.Point(117, 107);
            this.txtSnagaMotora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSnagaMotora.Name = "txtSnagaMotora";
            this.txtSnagaMotora.Size = new System.Drawing.Size(245, 22);
            this.txtSnagaMotora.TabIndex = 15;
            // 
            // lblSnagaMotora
            // 
            this.lblSnagaMotora.AutoSize = true;
            this.lblSnagaMotora.BackColor = System.Drawing.Color.Transparent;
            this.lblSnagaMotora.Location = new System.Drawing.Point(5, 110);
            this.lblSnagaMotora.Name = "lblSnagaMotora";
            this.lblSnagaMotora.Size = new System.Drawing.Size(101, 17);
            this.lblSnagaMotora.TabIndex = 14;
            this.lblSnagaMotora.Text = "Snaga motora:";
            // 
            // txtBrojSjedala
            // 
            this.txtBrojSjedala.Enabled = false;
            this.txtBrojSjedala.Location = new System.Drawing.Point(117, 135);
            this.txtBrojSjedala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojSjedala.Name = "txtBrojSjedala";
            this.txtBrojSjedala.Size = new System.Drawing.Size(245, 22);
            this.txtBrojSjedala.TabIndex = 13;
            // 
            // lblBrojSjedala
            // 
            this.lblBrojSjedala.AutoSize = true;
            this.lblBrojSjedala.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojSjedala.Location = new System.Drawing.Point(5, 139);
            this.lblBrojSjedala.Name = "lblBrojSjedala";
            this.lblBrojSjedala.Size = new System.Drawing.Size(86, 17);
            this.lblBrojSjedala.TabIndex = 12;
            this.lblBrojSjedala.Text = "Broj sjedala:";
            // 
            // txtTip
            // 
            this.txtTip.Enabled = false;
            this.txtTip.Location = new System.Drawing.Point(117, 78);
            this.txtTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(245, 22);
            this.txtTip.TabIndex = 11;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Location = new System.Drawing.Point(5, 80);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(32, 17);
            this.lblTip.TabIndex = 10;
            this.lblTip.Text = "Tip:";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(117, 49);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(245, 22);
            this.txtModel.TabIndex = 9;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Location = new System.Drawing.Point(5, 52);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Enabled = false;
            this.txtRegistracija.Location = new System.Drawing.Point(117, 22);
            this.txtRegistracija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(245, 22);
            this.txtRegistracija.TabIndex = 7;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistracija.Location = new System.Drawing.Point(5, 25);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(86, 17);
            this.lblRegistracija.TabIndex = 6;
            this.lblRegistracija.Text = "Registracija:";
            // 
            // grpIzracunCijene
            // 
            this.grpIzracunCijene.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpIzracunCijene.BackgroundImage")));
            this.grpIzracunCijene.Controls.Add(this.lblCijenaPoDanuKn);
            this.grpIzracunCijene.Controls.Add(this.lblUkupnaCijenaKn);
            this.grpIzracunCijene.Controls.Add(this.lblCijenaSPDVKn);
            this.grpIzracunCijene.Controls.Add(this.lblPDVKn);
            this.grpIzracunCijene.Controls.Add(this.txtPDV);
            this.grpIzracunCijene.Controls.Add(this.lblPDV);
            this.grpIzracunCijene.Controls.Add(this.txtCijenaSPDV);
            this.grpIzracunCijene.Controls.Add(this.lblCijenaSPDV);
            this.grpIzracunCijene.Controls.Add(this.txtUkupnaCijena);
            this.grpIzracunCijene.Controls.Add(this.lblUkupnaCijena);
            this.grpIzracunCijene.Controls.Add(this.txtCijenaPoDanu);
            this.grpIzracunCijene.Controls.Add(this.txtBrojDana);
            this.grpIzracunCijene.Controls.Add(this.lblBrojDana);
            this.grpIzracunCijene.Controls.Add(this.lblCijenaPoDanu);
            this.grpIzracunCijene.Location = new System.Drawing.Point(257, 622);
            this.grpIzracunCijene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpIzracunCijene.Name = "grpIzracunCijene";
            this.grpIzracunCijene.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpIzracunCijene.Size = new System.Drawing.Size(533, 165);
            this.grpIzracunCijene.TabIndex = 18;
            this.grpIzracunCijene.TabStop = false;
            this.grpIzracunCijene.Text = "Izračun cijene";
            // 
            // lblCijenaPoDanuKn
            // 
            this.lblCijenaPoDanuKn.AutoSize = true;
            this.lblCijenaPoDanuKn.BackColor = System.Drawing.Color.Transparent;
            this.lblCijenaPoDanuKn.Location = new System.Drawing.Point(380, 22);
            this.lblCijenaPoDanuKn.Name = "lblCijenaPoDanuKn";
            this.lblCijenaPoDanuKn.Size = new System.Drawing.Size(23, 17);
            this.lblCijenaPoDanuKn.TabIndex = 34;
            this.lblCijenaPoDanuKn.Text = "kn";
            // 
            // lblUkupnaCijenaKn
            // 
            this.lblUkupnaCijenaKn.AutoSize = true;
            this.lblUkupnaCijenaKn.BackColor = System.Drawing.Color.Transparent;
            this.lblUkupnaCijenaKn.Location = new System.Drawing.Point(380, 74);
            this.lblUkupnaCijenaKn.Name = "lblUkupnaCijenaKn";
            this.lblUkupnaCijenaKn.Size = new System.Drawing.Size(23, 17);
            this.lblUkupnaCijenaKn.TabIndex = 33;
            this.lblUkupnaCijenaKn.Text = "kn";
            this.lblUkupnaCijenaKn.Visible = false;
            // 
            // lblCijenaSPDVKn
            // 
            this.lblCijenaSPDVKn.AutoSize = true;
            this.lblCijenaSPDVKn.BackColor = System.Drawing.Color.Transparent;
            this.lblCijenaSPDVKn.Location = new System.Drawing.Point(380, 126);
            this.lblCijenaSPDVKn.Name = "lblCijenaSPDVKn";
            this.lblCijenaSPDVKn.Size = new System.Drawing.Size(23, 17);
            this.lblCijenaSPDVKn.TabIndex = 32;
            this.lblCijenaSPDVKn.Text = "kn";
            // 
            // lblPDVKn
            // 
            this.lblPDVKn.AutoSize = true;
            this.lblPDVKn.BackColor = System.Drawing.Color.Transparent;
            this.lblPDVKn.Location = new System.Drawing.Point(380, 100);
            this.lblPDVKn.Name = "lblPDVKn";
            this.lblPDVKn.Size = new System.Drawing.Size(23, 17);
            this.lblPDVKn.TabIndex = 31;
            this.lblPDVKn.Text = "kn";
            // 
            // txtPDV
            // 
            this.txtPDV.Enabled = false;
            this.txtPDV.Location = new System.Drawing.Point(129, 97);
            this.txtPDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(245, 22);
            this.txtPDV.TabIndex = 30;
            // 
            // lblPDV
            // 
            this.lblPDV.AutoSize = true;
            this.lblPDV.BackColor = System.Drawing.Color.Transparent;
            this.lblPDV.Location = new System.Drawing.Point(5, 100);
            this.lblPDV.Name = "lblPDV";
            this.lblPDV.Size = new System.Drawing.Size(40, 17);
            this.lblPDV.TabIndex = 29;
            this.lblPDV.Text = "PDV:";
            // 
            // txtCijenaSPDV
            // 
            this.txtCijenaSPDV.Enabled = false;
            this.txtCijenaSPDV.Location = new System.Drawing.Point(129, 123);
            this.txtCijenaSPDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCijenaSPDV.Name = "txtCijenaSPDV";
            this.txtCijenaSPDV.Size = new System.Drawing.Size(245, 22);
            this.txtCijenaSPDV.TabIndex = 28;
            // 
            // lblCijenaSPDV
            // 
            this.lblCijenaSPDV.AutoSize = true;
            this.lblCijenaSPDV.BackColor = System.Drawing.Color.Transparent;
            this.lblCijenaSPDV.Location = new System.Drawing.Point(5, 126);
            this.lblCijenaSPDV.Name = "lblCijenaSPDV";
            this.lblCijenaSPDV.Size = new System.Drawing.Size(118, 17);
            this.lblCijenaSPDV.TabIndex = 27;
            this.lblCijenaSPDV.Text = "Cijena s PDV-om:";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Enabled = false;
            this.txtUkupnaCijena.Location = new System.Drawing.Point(129, 71);
            this.txtUkupnaCijena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(245, 22);
            this.txtUkupnaCijena.TabIndex = 26;
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.BackColor = System.Drawing.Color.Transparent;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(5, 74);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(102, 17);
            this.lblUkupnaCijena.TabIndex = 25;
            this.lblUkupnaCijena.Text = "Ukupna cijena:";
            // 
            // txtCijenaPoDanu
            // 
            this.txtCijenaPoDanu.Enabled = false;
            this.txtCijenaPoDanu.Location = new System.Drawing.Point(129, 18);
            this.txtCijenaPoDanu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCijenaPoDanu.Name = "txtCijenaPoDanu";
            this.txtCijenaPoDanu.Size = new System.Drawing.Size(245, 22);
            this.txtCijenaPoDanu.TabIndex = 22;
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Enabled = false;
            this.txtBrojDana.Location = new System.Drawing.Point(129, 46);
            this.txtBrojDana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(245, 22);
            this.txtBrojDana.TabIndex = 24;
            // 
            // lblBrojDana
            // 
            this.lblBrojDana.AutoSize = true;
            this.lblBrojDana.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojDana.Location = new System.Drawing.Point(5, 48);
            this.lblBrojDana.Name = "lblBrojDana";
            this.lblBrojDana.Size = new System.Drawing.Size(73, 17);
            this.lblBrojDana.TabIndex = 23;
            this.lblBrojDana.Text = "Broj dana:";
            // 
            // lblCijenaPoDanu
            // 
            this.lblCijenaPoDanu.AutoSize = true;
            this.lblCijenaPoDanu.BackColor = System.Drawing.Color.Transparent;
            this.lblCijenaPoDanu.Location = new System.Drawing.Point(5, 22);
            this.lblCijenaPoDanu.Name = "lblCijenaPoDanu";
            this.lblCijenaPoDanu.Size = new System.Drawing.Size(107, 17);
            this.lblCijenaPoDanu.TabIndex = 21;
            this.lblCijenaPoDanu.Text = "Cijena po danu:";
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.BackColor = System.Drawing.Color.Black;
            this.btnRezerviraj.FlatAppearance.BorderSize = 0;
            this.btnRezerviraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRezerviraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezerviraj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRezerviraj.Location = new System.Drawing.Point(392, 789);
            this.btnRezerviraj.Margin = new System.Windows.Forms.Padding(0);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(213, 86);
            this.btnRezerviraj.TabIndex = 19;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = false;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // grpNapomena
            // 
            this.grpNapomena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpNapomena.BackgroundImage")));
            this.grpNapomena.Controls.Add(this.lblNapomena);
            this.grpNapomena.Controls.Add(this.txtNapomena);
            this.grpNapomena.Location = new System.Drawing.Point(257, 452);
            this.grpNapomena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNapomena.Name = "grpNapomena";
            this.grpNapomena.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNapomena.Size = new System.Drawing.Size(533, 165);
            this.grpNapomena.TabIndex = 35;
            this.grpNapomena.TabStop = false;
            this.grpNapomena.Text = "Napomena";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNapomena.Location = new System.Drawing.Point(11, 25);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(81, 17);
            this.lblNapomena.TabIndex = 17;
            this.lblNapomena.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(101, 21);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNapomena.MaxLength = 255;
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(425, 138);
            this.txtNapomena.TabIndex = 17;
            // 
            // frmDodajPromijeniRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 1009);
            this.Controls.Add(this.grpNapomena);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.grpIzracunCijene);
            this.Controls.Add(this.grpPodaciOVozilu);
            this.Controls.Add(this.grpOdabirTerminaIVozila);
            this.Controls.Add(this.grpPodaciOkorisniku);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDodajPromijeniRezervaciju";
            this.Text = "Dodavanje ili promijena rezervacije";
            this.Load += new System.EventHandler(this.frmDodajRezervaciju_Load);
            this.grpPodaciOkorisniku.ResumeLayout(false);
            this.grpPodaciOkorisniku.PerformLayout();
            this.grpOdabirTerminaIVozila.ResumeLayout(false);
            this.grpOdabirTerminaIVozila.PerformLayout();
            this.grpPodaciOVozilu.ResumeLayout(false);
            this.grpPodaciOVozilu.PerformLayout();
            this.grpIzracunCijene.ResumeLayout(false);
            this.grpIzracunCijene.PerformLayout();
            this.grpNapomena.ResumeLayout(false);
            this.grpNapomena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPodaciOkorisniku;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.GroupBox grpOdabirTerminaIVozila;
        private System.Windows.Forms.DateTimePicker dtpDatumIVrijemeKraja;
        private System.Windows.Forms.DateTimePicker dtpDatumIVrijemePocetka;
        private System.Windows.Forms.Button btnPregledDostupnihVozila;
        private System.Windows.Forms.Label lblDatumIVrijemeKraja;
        private System.Windows.Forms.Label lblDatumIVrijemePocetka;
        private System.Windows.Forms.GroupBox grpPodaciOVozilu;
        private System.Windows.Forms.Label lblkW;
        private System.Windows.Forms.TextBox txtSnagaMotora;
        private System.Windows.Forms.Label lblSnagaMotora;
        private System.Windows.Forms.TextBox txtBrojSjedala;
        private System.Windows.Forms.Label lblBrojSjedala;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.GroupBox grpIzracunCijene;
        private System.Windows.Forms.Label lblCijenaPoDanuKn;
        private System.Windows.Forms.Label lblUkupnaCijenaKn;
        private System.Windows.Forms.Label lblCijenaSPDVKn;
        private System.Windows.Forms.Label lblPDVKn;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label lblPDV;
        private System.Windows.Forms.TextBox txtCijenaSPDV;
        private System.Windows.Forms.Label lblCijenaSPDV;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.TextBox txtCijenaPoDanu;
        private System.Windows.Forms.TextBox txtBrojDana;
        private System.Windows.Forms.Label lblBrojDana;
        private System.Windows.Forms.Label lblCijenaPoDanu;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.GroupBox grpNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
    }
}