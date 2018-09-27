namespace Rent_a_Car
{
    partial class frmPovratnaInformacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPovratnaInformacija));
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.lblPovratna = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKlijent.Location = new System.Drawing.Point(40, 47);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(55, 20);
            this.lblKlijent.TabIndex = 0;
            this.lblKlijent.Text = "Klijent:";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.DisplayMember = "Korisnik";
            this.cmbKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(44, 80);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(121, 28);
            this.cmbKlijent.TabIndex = 1;
            this.cmbKlijent.ValueMember = "Korisnik";
            this.cmbKlijent.SelectedValueChanged += new System.EventHandler(this.cmbKlijent_SelectedValueChanged);
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(44, 167);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(121, 28);
            this.cmbVozilo.TabIndex = 3;
            this.cmbVozilo.SelectedIndexChanged += new System.EventHandler(this.cmbVozilo_SelectedIndexChanged);
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVozilo.Location = new System.Drawing.Point(40, 126);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(56, 20);
            this.lblVozilo.TabIndex = 2;
            this.lblVozilo.Text = "Vozilo:";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(319, 67);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(316, 179);
            this.txtOpis.TabIndex = 4;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(486, 271);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(149, 54);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unesi povratnu informaciju";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // lblPovratna
            // 
            this.lblPovratna.AutoSize = true;
            this.lblPovratna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPovratna.Location = new System.Drawing.Point(315, 44);
            this.lblPovratna.Name = "lblPovratna";
            this.lblPovratna.Size = new System.Drawing.Size(161, 20);
            this.lblPovratna.TabIndex = 6;
            this.lblPovratna.Text = "Povratna informacija_";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOcjena.Location = new System.Drawing.Point(40, 219);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(114, 20);
            this.lblOcjena.TabIndex = 7;
            this.lblOcjena.Text = "Ocjena usluge:";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOcjena.ForeColor = System.Drawing.Color.Red;
            this.txtOcjena.Location = new System.Drawing.Point(44, 256);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(121, 26);
            this.txtOcjena.TabIndex = 8;
            this.txtOcjena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOcjena.TextChanged += new System.EventHandler(this.txtOcjena_TextChanged);
            // 
            // frmPovratnaInformacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 378);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblPovratna);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.lblKlijent);
            this.Name = "frmPovratnaInformacija";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.frmPovratnaInformacija_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPovratnaInformacija_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label lblPovratna;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.TextBox txtOcjena;
    }
}