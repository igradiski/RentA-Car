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
    public partial class frmRezervacije : Form
    {
        private int sifraRezervacije { get; set; }
        /// <summary>
        /// Osvježava sadržaj DataGridView-a dgvRezervacije.
        /// </summary>
        private void prikaziRezervacije()
        {
            voziloBindingSource.DataSource = Vozilo.DohvatiVozila();
            korisnikBindingSource.DataSource = Korisnik.DohvatiSveKorisnike();
            rezervacijaBindingSource.DataSource = Rezervacija.DohvatiSveRezervacije();
            dgvRezervacije.DataSource = rezervacijaBindingSource;
            btnDodaj.Visible = true;
            btnPromijeni.Visible = true;
            btnOtkazi.Visible = true;

        }
        /// <summary>
        /// Konstruktor klase frmRezervacije.
        /// </summary>
        public frmRezervacije()
        {
            InitializeComponent();
            if (Korisnik.PrijavljeniKorisnik.TipKorisnika == 2)
            {
                prikaziRezervacije();
            }
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            this.prikaziRezervacije();
        }

        /*
         * Rukuje događajem klika na gumb btnOtkazi.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnOtkazi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Rezervacija rezervacijaZaOtkazivanje = (Rezervacija)rezervacijaBindingSource.Current;
            using(RentACarEntities db=new RentACarEntities())
            {
                db.Rezervacija.Attach(rezervacijaZaOtkazivanje);
                db.Rezervacija.Remove(rezervacijaZaOtkazivanje);
                db.SaveChanges();
            }
            prikaziRezervacije();
        }

        /*
         * Rukuje događajem klika na gumb btnDodaj. Sakriva formu frmRezervacije i otvara formu frmDodajPromijeniRezervaciju.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnDodaj. Sakriva formu frmRezervacije i otvara formu frmDodajPromijeniRezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajPromijeniRezervaciju frmDodajRezervaciju = new frmDodajPromijeniRezervaciju();
            this.Hide();
            frmDodajRezervaciju.ShowDialog();
            this.Show();
        }
        /*
         * Rukuje događajem klika na gumb btnPromijeni. Sakriva formu frmRezervacije i otvara formu frmDodajPromijeniRezervaciju.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnPromijeni. Sakriva formu frmRezervacije i otvara formu frmDodajPromijeniRezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            Rezervacija rezervacija = (Rezervacija)rezervacijaBindingSource.Current;
            frmDodajPromijeniRezervaciju frmDodajPromijeniRezervaciju = new frmDodajPromijeniRezervaciju(rezervacija);
            this.Hide();
            frmDodajPromijeniRezervaciju.ShowDialog();
            this.Show();
            prikaziRezervacije();
        }
    }
}
