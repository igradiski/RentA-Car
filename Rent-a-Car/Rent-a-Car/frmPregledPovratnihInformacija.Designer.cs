namespace Rent_a_Car
{
    partial class PregledFeedbackova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledFeedbackova));
            this.dgvPovratneInformacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOcjenaAuta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajPovratnu = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.txtOcjenaUkupna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rxtNajbolji = new System.Windows.Forms.RichTextBox();
            this.rxtNajgori = new System.Windows.Forms.RichTextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblNajbolji = new System.Windows.Forms.Label();
            this.lblNajgori = new System.Windows.Forms.Label();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretraziPoNazivu = new System.Windows.Forms.TextBox();
            this.lblNajprofitabilnije = new System.Windows.Forms.Label();
            this.lblNajNeisplativijeVozilo = new System.Windows.Forms.Label();
            this.txtProfitMaxBroj = new System.Windows.Forms.TextBox();
            this.txtProfitMaxIme = new System.Windows.Forms.TextBox();
            this.txtMinProfitBroj = new System.Windows.Forms.TextBox();
            this.txtMinProfitIme = new System.Windows.Forms.TextBox();
            this.lblPoRegistraciji = new System.Windows.Forms.Label();
            this.txtPoRegistraciji = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovratneInformacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPovratneInformacije
            // 
            this.dgvPovratneInformacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovratneInformacije.Location = new System.Drawing.Point(331, 49);
            this.dgvPovratneInformacije.MultiSelect = false;
            this.dgvPovratneInformacije.Name = "dgvPovratneInformacije";
            this.dgvPovratneInformacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPovratneInformacije.Size = new System.Drawing.Size(805, 209);
            this.dgvPovratneInformacije.TabIndex = 0;
            this.dgvPovratneInformacije.SelectionChanged += new System.EventHandler(this.dgvPovratneInformacije_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vozilo:";
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(180, 15);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(150, 28);
            this.cmbVozilo.TabIndex = 2;
            this.cmbVozilo.SelectedIndexChanged += new System.EventHandler(this.cmbVozilo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjecna ocjena:";
            // 
            // txtOcjenaAuta
            // 
            this.txtOcjenaAuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOcjenaAuta.Location = new System.Drawing.Point(230, 162);
            this.txtOcjenaAuta.Name = "txtOcjenaAuta";
            this.txtOcjenaAuta.Size = new System.Drawing.Size(100, 26);
            this.txtOcjenaAuta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(48, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Komentar:";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(51, 306);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(246, 169);
            this.txtOpis.TabIndex = 6;
            // 
            // btnDodajPovratnu
            // 
            this.btnDodajPovratnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPovratnu.Location = new System.Drawing.Point(1009, 261);
            this.btnDodajPovratnu.Name = "btnDodajPovratnu";
            this.btnDodajPovratnu.Size = new System.Drawing.Size(127, 62);
            this.btnDodajPovratnu.TabIndex = 8;
            this.btnDodajPovratnu.Text = "Dodaj povratnu informaciju";
            this.btnDodajPovratnu.UseVisualStyleBackColor = true;
            this.btnDodajPovratnu.Click += new System.EventHandler(this.btnDodajPovratnu_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisi.Location = new System.Drawing.Point(331, 261);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(127, 62);
            this.btnBrisi.TabIndex = 7;
            this.btnBrisi.Text = "Brisanje Feedbacka";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOcjenaUkupna
            // 
            this.txtOcjenaUkupna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOcjenaUkupna.Location = new System.Drawing.Point(986, 358);
            this.txtOcjenaUkupna.Name = "txtOcjenaUkupna";
            this.txtOcjenaUkupna.Size = new System.Drawing.Size(100, 26);
            this.txtOcjenaUkupna.TabIndex = 10;
            this.txtOcjenaUkupna.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(785, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prosjecna ocjena:";
            // 
            // rxtNajbolji
            // 
            this.rxtNajbolji.Location = new System.Drawing.Point(51, 501);
            this.rxtNajbolji.Name = "rxtNajbolji";
            this.rxtNajbolji.Size = new System.Drawing.Size(273, 144);
            this.rxtNajbolji.TabIndex = 11;
            this.rxtNajbolji.Text = "";
            // 
            // rxtNajgori
            // 
            this.rxtNajgori.Location = new System.Drawing.Point(445, 501);
            this.rxtNajgori.Name = "rxtNajgori";
            this.rxtNajgori.Size = new System.Drawing.Size(273, 144);
            this.rxtNajgori.TabIndex = 12;
            this.rxtNajgori.Text = "";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.Color.Red;
            this.lblNaziv.Location = new System.Drawing.Point(336, 21);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(74, 24);
            this.lblNaziv.TabIndex = 13;
            this.lblNaziv.Text = "Vozilo:";
            // 
            // lblNajbolji
            // 
            this.lblNajbolji.AutoSize = true;
            this.lblNajbolji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNajbolji.Location = new System.Drawing.Point(48, 478);
            this.lblNajbolji.Name = "lblNajbolji";
            this.lblNajbolji.Size = new System.Drawing.Size(112, 20);
            this.lblNajbolji.TabIndex = 14;
            this.lblNajbolji.Text = "Najbolja vozila:";
            // 
            // lblNajgori
            // 
            this.lblNajgori.AutoSize = true;
            this.lblNajgori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNajgori.Location = new System.Drawing.Point(441, 467);
            this.lblNajgori.Name = "lblNajgori";
            this.lblNajgori.Size = new System.Drawing.Size(111, 20);
            this.lblNajgori.TabIndex = 15;
            this.lblNajgori.Text = "Najgora vozila:";
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazi.Location = new System.Drawing.Point(48, 63);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(138, 20);
            this.lblPretrazi.TabIndex = 17;
            this.lblPretrazi.Text = "Pretrazi po nazivu:";
            // 
            // txtPretraziPoNazivu
            // 
            this.txtPretraziPoNazivu.Location = new System.Drawing.Point(230, 63);
            this.txtPretraziPoNazivu.Name = "txtPretraziPoNazivu";
            this.txtPretraziPoNazivu.Size = new System.Drawing.Size(100, 20);
            this.txtPretraziPoNazivu.TabIndex = 18;
            this.txtPretraziPoNazivu.TextChanged += new System.EventHandler(this.txtPretraziPoNazivu_TextChanged);
            // 
            // lblNajprofitabilnije
            // 
            this.lblNajprofitabilnije.AutoSize = true;
            this.lblNajprofitabilnije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNajprofitabilnije.Location = new System.Drawing.Point(785, 467);
            this.lblNajprofitabilnije.Name = "lblNajprofitabilnije";
            this.lblNajprofitabilnije.Size = new System.Drawing.Size(134, 20);
            this.lblNajprofitabilnije.TabIndex = 19;
            this.lblNajprofitabilnije.Text = "Najvise zaradeno:";
            // 
            // lblNajNeisplativijeVozilo
            // 
            this.lblNajNeisplativijeVozilo.AutoSize = true;
            this.lblNajNeisplativijeVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNajNeisplativijeVozilo.Location = new System.Drawing.Point(785, 540);
            this.lblNajNeisplativijeVozilo.Name = "lblNajNeisplativijeVozilo";
            this.lblNajNeisplativijeVozilo.Size = new System.Drawing.Size(150, 20);
            this.lblNajNeisplativijeVozilo.TabIndex = 20;
            this.lblNajNeisplativijeVozilo.Text = "Najmanje zaradeno:";
            // 
            // txtProfitMaxBroj
            // 
            this.txtProfitMaxBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProfitMaxBroj.Location = new System.Drawing.Point(986, 464);
            this.txtProfitMaxBroj.Name = "txtProfitMaxBroj";
            this.txtProfitMaxBroj.Size = new System.Drawing.Size(100, 26);
            this.txtProfitMaxBroj.TabIndex = 21;
            this.txtProfitMaxBroj.Text = "0";
            // 
            // txtProfitMaxIme
            // 
            this.txtProfitMaxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProfitMaxIme.Location = new System.Drawing.Point(1131, 464);
            this.txtProfitMaxIme.Name = "txtProfitMaxIme";
            this.txtProfitMaxIme.Size = new System.Drawing.Size(148, 26);
            this.txtProfitMaxIme.TabIndex = 22;
            // 
            // txtMinProfitBroj
            // 
            this.txtMinProfitBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMinProfitBroj.Location = new System.Drawing.Point(986, 537);
            this.txtMinProfitBroj.Name = "txtMinProfitBroj";
            this.txtMinProfitBroj.Size = new System.Drawing.Size(100, 26);
            this.txtMinProfitBroj.TabIndex = 23;
            this.txtMinProfitBroj.Text = "50000";
            // 
            // txtMinProfitIme
            // 
            this.txtMinProfitIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMinProfitIme.Location = new System.Drawing.Point(1131, 537);
            this.txtMinProfitIme.Name = "txtMinProfitIme";
            this.txtMinProfitIme.Size = new System.Drawing.Size(148, 26);
            this.txtMinProfitIme.TabIndex = 24;
            // 
            // lblPoRegistraciji
            // 
            this.lblPoRegistraciji.AutoSize = true;
            this.lblPoRegistraciji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoRegistraciji.Location = new System.Drawing.Point(47, 108);
            this.lblPoRegistraciji.Name = "lblPoRegistraciji";
            this.lblPoRegistraciji.Size = new System.Drawing.Size(163, 20);
            this.lblPoRegistraciji.TabIndex = 25;
            this.lblPoRegistraciji.Text = "Pretrazi po registraciji:";
            // 
            // txtPoRegistraciji
            // 
            this.txtPoRegistraciji.Location = new System.Drawing.Point(230, 108);
            this.txtPoRegistraciji.Name = "txtPoRegistraciji";
            this.txtPoRegistraciji.Size = new System.Drawing.Size(100, 20);
            this.txtPoRegistraciji.TabIndex = 26;
            this.txtPoRegistraciji.TextChanged += new System.EventHandler(this.txtPoRegistraciji_TextChanged);
            // 
            // PregledFeedbackova
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1358, 657);
            this.Controls.Add(this.txtPoRegistraciji);
            this.Controls.Add(this.lblPoRegistraciji);
            this.Controls.Add(this.txtMinProfitIme);
            this.Controls.Add(this.txtMinProfitBroj);
            this.Controls.Add(this.txtProfitMaxIme);
            this.Controls.Add(this.txtProfitMaxBroj);
            this.Controls.Add(this.lblNajNeisplativijeVozilo);
            this.Controls.Add(this.lblNajprofitabilnije);
            this.Controls.Add(this.txtPretraziPoNazivu);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.lblNajgori);
            this.Controls.Add(this.lblNajbolji);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.rxtNajgori);
            this.Controls.Add(this.rxtNajbolji);
            this.Controls.Add(this.txtOcjenaUkupna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajPovratnu);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOcjenaAuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPovratneInformacije);
            this.Name = "PregledFeedbackova";
            this.Text = "PregledFeedbackova";
            this.Load += new System.EventHandler(this.PregledFeedbackova_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PregledFeedbackova_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovratneInformacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPovratneInformacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOcjenaAuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajPovratnu;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.TextBox txtOcjenaUkupna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rxtNajbolji;
        private System.Windows.Forms.RichTextBox rxtNajgori;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblNajbolji;
        private System.Windows.Forms.Label lblNajgori;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtPretraziPoNazivu;
        private System.Windows.Forms.Label lblNajprofitabilnije;
        private System.Windows.Forms.Label lblNajNeisplativijeVozilo;
        private System.Windows.Forms.TextBox txtProfitMaxBroj;
        private System.Windows.Forms.TextBox txtProfitMaxIme;
        private System.Windows.Forms.TextBox txtMinProfitBroj;
        private System.Windows.Forms.TextBox txtMinProfitIme;
        private System.Windows.Forms.Label lblPoRegistraciji;
        private System.Windows.Forms.TextBox txtPoRegistraciji;
    }
}