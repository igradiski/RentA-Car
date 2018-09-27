namespace Rent_a_Car
{
    partial class frmIzdavanjeRacuna
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzdavanjeRacuna));
            this.IznajmljivanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsRacun = new Rent_a_Car.dtsRacun();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.IznajmljivanjeTableAdapter = new Rent_a_Car.dtsRacunTableAdapters.IznajmljivanjeTableAdapter();
            this.rpvRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IznajmljivanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // IznajmljivanjeBindingSource
            // 
            this.IznajmljivanjeBindingSource.DataMember = "Iznajmljivanje";
            this.IznajmljivanjeBindingSource.DataSource = this.dtsRacun;
            // 
            // dtsRacun
            // 
            this.dtsRacun.DataSetName = "dtsRacun";
            this.dtsRacun.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.Black;
            this.btnDodajStavku.FlatAppearance.BorderSize = 0;
            this.btnDodajStavku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodajStavku.Location = new System.Drawing.Point(1429, 15);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(213, 86);
            this.btnDodajStavku.TabIndex = 2;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // IznajmljivanjeTableAdapter
            // 
            this.IznajmljivanjeTableAdapter.ClearBeforeFill = true;
            // 
            // rpvRacun
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.IznajmljivanjeBindingSource;
            this.rpvRacun.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRacun.LocalReport.ReportEmbeddedResource = "Rent_a_Car.rpRacun.rdlc";
            this.rpvRacun.Location = new System.Drawing.Point(16, 15);
            this.rpvRacun.Margin = new System.Windows.Forms.Padding(4);
            this.rpvRacun.Name = "rpvRacun";
            this.rpvRacun.ServerReport.BearerToken = null;
            this.rpvRacun.Size = new System.Drawing.Size(1409, 524);
            this.rpvRacun.TabIndex = 3;
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.BackColor = System.Drawing.Color.Black;
            this.btnIzdajRacun.FlatAppearance.BorderSize = 0;
            this.btnIzdajRacun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIzdajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdajRacun.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIzdajRacun.Location = new System.Drawing.Point(1429, 101);
            this.btnIzdajRacun.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(213, 86);
            this.btnIzdajRacun.TabIndex = 4;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // frmIzdavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1957, 663);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.rpvRacun);
            this.Controls.Add(this.btnDodajStavku);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIzdavanjeRacuna";
            this.Text = "FrmIzdavanjeRacuna";
            this.Load += new System.EventHandler(this.frmIzdavanjeRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IznajmljivanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsRacun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.BindingSource IznajmljivanjeBindingSource;
        private dtsRacun dtsRacun;
        private dtsRacunTableAdapters.IznajmljivanjeTableAdapter IznajmljivanjeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRacun;
        private System.Windows.Forms.Button btnIzdajRacun;
    }
}