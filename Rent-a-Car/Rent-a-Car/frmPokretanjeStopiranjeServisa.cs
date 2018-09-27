using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace Rent_a_Car
{
    public partial class frmPokretanjeStopiranjeServisa : Form
    {
        private ServiceController servis { get; set; }
        public frmPokretanjeStopiranjeServisa()
        {
            InitializeComponent();
            /*ServiceController[] servisi = ServiceController.GetServices();
            int i = 0;
            foreach (ServiceController servis in servisi)
            {
                i++;
                if (servis.Status.Equals(ServiceControllerStatus.Stopped))
                {
                    string nazivServisa = servis.DisplayName;
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "chkServis" + i.ToString();
                    checkBox.Text = nazivServisa;
                    flpPokretanje.Controls.Add(checkBox);
                }
                else
                {
                    string nazivServisa = servis.DisplayName;
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "chkServis" + i.ToString();
                    checkBox.Text = nazivServisa;
                    flpZaustavljanje.Controls.Add(checkBox);
                }
            }*/

            try
            {
                ServiceController serviceController = new ServiceController("WindowsServiceSlanjeMaila");
                this.servis = serviceController;
                if (serviceController.Status.Equals(ServiceControllerStatus.Stopped))
                {
                    string nazivServisa = serviceController.DisplayName;
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "chkServisSlanjeMaila";
                    checkBox.Text = nazivServisa;
                    checkBox.BackgroundImage = flpPokretanje.BackgroundImage;
                    checkBox.Size = new Size(checkBox.Size.Width + 50, checkBox.Size.Height);
                    flpPokretanje.Controls.Add(checkBox);
                }
                else
                {
                    string nazivServisa = serviceController.DisplayName;
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = "chkServisSlanjeMaila";
                    checkBox.Text = nazivServisa;
                    checkBox.BackgroundImage = flpPokretanje.BackgroundImage;
                    checkBox.Size = new Size(checkBox.Size.Width + 50, checkBox.Size.Height);
                    flpZaustavljanje.Controls.Add(checkBox);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Zatvori me, zar ne vidiš da gorim!", "ERROR");
            }
            

        }
        /// <summary>
        /// Rukuje događajem klika na gumb btnIzvrsi. Izvršava pokretanje/zaustavljanje odabranih servisa i zatvara formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzvrsi_Click(object sender, EventArgs e)
        {
            if (flpPokretanje.Controls.Count > 0)
            {
                CheckBox checkBox = (CheckBox)flpPokretanje.Controls[0];
                if (checkBox.Checked)
                {
                    servis.Start();
                }
            }
            else if (flpZaustavljanje.Controls.Count > 0)
            { 
                CheckBox checkBox = (CheckBox)flpZaustavljanje.Controls[0];
                if (checkBox.Checked)
                {
                    servis.Stop();
                }
            }
            this.Close();
        }
    }
}
