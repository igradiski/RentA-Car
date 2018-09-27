namespace Rent_a_Car
{
    partial class frmPovratnaInformacijaKorisnik
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
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblPovratnaInformacija = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblImeKlijenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOcjena
            // 
            this.txtOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOcjena.ForeColor = System.Drawing.Color.Red;
            this.txtOcjena.Location = new System.Drawing.Point(107, 297);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(121, 26);
            this.txtOcjena.TabIndex = 17;
            this.txtOcjena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOcjena.TextChanged += new System.EventHandler(this.txtOcjena_TextChanged);
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOcjena.Location = new System.Drawing.Point(103, 260);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(114, 20);
            this.lblOcjena.TabIndex = 16;
            this.lblOcjena.Text = "Ocjena usluge:";
            // 
            // lblPovratnaInformacija
            // 
            this.lblPovratnaInformacija.AutoSize = true;
            this.lblPovratnaInformacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPovratnaInformacija.Location = new System.Drawing.Point(378, 85);
            this.lblPovratnaInformacija.Name = "lblPovratnaInformacija";
            this.lblPovratnaInformacija.Size = new System.Drawing.Size(156, 20);
            this.lblPovratnaInformacija.TabIndex = 15;
            this.lblPovratnaInformacija.Text = "Povratna informacija:";
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(549, 312);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(149, 54);
            this.btnUnos.TabIndex = 14;
            this.btnUnos.Text = "Unesi povratnu informaciju";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(382, 108);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(316, 179);
            this.txtOpis.TabIndex = 13;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(107, 208);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(121, 28);
            this.cmbVozilo.TabIndex = 12;
            this.cmbVozilo.SelectedValueChanged += new System.EventHandler(this.cmbVozilo_SelectedValueChanged);
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVozilo.Location = new System.Drawing.Point(103, 167);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(56, 20);
            this.lblVozilo.TabIndex = 11;
            this.lblVozilo.Text = "Vozilo:";
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKlijent.Location = new System.Drawing.Point(103, 88);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(55, 20);
            this.lblKlijent.TabIndex = 9;
            this.lblKlijent.Text = "Klijent:";
            // 
            // lblImeKlijenta
            // 
            this.lblImeKlijenta.AutoSize = true;
            this.lblImeKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeKlijenta.Location = new System.Drawing.Point(104, 126);
            this.lblImeKlijenta.Name = "lblImeKlijenta";
            this.lblImeKlijenta.Size = new System.Drawing.Size(55, 20);
            this.lblImeKlijenta.TabIndex = 18;
            this.lblImeKlijenta.Text = "Klijent:";
            // 
            // frmPovratnaInformacijaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImeKlijenta);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblPovratnaInformacija);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKlijent);
            this.Name = "frmPovratnaInformacijaKorisnik";
            this.Text = "frmPovratnaInformacijaKorisnik";
            this.Load += new System.EventHandler(this.frmPovratnaInformacijaKorisnik_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPovratnaInformacijaKorisnik_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblPovratnaInformacija;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblImeKlijenta;
    }
}