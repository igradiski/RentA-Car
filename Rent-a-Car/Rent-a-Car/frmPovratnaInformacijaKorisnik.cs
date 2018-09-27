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
    public partial class frmPovratnaInformacijaKorisnik : Form
    {
        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public frmPovratnaInformacijaKorisnik()
        {
            InitializeComponent();
            this.Text = "Dodaj povratnu informaciju";
        }
        /// <summary>
        /// Funkcija na load koja puni formu s potrebnim informacijama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPovratnaInformacijaKorisnik_Load(object sender, EventArgs e)
        {
            lblImeKlijenta.Text = Korisnik.PrijavljeniKorisnik.Ime +" "+ Korisnik.PrijavljeniKorisnik.Prezime;
            cmbVozilo.DataSource = PovratnaInformacija.PrikazVozila();
            cmbVozilo.DisplayMember = "Naziv";
            cmbVozilo.ValueMember = "VoziloID";
            this.KeyPreview = true;
            cmbVozilo.BackColor = Color.Red;
            txtOcjena.BackColor = Color.Red;
            txtOpis.BackColor = Color.Red;

        }
        /// <summary>
        /// Funkcije za aktiviranje i evidentiranje button klika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajPovratnuInformaciju();
        }
        /// <summary>
        /// FUnckija za dodavanje povratne ifnormacije
        /// </summary>
        private void DodajPovratnuInformaciju()
        {
            if(txtOpis.BackColor== Color.Green && txtOcjena.BackColor== Color.Green && cmbVozilo.BackColor== Color.Green)
            {
                PovratnaInformacija povratna = new PovratnaInformacija
                {
                    Opis = txtOpis.Text,
                    Ocjena = int.Parse(txtOcjena.Text),
                    VoziloID = cmbVozilo.SelectedValue.ToString(),
                    KorisnikID = Korisnik.PrijavljeniKorisnik.KorisnikID
                };
                PovratnaInformacija.DodajPovratnuInformaciju(povratna);
                MessageBox.Show("Povratna informacija uspjesno dodana");

            }
            else
            {
                MessageBox.Show("Povratna informacija nije dodana");
            }

        }
       
        /// <summary>
        /// Promjena boje pozadine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOpis_TextChanged(object sender, EventArgs e)
        {
            if (txtOpis.Text.Length > 10)
                txtOpis.BackColor = Color.Green;
            else
                txtOpis.BackColor = Color.Red;
        }
        /// <summary>
        /// Promjena boje pozadine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOcjena_TextChanged(object sender, EventArgs e)
        {
            int ocjena = 0;
            try
            {
                ocjena = int.Parse(txtOcjena.Text);
                txtOcjena.BackColor = Color.Green;
            }
            catch
            {
                ocjena = 0;
                txtOcjena.BackColor = Color.Red;
            }
        }
        /// <summary>
        /// Promjena boje pozadine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVozilo_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbVozilo.BackColor = Color.Green;
        }
        /// <summary>
        ///  User help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPovratnaInformacijaKorisnik_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += " Forma za povratne informacije radi na nacin da se u  \n" +
                " padajucim izbornicima odabiru korisnik i vozilo \n" +
                " te ocjena usluge koja se rucno upisuje u rangu od 1 do 10 \n" +
                "  bilo bi pozljeno ostaviti i neku povratnu informaciju na za \n" +
                "  to predvidenom mjestu, kada je sve uspjesno ispunjeno \n" +
                "  pritiskom na gumb unesi povratnu informaciju \n" +
                "   dodaje se nova informacija\n";
                pomoc.ShowDialog();
            }
        }
    }
}
