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
    public partial class frmMjesecniPregledRezervacija : Form
    {
        /// <summary>
        /// Konstruktor forem koji služi za inicijalizaciju komponenti
        /// </summary>
        public frmMjesecniPregledRezervacija()
        {
            InitializeComponent();
            dtpMjesec.Format = DateTimePickerFormat.Custom;
            dtpMjesec.CustomFormat = "MMMM yyyy";
            dtpMjesec.ShowUpDown = true;
        }
        /// <summary>
        /// Metoda koja osvježava prikaz rezervacija u osisnsti o mjesecu koji je izabran
        /// </summary>
        private void osvjeziPrikazRezervacija()
        {
            if (dtpMjesec.Value != null)
            {
                rezervacijaBindingSource.DataSource = Rezervacija.DohvatiRezervacijePoDatumu(dtpMjesec.Value.Date);
                korisnikBindingSource.DataSource = Korisnik.DohvatiKorisnike();
                voziloBindingSource.DataSource = Vozilo.DohvatiVozila();
            }
        }
        /// <summary>
        /// Rukuje događajem promjena vrijednosti DateTimePickera te mijenja rezervacije u ovisnosti o vrijednost DateTimePickera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMjesec_ValueChanged(object sender, EventArgs e)
        {
            osvjeziPrikazRezervacija();
        }
        /// <summary>
        /// Rukuje događajem pokretanje forme koja osvježava prikaz rezervacija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMjesecniPregledRezervacija_Load(object sender, EventArgs e)
        {
            osvjeziPrikazRezervacija();
            this.KeyPreview = true;
            this.KeyUp += frmMjesecniPregledRezervacija_KeyUp;
        }
        /// <summary>
        /// Rukuje događajem pritiska tipke na tipkovnici. Ako se pritisne tipka F1 otvara se forma frmPomoc koja služi za pomoć u navigaciji kroz aplikaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMjesecniPregledRezervacija_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Pritisnuli ste F1 na frmMjesecniPregeld rezervacija. Na formi za pregled mjesečnih rezervacija možemo vidjeti 3 elementa, jedan je element gore u sredini u njemu možemo mijenjati mjesec i godinu i u ovisnosti o promjeni na tabičnom prikazu se mijenjaju podaci o rezervaciji koji su se dogodili u izabranom mjesecu. Klikom na gumb Natrag vraćamo se na izbornik. Korisničku pomoć možemo dobiti pritiskom F1 tipke na tipkovnici.";
                pomoc.ShowDialog();
            }
        }
        /// <summary>
        /// Rukuje događajem klika gumba. Ako se pritisne gumb btnNatrag zatvara se forma frmMjesecniPregledRezervacija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
