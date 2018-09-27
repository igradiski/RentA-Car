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
    public partial class frmPregledIznajmljivanja : Form
    {
        private int sifraRacuna { get; set; }
        public double UkupnaSuma { get; set; }

        /// <summary>
        /// Konstruktor klase frmPregledIznajmljivanja.cs. Popunjava DataGridView dgv PregledIznajmljivanja.
        /// </summary>
        /// <param name="sifraRacuna"></param>
        public frmPregledIznajmljivanja(int sifraRacuna)
        {
            InitializeComponent();
            voziloBindingSource.DataSource = Vozilo.DohvatiVozila();
            korisnikBindingSource.DataSource = Korisnik.DohvatiSveKorisnike();
            iznajmljivanjeBindingSource.DataSource = Iznajmljivanje.DohvatiIznajmljivanjaZaRacun();
            this.sifraRacuna = sifraRacuna;
        }
        /// <summary>
        /// Rukuje događajem klika na gumb btnDodajStavku. Sprema parametre u varijable i zatvara formu frmPregledIznajmljivanja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            Iznajmljivanje iznajmljivanje = (Iznajmljivanje)iznajmljivanjeBindingSource.Current;

            if (iznajmljivanje != null)
            {
                using (RentACarEntities db = new RentACarEntities())
                {
                    db.Iznajmljivanje.Attach(iznajmljivanje);
                    iznajmljivanje.RacunID = this.sifraRacuna;
                    iznajmljivanje.Naplaceno = true;
                    UkupnaSuma = iznajmljivanje.BrojDana * iznajmljivanje.JedinicnaCijena;
                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
