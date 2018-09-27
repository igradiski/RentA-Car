namespace Rent_a_Car
{
    partial class frmPomoc
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
            this.rxtPomoc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rxtPomoc
            // 
            this.rxtPomoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxtPomoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxtPomoc.Location = new System.Drawing.Point(0, 0);
            this.rxtPomoc.Name = "rxtPomoc";
            this.rxtPomoc.Size = new System.Drawing.Size(800, 450);
            this.rxtPomoc.TabIndex = 0;
            this.rxtPomoc.Text = "";
            // 
            // frmPomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rxtPomoc);
            this.Name = "frmPomoc";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rxtPomoc;
    }
}