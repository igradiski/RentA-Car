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
    public partial class frmIzbornik : Form
    {
        public frmIzbornik()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click_1(object sender, EventArgs e)
        {
            frmRegistracija FrmRegistracija = new frmRegistracija();
            this.Hide();
            FrmRegistracija.ShowDialog();
            this.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmRezervacije frmRezervacije = new frmRezervacije();
            this.Hide();
            frmRezervacije.ShowDialog();
            this.Show();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            frmVozila frmVozila = new frmVozila();
            this.Hide();
            frmVozila.ShowDialog();
            this.Show();
        }

        private void btnPovratneInformacije_Click(object sender, EventArgs e)
        {
            if ((Korisnik.PrijavljeniKorisnik.TipKorisnika == 2))
            {

                PregledFeedbackova pregled = new PregledFeedbackova();
                this.Hide();
                pregled.ShowDialog();
                this.Show();
            }
            else
            {
                frmPovratnaInformacijaKorisnik pov = new frmPovratnaInformacijaKorisnik();
                this.Hide();
                pov.ShowDialog();
                this.Show();
            }

            
        }

        private void btnIznajmljivanje_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Rukuje događajem klika na gumb btnIzdavanjeRacuna. Sakriva formu frmIzbornik i otvara formu frmIzdavanjeRacuna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            frmIzdavanjeRacuna frmIzdavanjeRacuna = new frmIzdavanjeRacuna();
            this.Hide();
            frmIzdavanjeRacuna.ShowDialog();
            this.Show();
        }

        private void btnPovijestIznajmljivanja_Click(object sender, EventArgs e)
        {
            

                frmPovijestIznajmljivanja pov = new frmPovijestIznajmljivanja();
                this.Hide();
                pov.ShowDialog();
                this.Show();
           
            
        }

        private void btnPlaniranjeObracun_Click(object sender, EventArgs e)
        {
            frmObracunPlacePregledSmjena obracun = new frmObracunPlacePregledSmjena();
            this.Hide();
            obracun.ShowDialog();
            this.Show();
        }

        /*
         * Rukuje događajem klika na gumb btnMojeRezervaicje. Prilikom klika na gumb sakriva se forma frmIzbornik i otvara forma frmPregledMojihRezervacija.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnMojeRezervaicje. Prilikom klika na gumb sakriva se forma frmIzbornik i otvara forma frmPregledMojihRezervacija.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMojeRezervacije_Click(object sender, EventArgs e)
        {
            frmPregledMojihRezervacija frmPregledMojihRezervacija = new frmPregledMojihRezervacija();
            this.Hide();
            frmPregledMojihRezervacija.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Rukuje događajem klika na gumb. Prilikom klika otvara formu frmMjesecniPregledRezervacija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMjesecniPregledRezervacija_Click(object sender, EventArgs e)
        {
            frmMjesecniPregledRezervacija mjesecniPregledRezervacija = new frmMjesecniPregledRezervacija();
            this.Hide();
            mjesecniPregledRezervacija.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Rukuje događajem klik gumba. Prilikom klika na gumb btnOdjava zatvara se frmIzbornik i otvara frmPrijava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            Korisnik.PrijavljeniKorisnik = null;
        }
        /*
         * Rukuje događajem klika na gumb btnKreirajRezervaciju. Prilikom klika na gumb sakriva se forma frmIzbornik i otvara forma frmDodajRezervaciju.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnKreirajRezervaciju. Prilikom klika na gumb sakriva se forma frmIzbornik i otvara forma frmDodajRezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKreirajRezervaciju_Click(object sender, EventArgs e)
        {
            frmDodajPromijeniRezervaciju frmDodajRezervaciju = new frmDodajPromijeniRezervaciju();
            this.Hide();
            frmDodajRezervaciju.ShowDialog();
            this.Show();
        }

        private void frmIzbornik_Load(object sender, EventArgs e)
        {
            if (Korisnik.PrijavljeniKorisnik.TipKorisnika == 1)
            {
                btnRegistracija.Hide();
                btnVozila.Hide();
                btnPlaniranjeObracun.Hide();
                btnPovijestIznajmljivanja.Hide();
                btnMjesecniPregledRezervacija.Hide();
            }

            if (Korisnik.PrijavljeniKorisnik.TipKorisnika == 2 || Korisnik.PrijavljeniKorisnik.TipKorisnika == 4)
            {
                btnRezervacije.Visible = true;
                btnKreirajRezervaciju.Visible = false;
                btnIzdavanjeRacuna.Visible = true;
                pokretanjeStopiranjeServisa();
              
            }
            else
            {
                btnRezervacije.Visible = false;
                btnKreirajRezervaciju.Visible = true;
                btnIzdavanjeRacuna.Visible = false;
            }

            if(Korisnik.PrijavljeniKorisnik.TipKorisnika==3 || Korisnik.PrijavljeniKorisnik.TipKorisnika ==4 )
            {
                btnPlaniranjeObracun.Hide();
                btnPovijestIznajmljivanja.Hide();
            }
        }
        /// <summary>
        /// Prikazuje formu za pokretanje i stopiranje servisa.
        /// </summary>
        private void pokretanjeStopiranjeServisa()
        {
            frmPokretanjeStopiranjeServisa frmPokretanjeStopiranjeServisa = new frmPokretanjeStopiranjeServisa();
            this.Hide();
            frmPokretanjeStopiranjeServisa.ShowDialog();
            this.Show();
        }
    }
}
