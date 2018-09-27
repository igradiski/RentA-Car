namespace Rent_a_Car
{
    partial class frmObracunPlacePregledSmjena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObracunPlacePregledSmjena));
            this.grbPlaca = new System.Windows.Forms.GroupBox();
            this.btnPlaca = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.cdrPlaca = new System.Windows.Forms.MonthCalendar();
            this.grbSmjene = new System.Windows.Forms.GroupBox();
            this.btnSmjena = new System.Windows.Forms.Button();
            this.lblDan = new System.Windows.Forms.Label();
            this.cdrSmjena = new System.Windows.Forms.MonthCalendar();
            this.grbPlaca.SuspendLayout();
            this.grbSmjene.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlaca
            // 
            this.grbPlaca.Controls.Add(this.btnPlaca);
            this.grbPlaca.Controls.Add(this.lblDatum);
            this.grbPlaca.Controls.Add(this.cmbZaposlenik);
            this.grbPlaca.Controls.Add(this.lblZaposlenik);
            this.grbPlaca.Controls.Add(this.cdrPlaca);
            this.grbPlaca.Location = new System.Drawing.Point(47, 36);
            this.grbPlaca.Name = "grbPlaca";
            this.grbPlaca.Size = new System.Drawing.Size(479, 333);
            this.grbPlaca.TabIndex = 0;
            this.grbPlaca.TabStop = false;
            this.grbPlaca.Text = "Placa";
            // 
            // btnPlaca
            // 
            this.btnPlaca.Location = new System.Drawing.Point(282, 268);
            this.btnPlaca.Name = "btnPlaca";
            this.btnPlaca.Size = new System.Drawing.Size(92, 40);
            this.btnPlaca.TabIndex = 5;
            this.btnPlaca.Text = "Obracunaj placu";
            this.btnPlaca.UseVisualStyleBackColor = true;
            this.btnPlaca.Click += new System.EventHandler(this.btnPlaca_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(80, 94);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(83, 13);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Odabir mjeseca:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(179, 36);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(121, 21);
            this.cmbZaposlenik.TabIndex = 3;
            this.cmbZaposlenik.SelectedValueChanged += new System.EventHandler(this.cmbZaposlenik_SelectedValueChanged);
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(80, 39);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(59, 13);
            this.lblZaposlenik.TabIndex = 2;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // cdrPlaca
            // 
            this.cdrPlaca.Location = new System.Drawing.Point(175, 94);
            this.cdrPlaca.Name = "cdrPlaca";
            this.cdrPlaca.TabIndex = 1;
            this.cdrPlaca.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrPlaca_DateChanged);
            // 
            // grbSmjene
            // 
            this.grbSmjene.Controls.Add(this.btnSmjena);
            this.grbSmjene.Controls.Add(this.lblDan);
            this.grbSmjene.Controls.Add(this.cdrSmjena);
            this.grbSmjene.Location = new System.Drawing.Point(567, 36);
            this.grbSmjene.Name = "grbSmjene";
            this.grbSmjene.Size = new System.Drawing.Size(479, 333);
            this.grbSmjene.TabIndex = 1;
            this.grbSmjene.TabStop = false;
            this.grbSmjene.Text = "Smjene";
            // 
            // btnSmjena
            // 
            this.btnSmjena.Location = new System.Drawing.Point(237, 268);
            this.btnSmjena.Name = "btnSmjena";
            this.btnSmjena.Size = new System.Drawing.Size(84, 40);
            this.btnSmjena.TabIndex = 6;
            this.btnSmjena.Text = "Planiraj smjene";
            this.btnSmjena.UseVisualStyleBackColor = true;
            this.btnSmjena.Click += new System.EventHandler(this.btnSmjena_Click);
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Location = new System.Drawing.Point(27, 94);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(68, 13);
            this.lblDan.TabIndex = 5;
            this.lblDan.Text = "Odabir dana:";
            // 
            // cdrSmjena
            // 
            this.cdrSmjena.Location = new System.Drawing.Point(122, 94);
            this.cdrSmjena.Name = "cdrSmjena";
            this.cdrSmjena.TabIndex = 0;
            this.cdrSmjena.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrSmjena_DateChanged);
            // 
            // frmObracunPlacePregledSmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1131, 537);
            this.Controls.Add(this.grbSmjene);
            this.Controls.Add(this.grbPlaca);
            this.Name = "frmObracunPlacePregledSmjena";
            this.Text = "frmObracunPlacePregledSmjena";
            this.Load += new System.EventHandler(this.frmObracunPlacePregledSmjena_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmObracunPlacePregledSmjena_KeyUp);
            this.grbPlaca.ResumeLayout(false);
            this.grbPlaca.PerformLayout();
            this.grbSmjene.ResumeLayout(false);
            this.grbSmjene.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlaca;
        private System.Windows.Forms.GroupBox grbSmjene;
        private System.Windows.Forms.Button btnPlaca;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.MonthCalendar cdrPlaca;
        private System.Windows.Forms.Button btnSmjena;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.MonthCalendar cdrSmjena;
    }
}