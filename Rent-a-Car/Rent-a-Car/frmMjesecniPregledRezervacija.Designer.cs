namespace Rent_a_Car
{
    partial class frmMjesecniPregledRezervacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMjesecniPregledRezervacija));
            this.dtpMjesec = new System.Windows.Forms.DateTimePicker();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKrajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jedinicnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMjesec
            // 
            this.dtpMjesec.Location = new System.Drawing.Point(315, 32);
            this.dtpMjesec.Name = "dtpMjesec";
            this.dtpMjesec.Size = new System.Drawing.Size(200, 22);
            this.dtpMjesec.TabIndex = 1;
            this.dtpMjesec.ValueChanged += new System.EventHandler(this.dtpMjesec_ValueChanged);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.Black;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(12, 31);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(121, 34);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervacijaIDDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumRezervacijeDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.datumKrajaDataGridViewTextBoxColumn,
            this.voziloIDDataGridViewTextBoxColumn,
            this.korisnikIDDataGridViewTextBoxColumn,
            this.jedinicnaCijenaDataGridViewTextBoxColumn,
            this.brojDanaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 275);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(Rent_a_Car.Vozilo);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Rent_a_Car.Korisnik);
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(Rent_a_Car.Rezervacija);
            // 
            // rezervacijaIDDataGridViewTextBoxColumn
            // 
            this.rezervacijaIDDataGridViewTextBoxColumn.DataPropertyName = "RezervacijaID";
            this.rezervacijaIDDataGridViewTextBoxColumn.HeaderText = "RezervacijaID";
            this.rezervacijaIDDataGridViewTextBoxColumn.Name = "rezervacijaIDDataGridViewTextBoxColumn";
            this.rezervacijaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // datumRezervacijeDataGridViewTextBoxColumn
            // 
            this.datumRezervacijeDataGridViewTextBoxColumn.DataPropertyName = "DatumRezervacije";
            this.datumRezervacijeDataGridViewTextBoxColumn.HeaderText = "Datum rezervacije";
            this.datumRezervacijeDataGridViewTextBoxColumn.Name = "datumRezervacijeDataGridViewTextBoxColumn";
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "Datum početka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            // 
            // datumKrajaDataGridViewTextBoxColumn
            // 
            this.datumKrajaDataGridViewTextBoxColumn.DataPropertyName = "DatumKraja";
            this.datumKrajaDataGridViewTextBoxColumn.HeaderText = "Datum kraja";
            this.datumKrajaDataGridViewTextBoxColumn.Name = "datumKrajaDataGridViewTextBoxColumn";
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.DataSource = this.voziloBindingSource;
            this.voziloIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.voziloIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "Naziv vozila";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            this.voziloIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.voziloIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.voziloIDDataGridViewTextBoxColumn.ValueMember = "VoziloID";
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "KorisnikID";
            this.korisnikIDDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.korisnikIDDataGridViewTextBoxColumn.DisplayMember = "KorisnickoIme";
            this.korisnikIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            this.korisnikIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.korisnikIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.korisnikIDDataGridViewTextBoxColumn.ValueMember = "KorisnikID";
            // 
            // jedinicnaCijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "JedinicnaCijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.HeaderText = "Jedinična cijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.Name = "jedinicnaCijenaDataGridViewTextBoxColumn";
            // 
            // brojDanaDataGridViewTextBoxColumn
            // 
            this.brojDanaDataGridViewTextBoxColumn.DataPropertyName = "BrojDana";
            this.brojDanaDataGridViewTextBoxColumn.HeaderText = "Broj dana";
            this.brojDanaDataGridViewTextBoxColumn.Name = "brojDanaDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmMjesecniPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1142, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dtpMjesec);
            this.Name = "frmMjesecniPregledRezervacija";
            this.Text = "Mjesečni pregled rezervacija";
            this.Load += new System.EventHandler(this.frmMjesecniPregledRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMjesec;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKrajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
    }
}