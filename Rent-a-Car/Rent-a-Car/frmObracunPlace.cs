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
    public partial class frmObracunPlace : Form
    {
        public DateTime datum;
        public string IDkorisnika;
        public Korisnik korisnik = new Korisnik();
        BindingList<Radi> listaSmjena = null;
        /// <summary>
        /// Konsturktor forme
        /// </summary>
        /// <param name="trenutniDatum"></param>
        /// <param name="ID"></param>
        public frmObracunPlace(DateTime trenutniDatum, string ID)
        {
            InitializeComponent();
            this.Text = "Obracun place";
            datum = trenutniDatum;
            IDkorisnika = ID;
        }

        /// <summary>
        /// Funckija na load dohvaca korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmObracunPlace_Load(object sender, EventArgs e)
        {
            txtPlaca.BackColor = Color.Red;
            lblTrenutniDatum.Text = datum.ToString();
            lblKorisnik.Text = IDkorisnika;
            korisnik = Korisnik.DohvatiKorisnikaPoID(IDkorisnika);
            lblKorisnik.Text = korisnik.Ime.ToString() + " " + korisnik.Prezime.ToString();
            PregledSmjena();
            btnIspis.Hide();
            this.KeyPreview = true;
            //this.KeyUp += frmObracunPlace_KeyUp;
        }
        /// <summary>
        /// Prikazuje u dgv smjene odredenog radnika
        /// </summary>
        private void PregledSmjena()
        {
            listaSmjena = Radi.odradeneSmjene(IDkorisnika, datum);
            dgvOdradeno.DataSource = listaSmjena;
            dgvOdradeno.Columns["Korisnik"].Visible = false;
            dgvOdradeno.Columns["Smjena"].Visible = false;
        }
        /// <summary>
        /// Metoda izracunava placu za radnika
        /// </summary>
        private void IzracunajPlacu()
        {
            try
            {
                if (txtPlaca.Text.ToString().Length > 0)
                {
                    txtRadniDani.Text = listaSmjena.Count.ToString();
                    txtRadniSati.Text = (listaSmjena.Count * 8).ToString();
                }

            }
            catch { }

        }
        /// <summary>
        /// gumb za pokretanje racunanja place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if(txtPlaca.BackColor == Color.Green)
            {
                IzracunajPlacu();
                float placa = 0;
                if (txtPlaca.Text.ToString().Length > 0)
                {
                    try
                    {
                        placa = float.Parse(txtPlaca.Text);
                        txtUkupno.Text = (placa * (listaSmjena.Count * 8)).ToString();
                        if (placa > 0)
                        {
                            btnIspis.Show();
                        }
                    }
                    catch { }

                }
            }
            else
            {
                MessageBox.Show("Niste ispravno unijeli placu");
            }
            

        }
        /// <summary>
        /// gumb za otvaranje reporta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspis_Click(object sender, EventArgs e)
        {
            frmIzvjestaj izvjestaj = new frmIzvjestaj(korisnik.Ime.ToString(), korisnik.Prezime.ToString(), datum, float.Parse(txtPlaca.Text), float.Parse(txtRadniSati.Text), float.Parse(txtRadniDani.Text), float.Parse(txtUkupno.Text));
            this.Hide();
            izvjestaj.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// user hellp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmObracunPlace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "Forma za obracun place se koristi na nacin da se unese radnikova \n" +
                "placa po satu u za to predvideni tekstualni okvir.\n" +
                "Pritiskom na gumb izracunaj izracunava se placa i \n" +
                "popunjavaju se ostali tekstualni okviri odgovarajucim \n" +
                "podacima. Kada je operacija uspjesno izvrsena \n" +
                "Pojavljuje se gumb ispis koji generira automatski \n" +
                "Izvještaj s placom za radnika.";
                pomoc.ShowDialog();
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            int placa = 0;
            try
            {
                placa = int.Parse(txtPlaca.Text);
                txtPlaca.BackColor = Color.Green;
            }
            catch
            {
                txtPlaca.BackColor = Color.Red;
            }
           
                
        }
    }
}
