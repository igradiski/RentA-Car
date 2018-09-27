namespace Rent_a_Car
{
    partial class frmPovijestIznajmljivanja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPovijestIznajmljivanja));
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.txtBrojIznajmljivanja = new System.Windows.Forms.TextBox();
            this.dgvIznajmljivanja = new System.Windows.Forms.DataGridView();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtPocetak = new System.Windows.Forms.TextBox();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.lblKraj = new System.Windows.Forms.Label();
            this.txtNaplaceno = new System.Windows.Forms.TextBox();
            this.lblNaplaceno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(93, 21);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(59, 13);
            this.lblZaposlenik.TabIndex = 0;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(207, 18);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(121, 21);
            this.cmbZaposlenik.TabIndex = 1;
            this.cmbZaposlenik.SelectedIndexChanged += new System.EventHandler(this.cmbZaposlenik_SelectedIndexChanged);
            // 
            // txtBrojIznajmljivanja
            // 
            this.txtBrojIznajmljivanja.Location = new System.Drawing.Point(207, 63);
            this.txtBrojIznajmljivanja.Name = "txtBrojIznajmljivanja";
            this.txtBrojIznajmljivanja.Size = new System.Drawing.Size(100, 20);
            this.txtBrojIznajmljivanja.TabIndex = 2;
            // 
            // dgvIznajmljivanja
            // 
            this.dgvIznajmljivanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIznajmljivanja.Location = new System.Drawing.Point(33, 89);
            this.dgvIznajmljivanja.MultiSelect = false;
            this.dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            this.dgvIznajmljivanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIznajmljivanja.Size = new System.Drawing.Size(758, 204);
            this.dgvIznajmljivanja.TabIndex = 3;
            this.dgvIznajmljivanja.SelectionChanged += new System.EventHandler(this.dgvIznajmljivanja_SelectionChanged);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(93, 66);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(89, 13);
            this.lblBroj.TabIndex = 4;
            this.lblBroj.Text = "Broj iznajmljivanja";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(19, 322);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(82, 319);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(323, 319);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 20);
            this.txtOpis.TabIndex = 8;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(260, 322);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(31, 13);
            this.lblOpis.TabIndex = 7;
            this.lblOpis.Text = "Opis:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(579, 319);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 10;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(516, 322);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 9;
            this.lblCijena.Text = "Cijena:";
            // 
            // txtPocetak
            // 
            this.txtPocetak.Location = new System.Drawing.Point(82, 396);
            this.txtPocetak.Name = "txtPocetak";
            this.txtPocetak.Size = new System.Drawing.Size(156, 20);
            this.txtPocetak.TabIndex = 12;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Location = new System.Drawing.Point(19, 399);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(50, 13);
            this.lblPocetak.TabIndex = 11;
            this.lblPocetak.Text = "Pocetak:";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(323, 392);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(163, 20);
            this.txtKraj.TabIndex = 14;
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Location = new System.Drawing.Point(260, 395);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(28, 13);
            this.lblKraj.TabIndex = 13;
            this.lblKraj.Text = "Kraj:";
            // 
            // txtNaplaceno
            // 
            this.txtNaplaceno.Location = new System.Drawing.Point(82, 480);
            this.txtNaplaceno.Name = "txtNaplaceno";
            this.txtNaplaceno.Size = new System.Drawing.Size(100, 20);
            this.txtNaplaceno.TabIndex = 16;
            // 
            // lblNaplaceno
            // 
            this.lblNaplaceno.AutoSize = true;
            this.lblNaplaceno.Location = new System.Drawing.Point(19, 483);
            this.lblNaplaceno.Name = "lblNaplaceno";
            this.lblNaplaceno.Size = new System.Drawing.Size(62, 13);
            this.lblNaplaceno.TabIndex = 15;
            this.lblNaplaceno.Text = "Naplaceno:";
            // 
            // frmPovijestIznajmljivanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(906, 502);
            this.Controls.Add(this.txtNaplaceno);
            this.Controls.Add(this.lblNaplaceno);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.txtPocetak);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.dgvIznajmljivanja);
            this.Controls.Add(this.txtBrojIznajmljivanja);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Name = "frmPovijestIznajmljivanja";
            this.Text = "PovijestIznajmljivanja";
            this.Load += new System.EventHandler(this.frmPovijestIznajmljivanja_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPovijestIznajmljivanja_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljivanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.TextBox txtBrojIznajmljivanja;
        private System.Windows.Forms.DataGridView dgvIznajmljivanja;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtPocetak;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.TextBox txtNaplaceno;
        private System.Windows.Forms.Label lblNaplaceno;
    }
}