using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_Car
{
    public partial class frmVozila : Form
    {
        /// <summary>
        /// Konstruktor forme koji služi za inicijalizaciju komponenti
        /// </summary>
        public frmVozila()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Motoda koja omogućava prikaz vozila na dgvPrikazVozila
        /// </summary>
        private void OsvjeziPrikazVozila()
        {
            tipMotoraBindingSource.DataSource = TipMotora.DohvatiTipoveMotora();
            kategorijaBindingSource.DataSource = Kategorija.DohvatiKategorije();
            voziloBindingSource.DataSource = Vozilo.DohvatiVozila();
            dgvPrikazVozila.DataSource = voziloBindingSource;
        }
        /// <summary>
        /// Rukuje događajem pokretanja forme te osvježava prikaz vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVozila_Load(object sender, EventArgs e)
        {
            OsvjeziPrikazVozila();
            this.KeyPreview = true;
            this.KeyUp += frmVozila_KeyUp;
        }

        private void frmVozila_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "Trenutno ste pritisnuli F1 na formi Vozila.\n\n" +
                    "Na formi Vozila možete vidjeti tablični prikaz koji pokazuje sva vozila, gumbove ''Dodaj vozilo'', ''Ažuriraj Vozilo'', ''Briši vozilo'', te dva tekstualna polja.\n\n " +
                    "Prilikom klika na gumb ''Dodaj vozilo'' aplikacija Vas vodi na formu za unos novog vozila .\n\n" +
                    "Ukoliko odaberete neko vozilo iz tablice i pritisnite gumb ''Ažuriraj vozilo'' aplikacija Vas vodi do forme za izmjenu podataka o vozilu.\n\n" +
                    "Ukoliko odaberete neko vozilo iz tablice i pritisnite gumb ''Briši vozilo'' vozilo se briše ako trenutno nije iznamljeno ili rezervirano, u tom slučaju se ispisuje poruka pogreške.\n\n" +
                    "Prilikom unosa teksta u tekstualno polje ''Pretraga po nazivu'' u tablici se prikazuju samo vozila čiji naziv sadrži uneseni tekst. \n\n" +
                    "Prilikom unosa teksta u tekstualno polje ''Pretraga po registraciji'' u tablici se prikazuju samo vozila čije registracijske oznake sadrže uneseni tekst. \n\n";
                pomoc.ShowDialog();
            }
        }

        /// <summary>
        /// Rukuje događajem klika na gumb te otvara formu za dodavanje novog vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDodajVozilo vozilo = new frmDodajVozilo();
            vozilo.ShowDialog();
            OsvjeziPrikazVozila();
            this.Show();
        }
        /// <summary>
        /// Rukuje događajem klika na gumb za prosljeđivanje vozila za ažuriranje preko konstruktora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {
            Vozilo selektiranoVozilo = voziloBindingSource.Current as Vozilo;
            if (selektiranoVozilo != null)
            {
                this.Hide();
                frmDodajVozilo azuriraj = new frmDodajVozilo(selektiranoVozilo);
                azuriraj.ShowDialog();
                OsvjeziPrikazVozila();
                this.Show();

            }
        }
        /// <summary>
        /// Rukuje događajem klika na gumb te briše odabrano vozilo ak vozilo nije iznajmljeno ili rezervirano
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrisiVozilo_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = voziloBindingSource.Current as Vozilo;
            using (RentACarEntities db = new RentACarEntities())
            {
                db.Vozilo.Attach(vozilo);
                if (Iznajmljivanje.ProvjeriZauzetostVozila(vozilo.VoziloID) == true && Rezervacija.ProvjeriZauzetostVozila(vozilo.VoziloID))
                {
                    db.Vozilo.Remove(vozilo);
                    db.SaveChanges();
                }
                else if (Iznajmljivanje.ProvjeriZauzetostVozila(vozilo.VoziloID) == false)
                {
                    MessageBox.Show("Vozilo je iznajmljeno te ga nije moguće izbrisati", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Rezervacija.ProvjeriZauzetostVozila(vozilo.VoziloID)==false)
                {
                    MessageBox.Show("Vozilo je rezervirano te ga nije moguće izbrisati", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            OsvjeziPrikazVozila();
        }
        /// <summary>
        /// Rukuje događajem promjena teksta te prikazuje vozila koja sadrže u nazivu uneseni tekst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPretragaPoNazivu_TextChanged(object sender, EventArgs e)
        {
            voziloBindingSource.DataSource = Vozilo.DohvatiVozilaPoNazivu(txtPretragaPoNazivu.Text);
        }
        /// <summary>
        /// Rukuje događajem promjena teksta te prikazuje vozila koja sadrže u registracijskim oznakama uneseni tekst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPretragaPoRegistraciji_TextChanged(object sender, EventArgs e)
        {
            voziloBindingSource.DataSource = Vozilo.DohvatiVozilaPoRegistracijskimOznakama(txtPretragaPoRegistraciji.Text);
        }
        /// <summary>
        /// Rukuje događajem klika na gumb. Prilikom klika zatvara se forma frmVozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
