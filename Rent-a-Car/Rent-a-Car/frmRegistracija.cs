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
    public partial class frmRegistracija : Form
    {
        /// <summary>
        /// Konstruktor forme koji koristimo za inicijalizaciju komponenti
        /// </summary>
        public frmRegistracija()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rukuje događajem pokretanje forme te puni combobox sa podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            tipKorisnikaBindingSource.DataSource = TipKorisnika.DohvatiTipoveKorisnika();
            cmbTipKorisnika.DataSource = tipKorisnikaBindingSource;
            cmbTipKorisnika.DisplayMember = "Naziv";
            cmbTipKorisnika.ValueMember = "TipID";
            if (Korisnik.PrijavljeniKorisnik == null)
            {
                cmbTipKorisnika.DropDownHeight = 1;
                cmbTipKorisnika.Enabled = false;
            }
            else if (Korisnik.PrijavljeniKorisnik.TipKorisnika == 4)
            {
                cmbTipKorisnika.SelectedIndex = 0;
                cmbTipKorisnika.Enabled = false;
            }
            this.KeyPreview = true;
            this.KeyUp += frmRegistracija_KeyUp;
        }
        /// <summary>
        /// Rukuje događajem pritisak tipke na tipkovnici.Ako je pritisnuta tipa F1 prikazuje se forma za pomoć korisnicima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistracija_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "Trenutno ste pritisnuli F1 na formi Registracija.\n\n" +
                    "Na formi Registracija možete vidjeti tekstualna polja koja se od Vas traže za registraciju, te gumb ''Registriraj''.\n\n " +
                    "OIB korisnika mora sadržavati 11 znakova, ako je OIB ispravan tekstualno polje za OIB će imati zelenu boju, inaće je boja crvena.\n\n" +
                    "Ako je korisničko ime koje ste unijeli već zauzeto tekstualno polje za unos koriničkog imena će imati crvenu boju, inače je zelena.\n\n" +
                    "Lozinka mora sadržavati minimano 8 znakova te  jedno veliko slovo i jednu znamenku, ako je lozinka ispravnog formata tekstualno polje za lozinku je zeleno inače je crveno.\n\n" +
                    "Tekstualna polja ''Broj mobitela'' i ''Broj telefona'' nisu obavezna za unos.\n\n" +
                    "Nakon što su uneseni svi obavazni podaci za registraciju možete kliknuti na gumb ''Registriraj'' te ukoliko su svi podaci ispravni aplikacija Vas vodi na formu za prijavu, a inače se ispisuje poruka o pogreški koje ste načinili.";
                pomoc.ShowDialog();
            }
        }

        /// <summary>
        /// Rukuje događajem promijena teksta te provjerava dali je korisničko ime dostupno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            if (Korisnik.ProvjeriDostupnostKorisnickogImena(txtKorisnickoIme.Text) == false)
            {
                txtKorisnickoIme.BackColor = Color.Red;
            }
            else
            {
                txtKorisnickoIme.BackColor = Color.Green;
            }
        }
        /// <summary>
        /// Metoda koja provjerava dali je lozinka ispravnog formata
        /// </summary>
        /// <param name="lozinka"> Lozinka koja se provjerava</param>
        /// <returns></returns>
        private bool provjeraLozinke(string lozinka)
        {
            if (lozinka.Length < 8 || lozinka.Any(char.IsDigit) == false || lozinka.Any(char.IsUpper) == false)
            {
                txtLozinka.BackColor = Color.Red;
                return false;
            }
            else
            {
                txtLozinka.BackColor = Color.Green;
                return true;
            }

        }
        /// <summary>
        /// Rukuje događajem promijene teksta te provjerava dali je lozinka ispravnog formata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            provjeraLozinke(txtLozinka.Text);
        }
        /// <summary>
        /// Rukuje događajem promjena teksta te prilikom promijene teksta provjerava da li postoji korisnik sa tim OIB-om
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOIB_TextChanged(object sender, EventArgs e)
        {
            if (txtOIB.Text.Length == 11)
            {
                if (Korisnik.ProvjeriDostupnostOIB(txtOIB.Text) == false)
                {
                    txtOIB.BackColor = Color.Red;
                }
                else
                {
                    txtOIB.BackColor = Color.Green;
                }
            }
            else
            {
                txtOIB.BackColor = default(Color);
            }
        }
        /// <summary>
        /// Rukuje događajem klika na gumb za registraciju korisnika te provjerava dali su svi podaci uneseni, da li već postoji korisničko ime, da li je lozinka ispravnog formata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            if (txtOIB.Text != "" && txtIme.Text != "" && txtPrezime.Text != "" && txtKorisnickoIme.Text != "" && txtLozinka.Text != "" && dtpDatumRodenja.Text != "" && txtAdresa.Text != "" && txtMail.Text != "" && txtIBAN.Text != "" && cmbTipKorisnika.SelectedValue != null)
            {
                if (Korisnik.ProvjeriDostupnostKorisnickogImena(txtKorisnickoIme.Text) == true && provjeraLozinke(txtLozinka.Text) == true && Korisnik.ProvjeriDostupnostOIB(txtOIB.Text) == true)
                {
                    int tipKorisnika = int.Parse(cmbTipKorisnika.SelectedValue.ToString());
                    Korisnik korisnik = new Korisnik
                    {
                        KorisnikID = txtOIB.Text,
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Lozinka = txtLozinka.Text,
                        DatumRodenja = dtpDatumRodenja.Value.Date,
                        Adresa = txtAdresa.Text,
                        Mobitel = txtMobitel.Text,
                        Telefon = txtTelefon.Text,
                        Mail = txtMail.Text,
                        IBAN = txtIBAN.Text,
                        TipKorisnika = tipKorisnika

                    };
                    Korisnik.DodajKorisnika(korisnik);
                    if (Korisnik.PrijavljeniKorisnik == null)
                    {
                        frmPrijava prijava = new frmPrijava();
                        this.Close();

                    }
                    else
                    {
                        frmIzbornik izbornik = new frmIzbornik();
                        this.Close();
                      
                    }
                }
                else if (Korisnik.ProvjeriDostupnostKorisnickogImena(txtKorisnickoIme.Text) == false)
                {
                    MessageBox.Show("Korisničko ime koje ste unjeli već postoji", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (provjeraLozinke(txtLozinka.Text) == false)
                {
                    MessageBox.Show("Lozinka ne smije biti kraća od 8 znakova i mora sadržavati barem jedno veliko slovo i jednu znamenku", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Korisnik.ProvjeriDostupnostOIB(txtOIB.Text) == false)
                {
                    MessageBox.Show("OIB korisnika ima 11 znakova", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nisu ispunjeni svi podaci za registraciju", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Rukuje događajem klika na gumb. Prilikom klika zatvara formu frmRezervacija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
