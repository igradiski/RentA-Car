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
    public partial class frmPregledSmjena : Form
    {
        private DateTime datum;
        /// <summary>
        /// Konstruktor klase
        /// </summary>
        /// <param name="trenutniDatum"></param>
        public frmPregledSmjena(DateTime trenutniDatum)
        {
            InitializeComponent();
            this.Text = "Pregled smjena";
            datum = trenutniDatum;
            lblPrikazDatuma.Text = datum.ToString();
        }

        /// <summary>
        /// metoda koja puni i dohvaca sve potrebne podatke za normalan rad forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPregledSmjena_Load(object sender, EventArgs e)
        {
            
            lstUjutro.DataSource = Radi.listaRadnika(1, datum);
            lstPopodne.DataSource = Radi.listaRadnika(2, datum);
            if (Radi.listaRadnika(1, datum) != null)
            {
                txtUjutroBroj.Text = Radi.listaRadnika(1, datum).Count.ToString();
            }
            if (Radi.listaRadnika(2, datum) != null)
            {
                txtPopodneBroj.Text = Radi.listaRadnika(2, datum).Count.ToString();
            }
            lstUjutro.DisplayMember = "Prezime";
            lstPopodne.DisplayMember = "Prezime";
            lstUjutro.ValueMember = "KorisnikID";
            lstPopodne.ValueMember = "KorisnikID";
            cmbZaposlenikUjutro.DataSource = Korisnik.dohvatiRadnike(4);
            cmbZaposlenikPopodne.DataSource = Korisnik.dohvatiRadnike(4);
            cmbZaposlenikPopodne.ValueMember = "KorisnikID";
            cmbZaposlenikUjutro.ValueMember = "KorisnikID";
            cmbZaposlenikUjutro.DisplayMember = "Prezime";
            cmbZaposlenikPopodne.DisplayMember = "Prezime";
            this.KeyPreview = true;
           // this.KeyUp += frmPregledSmjena_KeyUp;
        }

        /// <summary>
        /// Metoda za dodavanje zaposlenika u smjenu
        /// </summary>
        private void dodajZaposlenikaUjutro()
        {
            Radi radi = new Radi
            {

                DjelatnikID = cmbZaposlenikUjutro.SelectedValue.ToString(),
                SmjenaID = 1,
                Datum = datum
            };
            Radi.DodajRadnikaSmjeni(radi);
            lstUjutro.DataSource = Radi.listaRadnika(1, datum);
            MessageBox.Show("Dodali ste radnika jutarnjoj smjeni");
            lstUjutro.Refresh();
            if (Radi.listaRadnika(1, datum) != null)
            {
                txtUjutroBroj.Text = Radi.listaRadnika(1, datum).Count.ToString();
            }

        }
        /// <summary>
        /// metoda za dodavanje zaposlenika u smjenu
        /// </summary>
        private void dodajZaposlenikaPopodne()
        {
            Radi radi = new Radi
            {

                DjelatnikID = cmbZaposlenikPopodne.SelectedValue.ToString(),
                SmjenaID = 2,
                Datum = datum
            };
            Radi.DodajRadnikaSmjeni(radi);
            lstPopodne.DataSource = Radi.listaRadnika(2, datum);
            MessageBox.Show("Dodali ste radnika popodnevnoj smjeni");
            lstPopodne.Refresh();
            if (Radi.listaRadnika(2, datum) != null)
            {
                txtPopodneBroj.Text = Radi.listaRadnika(2, datum).Count.ToString();
            }


        }
        /// <summary>
        /// Metoda koja na klik dodaje radnika u smjenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajUjutro_Click(object sender, EventArgs e)
        {
            dodajZaposlenikaUjutro();
        }
        /// <summary>
        /// Metoda brise zaposlenika iz smjene
        /// </summary>
        private void brisiZaposlenikaSmjeneJutro()
        {
            Radi.BrisanjeRadaUSmjeni(1, datum, lstUjutro.SelectedValue.ToString());
            lstUjutro.DataSource = Radi.listaRadnika(1, datum);
            MessageBox.Show("Obrisali ste radnika iz smjene!");
            lstUjutro.Refresh();
            if (Radi.listaRadnika(1, datum) != null)
            {
                txtUjutroBroj.Text = Radi.listaRadnika(1, datum).Count.ToString();
            }
        }
        /// <summary>
        /// Metoda za brisanje zaposlenika iz smjene
        /// </summary>
        private void brisiZaposlenikaSmjenePopodne()
        {
            Radi.BrisanjeRadaUSmjeni(2, datum, lstPopodne.SelectedValue.ToString());
            lstPopodne.DataSource = Radi.listaRadnika(2, datum);
            MessageBox.Show("Obrisali ste radnika iz smjene!");
            lstPopodne.Refresh();
            if (Radi.listaRadnika(2, datum) != null)
            {
                txtPopodneBroj.Text = Radi.listaRadnika(2, datum).Count.ToString();
            }
        }
        /// <summary>
        /// Gumb za micanje zaposlenika iz smjene
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakniUjutro_Click(object sender, EventArgs e)
        {
            brisiZaposlenikaSmjeneJutro();
        }
        /// <summary>
        /// gumb za micanje zaposlenika iz smjene
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakniPopodne_Click(object sender, EventArgs e)
        {
            brisiZaposlenikaSmjenePopodne();
        }
        /// <summary>
        /// gumb za dodavanje zaposlenika u smjenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajPopodne_Click(object sender, EventArgs e)
        {
            dodajZaposlenikaPopodne();
        }
        /// <summary>
        /// Metoda koja poziva pomoc na formi klikom na f1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPregledSmjena_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += " Forma za pregled smjena ima dva dijela, a to su jutarnji i popodnevni dio \n"+
                " Izgledom su jednaki samo je svaki za svoju smjenu \n" +
            "  Automatski se ispisuje broj radnika u smjeni ako ih ima \n" +
            "  te se ispisuju radnici koji rade zbog bolje preglednosti \n" +
            "   ispod toga slijedi padajuci izbornik s svim radnicima u poduzecu\n" +
            "   te su tamo gumbi za dodavanje i micanje ovisno o zelji i potrebi \n" +
            "  Klikom na gumb dodaje se ili mice radnik, ali za unesene \n" +
            "  promjene treba ponovno otvoriti formu zbog osvjezavanja baze\n" +
            "  a s tim i pogleda\n" +
            "  NAPOMENA: radnik ne moze radi u dvije smjene isti dan i aplikacija ce baciti gresku\n" +
            "    takoder na vrhu pise datum za koji se unose radnici u smjenu\n" ;
                pomoc.ShowDialog();
            }
        }

        private void lstUjutro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
