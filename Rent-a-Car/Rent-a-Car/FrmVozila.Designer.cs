namespace Rent_a_Car
{
    partial class frmVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozila));
            this.dgvPrikazVozila = new System.Windows.Forms.DataGridView();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnAzurirajVozilo = new System.Windows.Forms.Button();
            this.btnBrisiVozilo = new System.Windows.Forms.Button();
            this.grpFiltar = new System.Windows.Forms.GroupBox();
            this.lblPretragaPoRegistraciji = new System.Windows.Forms.Label();
            this.txtPretragaPoRegistraciji = new System.Windows.Forms.TextBox();
            this.lblPretragaPoNazivu = new System.Windows.Forms.Label();
            this.txtPretragaPoNazivu = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaProizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagaMotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSjedalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRegistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipMotoraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipMotoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaPoDanuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povratnaInformacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMotoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljivanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazVozila)).BeginInit();
            this.grpFiltar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipMotoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazVozila
            // 
            this.dgvPrikazVozila.AutoGenerateColumns = false;
            this.dgvPrikazVozila.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvPrikazVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voziloIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.godinaProizvodnjeDataGridViewTextBoxColumn,
            this.snagaMotoraDataGridViewTextBoxColumn,
            this.brojSjedalaDataGridViewTextBoxColumn,
            this.kilometriDataGridViewTextBoxColumn,
            this.datumRegistracijeDataGridViewTextBoxColumn,
            this.kategorijaIDDataGridViewTextBoxColumn,
            this.tipMotoraIDDataGridViewTextBoxColumn,
            this.cijenaPoDanuDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.povratnaInformacijaDataGridViewTextBoxColumn,
            this.tipMotoraDataGridViewTextBoxColumn,
            this.iznajmljivanjeDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.dgvPrikazVozila.DataSource = this.voziloBindingSource;
            this.dgvPrikazVozila.Location = new System.Drawing.Point(12, 59);
            this.dgvPrikazVozila.MultiSelect = false;
            this.dgvPrikazVozila.Name = "dgvPrikazVozila";
            this.dgvPrikazVozila.RowTemplate.Height = 24;
            this.dgvPrikazVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazVozila.Size = new System.Drawing.Size(1050, 310);
            this.dgvPrikazVozila.TabIndex = 0;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.Black;
            this.btnDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozilo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodajVozilo.Location = new System.Drawing.Point(12, 399);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(172, 62);
            this.btnDodajVozilo.TabIndex = 1;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnAzurirajVozilo
            // 
            this.btnAzurirajVozilo.BackColor = System.Drawing.Color.Black;
            this.btnAzurirajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajVozilo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAzurirajVozilo.Location = new System.Drawing.Point(218, 399);
            this.btnAzurirajVozilo.Name = "btnAzurirajVozilo";
            this.btnAzurirajVozilo.Size = new System.Drawing.Size(172, 62);
            this.btnAzurirajVozilo.TabIndex = 2;
            this.btnAzurirajVozilo.Text = "Ažuriraj vozilo";
            this.btnAzurirajVozilo.UseVisualStyleBackColor = false;
            this.btnAzurirajVozilo.Click += new System.EventHandler(this.btnAzurirajVozilo_Click);
            // 
            // btnBrisiVozilo
            // 
            this.btnBrisiVozilo.BackColor = System.Drawing.Color.Black;
            this.btnBrisiVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisiVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiVozilo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBrisiVozilo.Location = new System.Drawing.Point(416, 399);
            this.btnBrisiVozilo.Name = "btnBrisiVozilo";
            this.btnBrisiVozilo.Size = new System.Drawing.Size(172, 62);
            this.btnBrisiVozilo.TabIndex = 3;
            this.btnBrisiVozilo.Text = "Izbriši vozilo";
            this.btnBrisiVozilo.UseVisualStyleBackColor = false;
            this.btnBrisiVozilo.Click += new System.EventHandler(this.btnBrisiVozilo_Click);
            // 
            // grpFiltar
            // 
            this.grpFiltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpFiltar.BackgroundImage")));
            this.grpFiltar.Controls.Add(this.lblPretragaPoRegistraciji);
            this.grpFiltar.Controls.Add(this.txtPretragaPoRegistraciji);
            this.grpFiltar.Controls.Add(this.lblPretragaPoNazivu);
            this.grpFiltar.Controls.Add(this.txtPretragaPoNazivu);
            this.grpFiltar.ForeColor = System.Drawing.Color.Black;
            this.grpFiltar.Location = new System.Drawing.Point(623, 375);
            this.grpFiltar.Name = "grpFiltar";
            this.grpFiltar.Size = new System.Drawing.Size(439, 108);
            this.grpFiltar.TabIndex = 6;
            this.grpFiltar.TabStop = false;
            this.grpFiltar.Text = "Pretraga";
            // 
            // lblPretragaPoRegistraciji
            // 
            this.lblPretragaPoRegistraciji.AutoSize = true;
            this.lblPretragaPoRegistraciji.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaPoRegistraciji.ForeColor = System.Drawing.Color.Black;
            this.lblPretragaPoRegistraciji.Location = new System.Drawing.Point(64, 64);
            this.lblPretragaPoRegistraciji.Name = "lblPretragaPoRegistraciji";
            this.lblPretragaPoRegistraciji.Size = new System.Drawing.Size(93, 17);
            this.lblPretragaPoRegistraciji.TabIndex = 3;
            this.lblPretragaPoRegistraciji.Text = "Po registraciji";
            // 
            // txtPretragaPoRegistraciji
            // 
            this.txtPretragaPoRegistraciji.Location = new System.Drawing.Point(171, 61);
            this.txtPretragaPoRegistraciji.Name = "txtPretragaPoRegistraciji";
            this.txtPretragaPoRegistraciji.Size = new System.Drawing.Size(169, 22);
            this.txtPretragaPoRegistraciji.TabIndex = 2;
            this.txtPretragaPoRegistraciji.TextChanged += new System.EventHandler(this.txtPretragaPoRegistraciji_TextChanged);
            // 
            // lblPretragaPoNazivu
            // 
            this.lblPretragaPoNazivu.AutoSize = true;
            this.lblPretragaPoNazivu.BackColor = System.Drawing.Color.Transparent;
            this.lblPretragaPoNazivu.ForeColor = System.Drawing.Color.Black;
            this.lblPretragaPoNazivu.Location = new System.Drawing.Point(64, 29);
            this.lblPretragaPoNazivu.Name = "lblPretragaPoNazivu";
            this.lblPretragaPoNazivu.Size = new System.Drawing.Size(70, 17);
            this.lblPretragaPoNazivu.TabIndex = 1;
            this.lblPretragaPoNazivu.Text = "Po nazivu";
            // 
            // txtPretragaPoNazivu
            // 
            this.txtPretragaPoNazivu.Location = new System.Drawing.Point(171, 24);
            this.txtPretragaPoNazivu.Name = "txtPretragaPoNazivu";
            this.txtPretragaPoNazivu.Size = new System.Drawing.Size(169, 22);
            this.txtPretragaPoNazivu.TabIndex = 0;
            this.txtPretragaPoNazivu.TextChanged += new System.EventHandler(this.txtPretragaPoNazivu_TextChanged);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.Black;
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(131, 32);
            this.btnNatrag.TabIndex = 7;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "Reg. Oznake";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // godinaProizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaProizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "GodinaProizvodnje";
            this.godinaProizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina proizvodnje";
            this.godinaProizvodnjeDataGridViewTextBoxColumn.Name = "godinaProizvodnjeDataGridViewTextBoxColumn";
            // 
            // snagaMotoraDataGridViewTextBoxColumn
            // 
            this.snagaMotoraDataGridViewTextBoxColumn.DataPropertyName = "SnagaMotora";
            this.snagaMotoraDataGridViewTextBoxColumn.HeaderText = "Snaga motora";
            this.snagaMotoraDataGridViewTextBoxColumn.Name = "snagaMotoraDataGridViewTextBoxColumn";
            // 
            // brojSjedalaDataGridViewTextBoxColumn
            // 
            this.brojSjedalaDataGridViewTextBoxColumn.DataPropertyName = "BrojSjedala";
            this.brojSjedalaDataGridViewTextBoxColumn.HeaderText = "Broj sjedala";
            this.brojSjedalaDataGridViewTextBoxColumn.Name = "brojSjedalaDataGridViewTextBoxColumn";
            // 
            // kilometriDataGridViewTextBoxColumn
            // 
            this.kilometriDataGridViewTextBoxColumn.DataPropertyName = "Kilometri";
            this.kilometriDataGridViewTextBoxColumn.HeaderText = "Kilometri";
            this.kilometriDataGridViewTextBoxColumn.Name = "kilometriDataGridViewTextBoxColumn";
            // 
            // datumRegistracijeDataGridViewTextBoxColumn
            // 
            this.datumRegistracijeDataGridViewTextBoxColumn.DataPropertyName = "DatumRegistracije";
            this.datumRegistracijeDataGridViewTextBoxColumn.HeaderText = "Datum registracije";
            this.datumRegistracijeDataGridViewTextBoxColumn.Name = "datumRegistracijeDataGridViewTextBoxColumn";
            // 
            // kategorijaIDDataGridViewTextBoxColumn
            // 
            this.kategorijaIDDataGridViewTextBoxColumn.DataPropertyName = "KategorijaID";
            this.kategorijaIDDataGridViewTextBoxColumn.DataSource = this.kategorijaBindingSource;
            this.kategorijaIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.kategorijaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.kategorijaIDDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaIDDataGridViewTextBoxColumn.Name = "kategorijaIDDataGridViewTextBoxColumn";
            this.kategorijaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kategorijaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kategorijaIDDataGridViewTextBoxColumn.ValueMember = "KategorijaID";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = typeof(Rent_a_Car.Kategorija);
            // 
            // tipMotoraIDDataGridViewTextBoxColumn
            // 
            this.tipMotoraIDDataGridViewTextBoxColumn.DataPropertyName = "TipMotoraID";
            this.tipMotoraIDDataGridViewTextBoxColumn.DataSource = this.tipMotoraBindingSource;
            this.tipMotoraIDDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.tipMotoraIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tipMotoraIDDataGridViewTextBoxColumn.HeaderText = "Tip motora";
            this.tipMotoraIDDataGridViewTextBoxColumn.Name = "tipMotoraIDDataGridViewTextBoxColumn";
            this.tipMotoraIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipMotoraIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipMotoraIDDataGridViewTextBoxColumn.ValueMember = "TipMotoraID";
            // 
            // tipMotoraBindingSource
            // 
            this.tipMotoraBindingSource.DataSource = typeof(Rent_a_Car.TipMotora);
            // 
            // cijenaPoDanuDataGridViewTextBoxColumn
            // 
            this.cijenaPoDanuDataGridViewTextBoxColumn.DataPropertyName = "CijenaPoDanu";
            this.cijenaPoDanuDataGridViewTextBoxColumn.HeaderText = "Cijena po danu";
            this.cijenaPoDanuDataGridViewTextBoxColumn.Name = "cijenaPoDanuDataGridViewTextBoxColumn";
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // povratnaInformacijaDataGridViewTextBoxColumn
            // 
            this.povratnaInformacijaDataGridViewTextBoxColumn.DataPropertyName = "PovratnaInformacija";
            this.povratnaInformacijaDataGridViewTextBoxColumn.HeaderText = "PovratnaInformacija";
            this.povratnaInformacijaDataGridViewTextBoxColumn.Name = "povratnaInformacijaDataGridViewTextBoxColumn";
            this.povratnaInformacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipMotoraDataGridViewTextBoxColumn
            // 
            this.tipMotoraDataGridViewTextBoxColumn.DataPropertyName = "TipMotora";
            this.tipMotoraDataGridViewTextBoxColumn.HeaderText = "TipMotora";
            this.tipMotoraDataGridViewTextBoxColumn.Name = "tipMotoraDataGridViewTextBoxColumn";
            this.tipMotoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // iznajmljivanjeDataGridViewTextBoxColumn
            // 
            this.iznajmljivanjeDataGridViewTextBoxColumn.DataPropertyName = "Iznajmljivanje";
            this.iznajmljivanjeDataGridViewTextBoxColumn.HeaderText = "Iznajmljivanje";
            this.iznajmljivanjeDataGridViewTextBoxColumn.Name = "iznajmljivanjeDataGridViewTextBoxColumn";
            this.iznajmljivanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(Rent_a_Car.Vozilo);
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1094, 512);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grpFiltar);
            this.Controls.Add(this.btnBrisiVozilo);
            this.Controls.Add(this.btnAzurirajVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvPrikazVozila);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmVozila";
            this.Text = "Podaci o vozilima";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazVozila)).EndInit();
            this.grpFiltar.ResumeLayout(false);
            this.grpFiltar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipMotoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazVozila;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaProizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagaMotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSjedalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRegistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kategorijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipMotoraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipMotoraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaPoDanuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povratnaInformacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipMotoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljivanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnAzurirajVozilo;
        private System.Windows.Forms.Button btnBrisiVozilo;
        private System.Windows.Forms.GroupBox grpFiltar;
        private System.Windows.Forms.Label lblPretragaPoRegistraciji;
        private System.Windows.Forms.TextBox txtPretragaPoRegistraciji;
        private System.Windows.Forms.Label lblPretragaPoNazivu;
        private System.Windows.Forms.TextBox txtPretragaPoNazivu;
        private System.Windows.Forms.Button btnNatrag;
    }
}