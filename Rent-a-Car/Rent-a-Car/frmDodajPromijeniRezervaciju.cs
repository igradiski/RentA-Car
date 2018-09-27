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
    public partial class frmDodajPromijeniRezervaciju : Form
    {
        private int sifraRezervacije { get; set; }

        /// <summary>
        /// Rukuje događajem pokretanja forme frmDodajRezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajRezervaciju_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp += frmDodajPromijeniRezervaciju_KeyUp;
            if (Korisnik.PrijavljeniKorisnik.TipKorisnika == 2 || Korisnik.PrijavljeniKorisnik.TipKorisnika==4)
            {
                txtOIB.Enabled = true;
                txtIme.Enabled = true;
                txtPrezime.Enabled = true;
            }
            else
            {
                txtOIB.Enabled = false;
                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                txtOIB.Text = Korisnik.PrijavljeniKorisnik.KorisnikID;
                txtIme.Text = Korisnik.PrijavljeniKorisnik.Ime;
                txtPrezime.Text = Korisnik.PrijavljeniKorisnik.Prezime;
            }
        }

        /// <summary>
        /// Kontruktor forme frmDodajPromijeniRezervaciju. Inicijalizira komponente.
        /// </summary>
        public frmDodajPromijeniRezervaciju()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor klase. Inicijalizira komponente.
        /// </summary>
        /// <param name="rezervacija"></param>
        public frmDodajPromijeniRezervaciju(Rezervacija rezervacija)
        {
            this.sifraRezervacije = rezervacija.RezervacijaID;
            InitializeComponent();
            Korisnik korisnik = null;
            Vozilo vozilo = null;
            TipMotora tipMotora = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                korisnik = (from k in db.Korisnik where k.KorisnikID == rezervacija.KorisnikID select k).First();
                vozilo = (from v in db.Vozilo where v.VoziloID == rezervacija.VoziloID select v).First();
                tipMotora = (from t in db.TipMotora where t.TipMotoraID == vozilo.TipMotoraID select t).First();
            }
            txtOIB.Text = korisnik.KorisnikID;
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            dtpDatumIVrijemePocetka.Value = rezervacija.DatumPocetka;
            dtpDatumIVrijemeKraja.Value = rezervacija.DatumKraja;
            txtRegistracija.Text = vozilo.VoziloID;
            txtModel.Text = vozilo.Naziv;
            txtTip.Text = tipMotora.Naziv;
            txtSnagaMotora.Text = vozilo.SnagaMotora.ToString();
            txtBrojSjedala.Text = vozilo.BrojSjedala.ToString();
            txtNapomena.Text = rezervacija.Opis;
            txtCijenaPoDanu.Text = vozilo.CijenaPoDanu.ToString();
            txtBrojDana.Text = (dtpDatumIVrijemeKraja.Value - dtpDatumIVrijemePocetka.Value).Days.ToString();
            txtUkupnaCijena.Text = (double.Parse(txtCijenaPoDanu.Text) * double.Parse(txtBrojDana.Text)).ToString();
            txtPDV.Text = (double.Parse(txtUkupnaCijena.Text) * 0.25).ToString();
            txtCijenaSPDV.Text = (double.Parse(txtUkupnaCijena.Text) + double.Parse(txtPDV.Text)).ToString();
            btnRezerviraj.Text = "Promijeni";
            btnRezerviraj.Click += btnRezerviraj_Click1;
        }
        /*
         * Rukuje događajem promijene vrijednosti DateTimePickera dtpDatumIVrijemePocetka. Prilikom promijene vrijednosti dtpDatumIVrijemePocetka mijenja vrijednost textboxa txtBrojDana.
         */
        /// <summary>
        /// Rukuje događajem promijene vrijednosti DateTimePickera dtpDatumIVrijemePocetka. Prilikom promijene vrijednosti dtpDatumIVrijemePocetka mijenja vrijednost textboxa txtBrojDana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDatumIVrijemePocetka_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumIVrijemePocetka.Value != DateTime.Parse("1.1.2000.") && dtpDatumIVrijemeKraja.Value != DateTime.Parse("1.1.2000."))
            {
                txtBrojDana.Text = (dtpDatumIVrijemeKraja.Value - dtpDatumIVrijemePocetka.Value).Days.ToString();
            }
        }
        /*
         * Rukuje događajem promijene vrijednosti DateTimePickera dtpDatumIVrijemeKraja. Prilikom promijene vrijednosti dtpDatumIVrijemeKraja mijenja vrijednost textboxa txtBrojDana.
         */
        /// <summary>
        /// Rukuje događajem promijene vrijednosti DateTimePickera dtpDatumIVrijemeKraja. Prilikom promijene vrijednosti dtpDatumIVrijemeKraja mijenja vrijednost textboxa txtBrojDana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDatumIVrijemeKraja_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatumIVrijemePocetka.Value != DateTime.Parse("1.1.2000.") && dtpDatumIVrijemeKraja.Value != DateTime.Parse("1.1.2000."))
            {
                txtBrojDana.Text = (dtpDatumIVrijemeKraja.Value - dtpDatumIVrijemePocetka.Value).Days.ToString();
            }
        }
        /*
         * Rukuje događajem klika na gumb btnPregledDostupnihVozila. Prilikom klika na gumb sakriva formu frmDodajRezervaciju i otvara formu frmPregledDostupnihVozila.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnPregledDostupnihVozila. Prilikom klika na gumb sakriva formu frmDodajRezervaciju i otvara formu frmPregledDostupnihVozila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPregledDostupnihVozila_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(this.dtpDatumIVrijemePocetka.Value, new DateTime(2000, 1, 1, 0, 0, 0)) == 0)
            {
                MessageBox.Show("Niste odabrali datum početka!");
            }
            else if (DateTime.Compare(this.dtpDatumIVrijemeKraja.Value, new DateTime(2000, 1, 1, 0, 0, 0)) == 0)
            {
                MessageBox.Show("Niste odabrali datum kraja!");
            }
            else if (DateTime.Compare(this.dtpDatumIVrijemePocetka.Value, DateTime.Now) < 0)
            {
                MessageBox.Show("Pogreška kod datuma početka!");
            }
            else if (DateTime.Compare(this.dtpDatumIVrijemeKraja.Value, dtpDatumIVrijemePocetka.Value) <= 0)
            {
                MessageBox.Show("Pogreška kod datuma kraja!");
            }
            else
            {
                frmPregledDostupnihVozila frmPregledDostupnihVozila = new frmPregledDostupnihVozila(this.dtpDatumIVrijemePocetka.Value, this.dtpDatumIVrijemeKraja.Value);
                this.Hide();
                frmPregledDostupnihVozila.ShowDialog();
                this.Show();
                Vozilo odabranoVozilo = frmPregledDostupnihVozila.OdabranoVozilo;
                if (odabranoVozilo != null)
                {
                    TipMotora tipMotora = null;
                    using (RentACarEntities db = new RentACarEntities())
                    {
                        tipMotora = (from t in db.TipMotora where t.TipMotoraID == odabranoVozilo.TipMotoraID select t).FirstOrDefault();
                    }

                    txtRegistracija.Text = odabranoVozilo.VoziloID.ToString();
                    txtModel.Text = odabranoVozilo.Naziv;
                    txtTip.Text = tipMotora.Naziv;
                    txtSnagaMotora.Text = odabranoVozilo.SnagaMotora.ToString();
                    txtBrojSjedala.Text = odabranoVozilo.BrojSjedala.ToString();
                    txtCijenaPoDanu.Text = odabranoVozilo.CijenaPoDanu.ToString();
                    txtBrojDana.Text = ((dtpDatumIVrijemeKraja.Value - dtpDatumIVrijemePocetka.Value).Days).ToString();
                    txtUkupnaCijena.Text = (int.Parse(txtBrojDana.Text) * double.Parse(txtCijenaPoDanu.Text)).ToString();
                    txtPDV.Text = (double.Parse(txtUkupnaCijena.Text) * 0.25).ToString();
                    txtCijenaSPDV.Text = ((double.Parse(txtUkupnaCijena.Text) * 0.25) + double.Parse(txtUkupnaCijena.Text)).ToString();
                }

                
            }
        }
        /// <summary>
        /// Rukuje događajem klika na gumb btnRezerviraj. Provjerava popunjenost obrasca, te sprema rezervaciju u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (txtRegistracija.Text == "")
            {
                MessageBox.Show("Niste odabrali vozilo!");
            }
            else
            {
                if(DateTime.Compare(dtpDatumIVrijemePocetka.Value, DateTime.Today.AddDays(1)) == 0)
                {
                    Iznajmljivanje iznajmljivanje = new Iznajmljivanje();
                    iznajmljivanje.KlijentID = txtOIB.Text;
                    iznajmljivanje.VoziloID = txtRegistracija.Text;
                    iznajmljivanje.DatumPocetka = dtpDatumIVrijemePocetka.Value;
                    iznajmljivanje.DatumKraja =dtpDatumIVrijemeKraja.Value;
                    iznajmljivanje.BrojDana = int.Parse((dtpDatumIVrijemeKraja.Value - dtpDatumIVrijemePocetka.Value).Days.ToString());
                    iznajmljivanje.DjelatnikID = Korisnik.PrijavljeniKorisnik.KorisnikID;
                    iznajmljivanje.JedinicnaCijena = double.Parse(txtCijenaPoDanu.Text);
                    iznajmljivanje.Naplaceno = false;
                    Vozilo vozilo = null;
                    TipMotora tipMotora = null;
                    using(RentACarEntities db=new RentACarEntities())
                    {
                        vozilo = (from v in db.Vozilo where v.VoziloID == txtRegistracija.Text select v).FirstOrDefault();
                        tipMotora = (from tm in db.TipMotora where tm.TipMotoraID == vozilo.TipMotoraID select tm).FirstOrDefault();
                    }
                    iznajmljivanje.Naziv = vozilo.Naziv+" "+tipMotora.Naziv;
                    iznajmljivanje.Opis = "Iznajmljivanje vozila " + iznajmljivanje.Naziv + " na " + iznajmljivanje.BrojDana.ToString() + " dana s cijenom od " + iznajmljivanje.JedinicnaCijena.ToString() + "kn po danu.";
                    iznajmljivanje.UkupnaCijena = iznajmljivanje.BrojDana * iznajmljivanje.JedinicnaCijena;
                    iznajmljivanje.RacunID = null;
                    using(RentACarEntities db=new RentACarEntities())
                    {
                        db.Iznajmljivanje.Add(iznajmljivanje);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Iznajmljivanje vozila obavljeno!");
                }
                else
                {
                    Rezervacija rezervacija = new Rezervacija();
                    rezervacija.KorisnikID = txtOIB.Text;
                    rezervacija.DatumPocetka = dtpDatumIVrijemePocetka.Value;
                    rezervacija.DatumKraja = dtpDatumIVrijemeKraja.Value;
                    rezervacija.DatumRezervacije = DateTime.Now;
                    rezervacija.VoziloID = txtRegistracija.Text;
                    rezervacija.Opis = txtNapomena.Text;
                    rezervacija.JedinicnaCijena = double.Parse(txtCijenaPoDanu.Text);
                    rezervacija.BrojDana = int.Parse(txtBrojDana.Text);
                    using (RentACarEntities db = new RentACarEntities())
                    {
                        db.Rezervacija.Add(rezervacija);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Rezervacija vozila obavljena!");
                }
                
            }
            
            this.Close();
        }
        /// <summary>
        /// Rukuje događajem klika na gumb btnRezerviraj. Sprema promijene na rezervaciji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRezerviraj_Click1(object sender, EventArgs e)
        {
            Rezervacija rezervacija = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                rezervacija = (from r in db.Rezervacija where r.RezervacijaID == this.sifraRezervacije select r).First();
            }
            using (RentACarEntities db = new RentACarEntities())
            {
                db.Rezervacija.Attach(rezervacija);
                rezervacija.KorisnikID = txtOIB.Text;
                rezervacija.DatumPocetka = dtpDatumIVrijemePocetka.Value;
                rezervacija.DatumKraja = dtpDatumIVrijemeKraja.Value;
                rezervacija.VoziloID = txtRegistracija.Text;
                rezervacija.Opis = txtNapomena.Text;
                db.SaveChanges();
            }
            this.Close();
        }
        /// <summary>
        /// Rukuje događajem otpuštanja pritisnutog gumba F1 na formi frmDodajPromijeniRezervaciju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajPromijeniRezervaciju_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "Trenutno ste pritisnuli F1 na formi Kreiraj ili promijeni rezervaciju.\n\nNa formi Kreiraj ili promijeni rezervaciju možete vidjeti pet grupa za unos podataka " +
                    ", te jedan gumb ''Rezerviraj'' ili ''Promijeni'' ovisno o tome kreirate li novu ili mijenjate postojeću rezervaciju. Ukoliko mijenjate rezervaciju," +
                    " možete mijenjati datum početka rezervacije, datum kraja rezervacije, napomenu i vozilo koje želite rezervirati. Ukoliko kreirate rezervaciju, možete " +
                    "popunjavati također ta ista polja. Prilikom klika na gumb ''Pregled dostupnih vozila'' otvara vam se prozor u kojem su prikazani podaci o dostupnim vozilima" +
                    "za definirane datume početka i kraja rezervacije, te na kojem možete odabrati vozilo koje želite rezervirati.\n\n " +
                    "Klikom na gumb ''Rezerviraj'' provjerava se popunjenost obrasca podacima i ake je sve popunjeno na ispravan način, izvršava se Vaša rezervacija, a inače se pojavljuje" +
                    "poruka o pogrešno popunjenim poljima.";
                pomoc.ShowDialog();
            }

        }
        /// <summary>
        /// Rukuje događajem pritiska tipke u polju txtOIB. Provjerava je li svih 11 znamenaka uneseno, te postoji li korisnik s tim OIB-om u bazi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOIB_TextChanged(object sender, EventArgs e)
        {
            if (txtOIB.Text.Length == 11)
            {
                string oib = txtOIB.Text;
                Korisnik korisnik = null;
                using(RentACarEntities db=new RentACarEntities())
                {
                    korisnik = (from k in db.Korisnik where k.KorisnikID == oib select k).FirstOrDefault();
                }
                if (korisnik == null)
                {
                    MessageBox.Show("Ne postoji korisnik s tim OIB-om!");
                }
                else
                {
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                }
            }
            else
            {
                txtIme.Text = "";
                txtPrezime.Text = "";
            }
        }
    }
}
