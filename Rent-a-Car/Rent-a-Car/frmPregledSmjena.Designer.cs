namespace Rent_a_Car
{
    partial class frmPregledSmjena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledSmjena));
            this.grbUjutro = new System.Windows.Forms.GroupBox();
            this.txtUjutroBroj = new System.Windows.Forms.TextBox();
            this.cmbZaposlenikUjutro = new System.Windows.Forms.ComboBox();
            this.btnMakniUjutro = new System.Windows.Forms.Button();
            this.btnDodajUjutro = new System.Windows.Forms.Button();
            this.lblUjutroRadnici = new System.Windows.Forms.Label();
            this.grbPopodne = new System.Windows.Forms.GroupBox();
            this.txtPopodneBroj = new System.Windows.Forms.TextBox();
            this.cmbZaposlenikPopodne = new System.Windows.Forms.ComboBox();
            this.btnMakniPopodne = new System.Windows.Forms.Button();
            this.lblPopdneRadnici = new System.Windows.Forms.Label();
            this.btnDodajPopodne = new System.Windows.Forms.Button();
            this.lstPopodne = new System.Windows.Forms.ListBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblPrikazDatuma = new System.Windows.Forms.Label();
            this.lstUjutro = new System.Windows.Forms.ListBox();
            this.grbUjutro.SuspendLayout();
            this.grbPopodne.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUjutro
            // 
            this.grbUjutro.Controls.Add(this.lstUjutro);
            this.grbUjutro.Controls.Add(this.txtUjutroBroj);
            this.grbUjutro.Controls.Add(this.cmbZaposlenikUjutro);
            this.grbUjutro.Controls.Add(this.btnMakniUjutro);
            this.grbUjutro.Controls.Add(this.btnDodajUjutro);
            this.grbUjutro.Controls.Add(this.lblUjutroRadnici);
            this.grbUjutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grbUjutro.Location = new System.Drawing.Point(73, 72);
            this.grbUjutro.Name = "grbUjutro";
            this.grbUjutro.Size = new System.Drawing.Size(403, 407);
            this.grbUjutro.TabIndex = 0;
            this.grbUjutro.TabStop = false;
            this.grbUjutro.Text = "Jutarnja smjena";
            // 
            // txtUjutroBroj
            // 
            this.txtUjutroBroj.Location = new System.Drawing.Point(216, 28);
            this.txtUjutroBroj.Name = "txtUjutroBroj";
            this.txtUjutroBroj.Size = new System.Drawing.Size(100, 26);
            this.txtUjutroBroj.TabIndex = 5;
            // 
            // cmbZaposlenikUjutro
            // 
            this.cmbZaposlenikUjutro.FormattingEnabled = true;
            this.cmbZaposlenikUjutro.Location = new System.Drawing.Point(30, 276);
            this.cmbZaposlenikUjutro.Name = "cmbZaposlenikUjutro";
            this.cmbZaposlenikUjutro.Size = new System.Drawing.Size(121, 28);
            this.cmbZaposlenikUjutro.TabIndex = 4;
            // 
            // btnMakniUjutro
            // 
            this.btnMakniUjutro.Location = new System.Drawing.Point(180, 324);
            this.btnMakniUjutro.Name = "btnMakniUjutro";
            this.btnMakniUjutro.Size = new System.Drawing.Size(103, 33);
            this.btnMakniUjutro.TabIndex = 3;
            this.btnMakniUjutro.Text = "Makni radnika";
            this.btnMakniUjutro.UseVisualStyleBackColor = true;
            this.btnMakniUjutro.Click += new System.EventHandler(this.btnMakniUjutro_Click);
            // 
            // btnDodajUjutro
            // 
            this.btnDodajUjutro.Location = new System.Drawing.Point(180, 276);
            this.btnDodajUjutro.Name = "btnDodajUjutro";
            this.btnDodajUjutro.Size = new System.Drawing.Size(103, 29);
            this.btnDodajUjutro.TabIndex = 2;
            this.btnDodajUjutro.Text = "Dodaj radnika";
            this.btnDodajUjutro.UseVisualStyleBackColor = true;
            this.btnDodajUjutro.Click += new System.EventHandler(this.btnDodajUjutro_Click);
            // 
            // lblUjutroRadnici
            // 
            this.lblUjutroRadnici.AutoSize = true;
            this.lblUjutroRadnici.Location = new System.Drawing.Point(27, 31);
            this.lblUjutroRadnici.Name = "lblUjutroRadnici";
            this.lblUjutroRadnici.Size = new System.Drawing.Size(183, 20);
            this.lblUjutroRadnici.TabIndex = 1;
            this.lblUjutroRadnici.Text = "Radnici u jutarnjoj smjeni";
            // 
            // grbPopodne
            // 
            this.grbPopodne.Controls.Add(this.txtPopodneBroj);
            this.grbPopodne.Controls.Add(this.cmbZaposlenikPopodne);
            this.grbPopodne.Controls.Add(this.btnMakniPopodne);
            this.grbPopodne.Controls.Add(this.lblPopdneRadnici);
            this.grbPopodne.Controls.Add(this.btnDodajPopodne);
            this.grbPopodne.Controls.Add(this.lstPopodne);
            this.grbPopodne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grbPopodne.Location = new System.Drawing.Point(531, 72);
            this.grbPopodne.Name = "grbPopodne";
            this.grbPopodne.Size = new System.Drawing.Size(389, 374);
            this.grbPopodne.TabIndex = 1;
            this.grbPopodne.TabStop = false;
            this.grbPopodne.Text = "Popodnevna smjena";
            // 
            // txtPopodneBroj
            // 
            this.txtPopodneBroj.Location = new System.Drawing.Point(267, 28);
            this.txtPopodneBroj.Name = "txtPopodneBroj";
            this.txtPopodneBroj.Size = new System.Drawing.Size(100, 26);
            this.txtPopodneBroj.TabIndex = 6;
            // 
            // cmbZaposlenikPopodne
            // 
            this.cmbZaposlenikPopodne.FormattingEnabled = true;
            this.cmbZaposlenikPopodne.Location = new System.Drawing.Point(45, 276);
            this.cmbZaposlenikPopodne.Name = "cmbZaposlenikPopodne";
            this.cmbZaposlenikPopodne.Size = new System.Drawing.Size(121, 28);
            this.cmbZaposlenikPopodne.TabIndex = 5;
            // 
            // btnMakniPopodne
            // 
            this.btnMakniPopodne.Location = new System.Drawing.Point(184, 324);
            this.btnMakniPopodne.Name = "btnMakniPopodne";
            this.btnMakniPopodne.Size = new System.Drawing.Size(114, 33);
            this.btnMakniPopodne.TabIndex = 5;
            this.btnMakniPopodne.Text = "Makni radnika";
            this.btnMakniPopodne.UseVisualStyleBackColor = true;
            this.btnMakniPopodne.Click += new System.EventHandler(this.btnMakniPopodne_Click);
            // 
            // lblPopdneRadnici
            // 
            this.lblPopdneRadnici.AutoSize = true;
            this.lblPopdneRadnici.Location = new System.Drawing.Point(42, 31);
            this.lblPopdneRadnici.Name = "lblPopdneRadnici";
            this.lblPopdneRadnici.Size = new System.Drawing.Size(219, 20);
            this.lblPopdneRadnici.TabIndex = 2;
            this.lblPopdneRadnici.Text = "Radnici u popodnevnoj smjeni";
            // 
            // btnDodajPopodne
            // 
            this.btnDodajPopodne.Location = new System.Drawing.Point(184, 276);
            this.btnDodajPopodne.Name = "btnDodajPopodne";
            this.btnDodajPopodne.Size = new System.Drawing.Size(114, 29);
            this.btnDodajPopodne.TabIndex = 4;
            this.btnDodajPopodne.Text = "Dodaj radnika";
            this.btnDodajPopodne.UseVisualStyleBackColor = true;
            this.btnDodajPopodne.Click += new System.EventHandler(this.btnDodajPopodne_Click);
            // 
            // lstPopodne
            // 
            this.lstPopodne.FormattingEnabled = true;
            this.lstPopodne.ItemHeight = 20;
            this.lstPopodne.Location = new System.Drawing.Point(45, 58);
            this.lstPopodne.Name = "lstPopodne";
            this.lstPopodne.Size = new System.Drawing.Size(322, 184);
            this.lstPopodne.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(70, 24);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(61, 20);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // lblPrikazDatuma
            // 
            this.lblPrikazDatuma.AutoSize = true;
            this.lblPrikazDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrikazDatuma.Location = new System.Drawing.Point(168, 24);
            this.lblPrikazDatuma.Name = "lblPrikazDatuma";
            this.lblPrikazDatuma.Size = new System.Drawing.Size(133, 20);
            this.lblPrikazDatuma.TabIndex = 3;
            this.lblPrikazDatuma.Text = "00.00:0000 00:00";
            // 
            // lstUjutro
            // 
            this.lstUjutro.FormattingEnabled = true;
            this.lstUjutro.ItemHeight = 20;
            this.lstUjutro.Location = new System.Drawing.Point(30, 60);
            this.lstUjutro.Name = "lstUjutro";
            this.lstUjutro.Size = new System.Drawing.Size(322, 184);
            this.lstUjutro.TabIndex = 6;
            // 
            // frmPregledSmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1069, 539);
            this.Controls.Add(this.lblPrikazDatuma);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.grbPopodne);
            this.Controls.Add(this.grbUjutro);
            this.Name = "frmPregledSmjena";
            this.Text = "frmPregledSmjena";
            this.Load += new System.EventHandler(this.frmPregledSmjena_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPregledSmjena_KeyUp);
            this.grbUjutro.ResumeLayout(false);
            this.grbUjutro.PerformLayout();
            this.grbPopodne.ResumeLayout(false);
            this.grbPopodne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUjutro;
        private System.Windows.Forms.GroupBox grbPopodne;
        private System.Windows.Forms.ComboBox cmbZaposlenikUjutro;
        private System.Windows.Forms.Button btnMakniUjutro;
        private System.Windows.Forms.Button btnDodajUjutro;
        private System.Windows.Forms.Label lblUjutroRadnici;
        private System.Windows.Forms.ComboBox cmbZaposlenikPopodne;
        private System.Windows.Forms.Button btnMakniPopodne;
        private System.Windows.Forms.Label lblPopdneRadnici;
        private System.Windows.Forms.Button btnDodajPopodne;
        private System.Windows.Forms.ListBox lstPopodne;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblPrikazDatuma;
        private System.Windows.Forms.TextBox txtUjutroBroj;
        private System.Windows.Forms.TextBox txtPopodneBroj;
        private System.Windows.Forms.ListBox lstUjutro;
    }
}