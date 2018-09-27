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
    public partial class frmPrijava : Form
    {
        /// <summary>
        /// Konstruktor forme koji koristimo za inicijalizaciju komponenti
        /// </summary>
        public frmPrijava()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rukuje događajem promjena checkbox-a te u osinosti o promjeni sakriva ili prikazuje znakove lozinke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrikaziLozinku.Checked == true)
            {
                txtLozinka.PasswordChar = '\0';
            }
            else
            {
                txtLozinka.PasswordChar = '*';
            }
        }
        /// <summary>
        /// Rukuje događajem klika na gumb te prijavljuje korisnika u aplikaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text != "" && txtLozinka.Text != "")
            {
                try
                {
                    Korisnik.PrijavljeniKorisnik = Korisnik.DohvatiKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);

                }
                catch
                {
                    MessageBox.Show("Došlo je do pogreške", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Korisnik.PrijavljeniKorisnik != null)
                {
                    frmIzbornik izbornik = new frmIzbornik();
                    this.Hide();
                    izbornik.ShowDialog();
                    this.Show();
                    txtKorisnickoIme.Clear();
                    txtLozinka.Clear();
                }
                else
                {
                    MessageBox.Show("Unijeli ste krivo korisničko ime ili lozinku", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke za prijavu", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Rukuje događejem klika na gumb te otvara formu za registraciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija();
            this.Hide();          
            registracija.ShowDialog();
            this.Show();
          
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp += frmPrijava_KeyUp;
        }

        private void frmPrijava_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "Trenutno ste pritisnuli F1 na formi Prijava.\n\nNa formi Prijava možete vidjeti dva tekstualna polja " +
                    ", te dva gumba ''Prijavi se'' i ''Registracija''. Ukoliko ste već registrirani popunite tekstulna polja sa svojim podacima za prijavu " +
                    "te pritisnite gumb ''Prijavi se'', ako su podaci ispravni aplikacija Vas vodi do glavnog izbornika, a ako su podaci neispravni ispisuje se poruka pogreške.\n\n " +
                    "Također imate mogućnost prikaza lozinke, označavanjem checkbox-a prikazuju Vam se znakovi vaše lozinke.\n\n" +
                    "Ukoliko niste registrirani pritisnite gumb ''Registracija'' koji će Vas odvesti do forme za registraciju." +
                    "\n\nPodaci za prijavu:\n\nADMINISTRATOR \nKorisničko ime: agazdek1 \nLozinka: Lozinka1";
                pomoc.ShowDialog();
            }
        }
    }
}
