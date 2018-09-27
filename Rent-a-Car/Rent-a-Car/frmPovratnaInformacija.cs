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
    public partial class frmPovratnaInformacija : Form
    {
        /// <summary>
        /// konsturktor forme
        /// </summary>
        public frmPovratnaInformacija()
        {
            InitializeComponent();
            this.Text = "Dodavanje povratne informacije";
        }
        /// <summary>
        /// Funckija koja se pali na load forme
        /// puni formu sa podacima koji su potrebni za normalan rad 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPovratnaInformacija_Load(object sender, EventArgs e)
        {
            cmbKlijent.DataSource = PovratnaInformacija.PrikazKorisnika();
            cmbVozilo.DataSource = PovratnaInformacija.PrikazVozila();
            cmbKlijent.DisplayMember = "Ime";
            cmbVozilo.DisplayMember = "Naziv";
            cmbKlijent.ValueMember = "KorisnikID";
            cmbVozilo.ValueMember = "VoziloID";
            this.KeyPreview = true;
            cmbKlijent.BackColor = Color.Red;
            cmbVozilo.BackColor = Color.Red;
            txtOcjena.BackColor = Color.Red;
            txtOpis.BackColor = Color.Red;
        }
        /// <summary>
        /// Metoda koja se koristi za dodavanje nove povratne infromacije u bazu
        /// </summary>
        private void DodajPovratnuInformaciju()
        {

            if(cmbKlijent.BackColor==Color.Green && cmbVozilo.BackColor==Color.Green && txtOpis.BackColor==Color.Green && txtOcjena.BackColor == Color.Green)
            {
                PovratnaInformacija povratna = new PovratnaInformacija
                {
                    Opis = txtOpis.Text,
                    Ocjena = int.Parse(txtOcjena.Text),
                    VoziloID = cmbVozilo.SelectedValue.ToString(),
                    KorisnikID = cmbKlijent.SelectedValue.ToString()
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
        /// Metoda koja se aktivira klikom na gumb za unos povratne informacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajPovratnuInformaciju();
            
            txtOpis.Clear();
            
        }
        /// <summary>
        /// Metoda koja otvara pomoc za korisnike pritiskom na f1 gumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPovratnaInformacija_KeyUp(object sender, KeyEventArgs e)
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

        private void cmbKlijent_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbKlijent.BackColor = Color.Green;
        }

        private void cmbVozilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVozilo.BackColor = Color.Green;
        }

        private void txtOcjena_TextChanged(object sender, EventArgs e)
        {
            int ocjena = 0;
            if(txtOcjena.Text == "1" || txtOcjena.Text == "2" || txtOcjena.Text == "3" || txtOcjena.Text == "4" || txtOcjena.Text == "5")
            {
                    ocjena = int.Parse(txtOcjena.Text);
                    txtOcjena.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Unesite ocjenu između 1 i 5");
                txtOcjena.Clear();
                txtOcjena.BackColor = Color.Red;
            }
        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {
            if (txtOpis.Text.Length > 10)
                txtOpis.BackColor = Color.Green;
            else
                txtOpis.BackColor = Color.Red;
        }
    }
}
