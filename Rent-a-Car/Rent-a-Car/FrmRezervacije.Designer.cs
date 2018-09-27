namespace Rent_a_Car
{
    partial class frmRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacije));
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.rezervacijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKrajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeKorisnika = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrezimeKorisnika = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AutoGenerateColumns = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervacijaIDDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumRezervacijeDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumKrajaDataGridViewTextBoxColumn,
            this.voziloIDDataGridViewTextBoxColumn,
            this.korisnikIDDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.ImeKorisnika,
            this.PrezimeKorisnika});
            this.dgvRezervacije.DataSource = this.rezervacijaBindingSource;
            this.dgvRezervacije.Location = new System.Drawing.Point(15, 14);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(1065, 150);
            this.dgvRezervacije.TabIndex = 18;
            // 
            // rezervacijaIDDataGridViewTextBoxColumn
            // 
            this.rezervacijaIDDataGridViewTextBoxColumn.DataPropertyName = "RezervacijaID";
            this.rezervacijaIDDataGridViewTextBoxColumn.HeaderText = "Šifra rezervacije";
            this.rezervacijaIDDataGridViewTextBoxColumn.Name = "rezervacijaIDDataGridViewTextBoxColumn";
            this.rezervacijaIDDataGridViewTextBoxColumn.Width = 127;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 66;
            // 
            // datumRezervacijeDataGridViewTextBoxColumn
            // 
            this.datumRezervacijeDataGridViewTextBoxColumn.DataPropertyName = "DatumRezervacije";
            this.datumRezervacijeDataGridViewTextBoxColumn.HeaderText = "Datum rezervacije";
            this.datumRezervacijeDataGridViewTextBoxColumn.Name = "datumRezervacijeDataGridViewTextBoxColumn";
            this.datumRezervacijeDataGridViewTextBoxColumn.Width = 138;
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "Datum početka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            this.datumPocetkaDataGridViewTextBoxColumn.Width = 121;
            // 
            // datumKrajaDataGridViewTextBoxColumn
            // 
            this.datumKrajaDataGridViewTextBoxColumn.DataPropertyName = "DatumKraja";
            this.datumKrajaDataGridViewTextBoxColumn.HeaderText = "Datum kraja";
            this.datumKrajaDataGridViewTextBoxColumn.Name = "datumKrajaDataGridViewTextBoxColumn";
            this.datumKrajaDataGridViewTextBoxColumn.Width = 104;
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.DataSource = this.voziloBindingSource;
            this.voziloIDDataGridViewTextBoxColumn.DisplayMember = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            this.voziloIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.voziloIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.voziloIDDataGridViewTextBoxColumn.ValueMember = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(Rent_a_Car.Vozilo);
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            this.korisnikIDDataGridViewTextBoxColumn.Visible = false;
            this.korisnikIDDataGridViewTextBoxColumn.Width = 69;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            this.korisnikDataGridViewTextBoxColumn.Width = 69;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            this.voziloDataGridViewTextBoxColumn.Width = 60;
            // 
            // ImeKorisnika
            // 
            this.ImeKorisnika.DataPropertyName = "KorisnikID";
            this.ImeKorisnika.DataSource = this.korisnikBindingSource;
            this.ImeKorisnika.DisplayMember = "Ime";
            this.ImeKorisnika.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ImeKorisnika.HeaderText = "Ime";
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImeKorisnika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImeKorisnika.ValueMember = "KorisnikID";
            this.ImeKorisnika.Width = 59;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Rent_a_Car.Korisnik);
            // 
            // PrezimeKorisnika
            // 
            this.PrezimeKorisnika.DataPropertyName = "KorisnikID";
            this.PrezimeKorisnika.DataSource = this.korisnikBindingSource;
            this.PrezimeKorisnika.DisplayMember = "Prezime";
            this.PrezimeKorisnika.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PrezimeKorisnika.HeaderText = "Prezime";
            this.PrezimeKorisnika.Name = "PrezimeKorisnika";
            this.PrezimeKorisnika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrezimeKorisnika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrezimeKorisnika.ValueMember = "KorisnikID";
            this.PrezimeKorisnika.Width = 88;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(Rent_a_Car.Rezervacija);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.Black;
            this.btnOtkazi.FlatAppearance.BorderSize = 0;
            this.btnOtkazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOtkazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOtkazi.Location = new System.Drawing.Point(441, 166);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(0);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(213, 86);
            this.btnOtkazi.TabIndex = 20;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Visible = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.BackColor = System.Drawing.Color.Black;
            this.btnPromijeni.FlatAppearance.BorderSize = 0;
            this.btnPromijeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPromijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeni.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPromijeni.Location = new System.Drawing.Point(228, 166);
            this.btnPromijeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(213, 86);
            this.btnPromijeni.TabIndex = 19;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = false;
            this.btnPromijeni.Visible = false;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Black;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(15, 166);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(213, 86);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1667, 1022);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.dgvRezervacije);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKrajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ImeKorisnika;
        private System.Windows.Forms.DataGridViewComboBoxColumn PrezimeKorisnika;
    }
}