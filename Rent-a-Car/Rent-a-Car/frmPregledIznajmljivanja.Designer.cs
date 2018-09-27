namespace Rent_a_Car
{
    partial class frmPregledIznajmljivanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledIznajmljivanja));
            this.dgvPregledIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.iznamljivanjeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKrajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djelatnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljivanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledIznajmljivanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iznajmljivanjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledIznajmljivanja
            // 
            this.dgvPregledIznajmljivanja.AutoGenerateColumns = false;
            this.dgvPregledIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledIznajmljivanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iznamljivanjeIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.jedinicnaCijenaDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumKrajaDataGridViewTextBoxColumn,
            this.brojDanaDataGridViewTextBoxColumn,
            this.djelatnikIDDataGridViewTextBoxColumn,
            this.racunIDDataGridViewTextBoxColumn,
            this.voziloIDDataGridViewTextBoxColumn,
            this.klijentIDDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dgvPregledIznajmljivanja.DataSource = this.iznajmljivanjeBindingSource;
            this.dgvPregledIznajmljivanja.Location = new System.Drawing.Point(12, 12);
            this.dgvPregledIznajmljivanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPregledIznajmljivanja.Name = "dgvPregledIznajmljivanja";
            this.dgvPregledIznajmljivanja.RowTemplate.Height = 24;
            this.dgvPregledIznajmljivanja.Size = new System.Drawing.Size(1261, 373);
            this.dgvPregledIznajmljivanja.TabIndex = 0;
            // 
            // iznamljivanjeIDDataGridViewTextBoxColumn
            // 
            this.iznamljivanjeIDDataGridViewTextBoxColumn.DataPropertyName = "IznamljivanjeID";
            this.iznamljivanjeIDDataGridViewTextBoxColumn.HeaderText = "IznamljivanjeID";
            this.iznamljivanjeIDDataGridViewTextBoxColumn.Name = "iznamljivanjeIDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // jedinicnaCijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "JedinicnaCijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.HeaderText = "JedinicnaCijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.Name = "jedinicnaCijenaDataGridViewTextBoxColumn";
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            // 
            // datumKrajaDataGridViewTextBoxColumn
            // 
            this.datumKrajaDataGridViewTextBoxColumn.DataPropertyName = "DatumKraja";
            this.datumKrajaDataGridViewTextBoxColumn.HeaderText = "DatumKraja";
            this.datumKrajaDataGridViewTextBoxColumn.Name = "datumKrajaDataGridViewTextBoxColumn";
            // 
            // brojDanaDataGridViewTextBoxColumn
            // 
            this.brojDanaDataGridViewTextBoxColumn.DataPropertyName = "BrojDana";
            this.brojDanaDataGridViewTextBoxColumn.HeaderText = "BrojDana";
            this.brojDanaDataGridViewTextBoxColumn.Name = "brojDanaDataGridViewTextBoxColumn";
            // 
            // djelatnikIDDataGridViewTextBoxColumn
            // 
            this.djelatnikIDDataGridViewTextBoxColumn.DataPropertyName = "DjelatnikID";
            this.djelatnikIDDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.djelatnikIDDataGridViewTextBoxColumn.DisplayMember = "Ime";
            this.djelatnikIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.djelatnikIDDataGridViewTextBoxColumn.HeaderText = "Ime djelatnika";
            this.djelatnikIDDataGridViewTextBoxColumn.Name = "djelatnikIDDataGridViewTextBoxColumn";
            this.djelatnikIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.djelatnikIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.djelatnikIDDataGridViewTextBoxColumn.ValueMember = "KorisnikID";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Rent_a_Car.Korisnik);
            // 
            // racunIDDataGridViewTextBoxColumn
            // 
            this.racunIDDataGridViewTextBoxColumn.DataPropertyName = "RacunID";
            this.racunIDDataGridViewTextBoxColumn.HeaderText = "RacunID";
            this.racunIDDataGridViewTextBoxColumn.Name = "racunIDDataGridViewTextBoxColumn";
            this.racunIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.DataSource = this.voziloBindingSource;
            this.voziloIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.voziloIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            this.voziloIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.voziloIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.voziloIDDataGridViewTextBoxColumn.ValueMember = "VoziloID";
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(Rent_a_Car.Vozilo);
            // 
            // klijentIDDataGridViewTextBoxColumn
            // 
            this.klijentIDDataGridViewTextBoxColumn.DataPropertyName = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.HeaderText = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.Name = "klijentIDDataGridViewTextBoxColumn";
            this.klijentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnik1DataGridViewTextBoxColumn
            // 
            this.korisnik1DataGridViewTextBoxColumn.DataPropertyName = "Korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.HeaderText = "Korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.Name = "korisnik1DataGridViewTextBoxColumn";
            this.korisnik1DataGridViewTextBoxColumn.Visible = false;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Racun";
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // iznajmljivanjeBindingSource
            // 
            this.iznajmljivanjeBindingSource.DataSource = typeof(Rent_a_Car.Iznajmljivanje);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.Black;
            this.btnDodajStavku.FlatAppearance.BorderSize = 0;
            this.btnDodajStavku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodajStavku.Location = new System.Drawing.Point(1276, 11);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(213, 86);
            this.btnDodajStavku.TabIndex = 3;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // frmPregledIznajmljivanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1716, 468);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvPregledIznajmljivanja);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPregledIznajmljivanja";
            this.Text = "frmPregledIznajmljivanja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledIznajmljivanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iznajmljivanjeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledIznajmljivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznamljivanjeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKrajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn djelatnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iznajmljivanjeBindingSource;
        private System.Windows.Forms.Button btnDodajStavku;
    }
}