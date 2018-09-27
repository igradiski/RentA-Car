using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Rent_a_Car
{
    public partial class frmIzdavanjeRacuna : Form
    {
        private int sifraRacuna { get; set; }

        private double UkupnaSumaRacuna { get; set; }
        /// <summary>
        /// Konstruktor klase. Inicijalizira komponente.
        /// </summary>
        public frmIzdavanjeRacuna()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rukuje događajem učitavanja forme frmIzdavanjeRacuna. Popunjava polja podacima o trenutno prijavljenom djelatniku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIzdavanjeRacuna_Load(object sender, EventArgs e)
        {
            using(RentACarEntities db=new RentACarEntities())
            {
                Racun racun = new Racun();
                racun.Djelatnik = Korisnik.PrijavljeniKorisnik.KorisnikID;
                racun.DatumRacuna = DateTime.Now;
                racun.IznosRacuna = 0;
                db.Racun.Add(racun);
                db.SaveChanges();
                this.sifraRacuna = racun.RacunID;
            }
            string djelatnik = Korisnik.PrijavljeniKorisnik.Ime + " " + Korisnik.PrijavljeniKorisnik.Prezime;
            ReportParameterCollection parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("DatumIVrijeme", DateTime.Now.ToString()));
            parametri.Add(new ReportParameter("Djelatnik", djelatnik));
            parametri.Add(new ReportParameter("RacunBr", sifraRacuna.ToString()));
            this.rpvRacun.LocalReport.SetParameters(parametri);
            this.rpvRacun.RefreshReport();
        }


        /// <summary>
        /// Rukuje događajem klika na gumb btnRegistracija. Sakriva formu frmIzdavanjeRacuna i otvara formu frmPopisIznajmljivanja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            frmPregledIznajmljivanja frmPregledIznajmljivanja = new frmPregledIznajmljivanja(this.sifraRacuna);
            this.Hide();
            frmPregledIznajmljivanja.ShowDialog();
            this.Show();
            UkupnaSumaRacuna += frmPregledIznajmljivanja.UkupnaSuma;
            this.IznajmljivanjeTableAdapter.FillByRacunID(this.dtsRacun.Iznajmljivanje, this.sifraRacuna);
            this.rpvRacun.RefreshReport();
        }
        /// <summary>
        /// Rukuje događajem klika na gumb btnIzdajRacun. Prilikom klika na gumb sprema podatke o ukupnoj cijeni računa u bazu i zatvara formu frmIzdajRacun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            Racun racun = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                racun = (from r in db.Racun where r.RacunID == sifraRacuna select r).First();
                db.Racun.Attach(racun);
                racun.IznosRacuna = this.UkupnaSumaRacuna;
                db.SaveChanges();
            }
        }
    }
}
