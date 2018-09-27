namespace Rent_a_Car
{
    partial class frmPokretanjeStopiranjeServisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokretanjeStopiranjeServisa));
            this.grpPokretanje = new System.Windows.Forms.GroupBox();
            this.flpPokretanje = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIzvrsi = new System.Windows.Forms.Button();
            this.grpZaustavljanje = new System.Windows.Forms.GroupBox();
            this.flpZaustavljanje = new System.Windows.Forms.FlowLayoutPanel();
            this.grpPokretanje.SuspendLayout();
            this.grpZaustavljanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPokretanje
            // 
            this.grpPokretanje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPokretanje.BackgroundImage")));
            this.grpPokretanje.Controls.Add(this.flpPokretanje);
            this.grpPokretanje.Location = new System.Drawing.Point(16, 15);
            this.grpPokretanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPokretanje.Name = "grpPokretanje";
            this.grpPokretanje.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPokretanje.Size = new System.Drawing.Size(1816, 306);
            this.grpPokretanje.TabIndex = 0;
            this.grpPokretanje.TabStop = false;
            this.grpPokretanje.Text = "Servisi za pokretanje";
            // 
            // flpPokretanje
            // 
            this.flpPokretanje.AutoScroll = true;
            this.flpPokretanje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpPokretanje.BackgroundImage")));
            this.flpPokretanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPokretanje.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPokretanje.Location = new System.Drawing.Point(4, 19);
            this.flpPokretanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpPokretanje.Name = "flpPokretanje";
            this.flpPokretanje.Size = new System.Drawing.Size(1808, 283);
            this.flpPokretanje.TabIndex = 0;
            // 
            // btnIzvrsi
            // 
            this.btnIzvrsi.BackColor = System.Drawing.Color.Black;
            this.btnIzvrsi.FlatAppearance.BorderSize = 0;
            this.btnIzvrsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIzvrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvrsi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIzvrsi.Location = new System.Drawing.Point(816, 639);
            this.btnIzvrsi.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzvrsi.Name = "btnIzvrsi";
            this.btnIzvrsi.Size = new System.Drawing.Size(213, 86);
            this.btnIzvrsi.TabIndex = 12;
            this.btnIzvrsi.Text = "Izvrši";
            this.btnIzvrsi.UseVisualStyleBackColor = false;
            this.btnIzvrsi.Click += new System.EventHandler(this.btnIzvrsi_Click);
            // 
            // grpZaustavljanje
            // 
            this.grpZaustavljanje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpZaustavljanje.BackgroundImage")));
            this.grpZaustavljanje.Controls.Add(this.flpZaustavljanje);
            this.grpZaustavljanje.Location = new System.Drawing.Point(16, 329);
            this.grpZaustavljanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpZaustavljanje.Name = "grpZaustavljanje";
            this.grpZaustavljanje.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpZaustavljanje.Size = new System.Drawing.Size(1816, 306);
            this.grpZaustavljanje.TabIndex = 1;
            this.grpZaustavljanje.TabStop = false;
            this.grpZaustavljanje.Text = "Servisi za zaustavljanje";
            // 
            // flpZaustavljanje
            // 
            this.flpZaustavljanje.AutoScroll = true;
            this.flpZaustavljanje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpZaustavljanje.BackgroundImage")));
            this.flpZaustavljanje.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpZaustavljanje.Location = new System.Drawing.Point(8, 23);
            this.flpZaustavljanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpZaustavljanje.Name = "flpZaustavljanje";
            this.flpZaustavljanje.Size = new System.Drawing.Size(1800, 276);
            this.flpZaustavljanje.TabIndex = 0;
            // 
            // frmPokretanjeStopiranjeServisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1945, 772);
            this.Controls.Add(this.grpZaustavljanje);
            this.Controls.Add(this.btnIzvrsi);
            this.Controls.Add(this.grpPokretanje);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPokretanjeStopiranjeServisa";
            this.Text = "frmPokretanjeStopiranjeServisa";
            this.grpPokretanje.ResumeLayout(false);
            this.grpZaustavljanje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPokretanje;
        private System.Windows.Forms.Button btnIzvrsi;
        private System.Windows.Forms.FlowLayoutPanel flpPokretanje;
        private System.Windows.Forms.GroupBox grpZaustavljanje;
        private System.Windows.Forms.FlowLayoutPanel flpZaustavljanje;
    }
}