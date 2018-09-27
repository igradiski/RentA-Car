namespace Rent_a_Car
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.chkPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.lblPrikaziLozinku = new System.Windows.Forms.Label();
            this.grpPrijava = new System.Windows.Forms.GroupBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(142, 153);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(192, 22);
            this.txtKorisnickoIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(142, 197);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(192, 22);
            this.txtLozinka.TabIndex = 1;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(22, 156);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.lblKorisnickoIme.TabIndex = 2;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Location = new System.Drawing.Point(22, 200);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(57, 17);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka";
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.BackColor = System.Drawing.Color.Black;
            this.btnPrijavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijavi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrijavi.Location = new System.Drawing.Point(142, 282);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(192, 34);
            this.btnPrijavi.TabIndex = 4;
            this.btnPrijavi.Text = "Prijavi se";
            this.btnPrijavi.UseVisualStyleBackColor = false;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // chkPrikaziLozinku
            // 
            this.chkPrikaziLozinku.AutoSize = true;
            this.chkPrikaziLozinku.Location = new System.Drawing.Point(142, 242);
            this.chkPrikaziLozinku.Name = "chkPrikaziLozinku";
            this.chkPrikaziLozinku.Size = new System.Drawing.Size(18, 17);
            this.chkPrikaziLozinku.TabIndex = 5;
            this.chkPrikaziLozinku.UseVisualStyleBackColor = true;
            this.chkPrikaziLozinku.CheckedChanged += new System.EventHandler(this.chkPrikaziLozinku_CheckedChanged);
            // 
            // lblPrikaziLozinku
            // 
            this.lblPrikaziLozinku.AutoSize = true;
            this.lblPrikaziLozinku.BackColor = System.Drawing.Color.Transparent;
            this.lblPrikaziLozinku.Location = new System.Drawing.Point(22, 242);
            this.lblPrikaziLozinku.Name = "lblPrikaziLozinku";
            this.lblPrikaziLozinku.Size = new System.Drawing.Size(98, 17);
            this.lblPrikaziLozinku.TabIndex = 6;
            this.lblPrikaziLozinku.Text = "Prikaži lozinku";
            // 
            // grpPrijava
            // 
            this.grpPrijava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPrijava.BackgroundImage")));
            this.grpPrijava.Controls.Add(this.btnRegistriraj);
            this.grpPrijava.Controls.Add(this.btnPrijavi);
            this.grpPrijava.Controls.Add(this.pictureBox1);
            this.grpPrijava.Controls.Add(this.lblKorisnickoIme);
            this.grpPrijava.Controls.Add(this.lblPrikaziLozinku);
            this.grpPrijava.Controls.Add(this.txtKorisnickoIme);
            this.grpPrijava.Controls.Add(this.chkPrikaziLozinku);
            this.grpPrijava.Controls.Add(this.txtLozinka);
            this.grpPrijava.Controls.Add(this.lblLozinka);
            this.grpPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrijava.Location = new System.Drawing.Point(217, 35);
            this.grpPrijava.Name = "grpPrijava";
            this.grpPrijava.Size = new System.Drawing.Size(380, 373);
            this.grpPrijava.TabIndex = 7;
            this.grpPrijava.TabStop = false;
            this.grpPrijava.Text = "Prijava";
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.BackColor = System.Drawing.Color.Black;
            this.btnRegistriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistriraj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistriraj.Location = new System.Drawing.Point(142, 322);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(192, 34);
            this.btnRegistriraj.TabIndex = 10;
            this.btnRegistriraj.Text = "Registracija";
            this.btnRegistriraj.UseVisualStyleBackColor = false;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 468);
            this.Controls.Add(this.grpPrijava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            this.grpPrijava.ResumeLayout(false);
            this.grpPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.CheckBox chkPrikaziLozinku;
        private System.Windows.Forms.Label lblPrikaziLozinku;
        private System.Windows.Forms.GroupBox grpPrijava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistriraj;
    }
}