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
    public partial class frmIzvjestaj : Form
    {
        public string Ime;
        public string Prezime;
        public DateTime Datum;
        public float PlacaPoSatu;
        public float RadniSati;
        public float RadniDani;
        public float Ukupno;
        /// <summary>
        /// Konsturktor koji prima podatke za izvjestaj
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="prezime"></param>
        /// <param name="datum"></param>
        /// <param name="placa"></param>
        /// <param name="radniSati"></param>
        /// <param name="radniDani"></param>
        /// <param name="ukupno"></param>
        public frmIzvjestaj(string ime, string prezime, DateTime datum, float placa, float radniSati, float radniDani, float ukupno)
        {
            InitializeComponent();
            this.Text = "Izvjestaj";
            Ime = ime;
            Prezime = prezime;
            Datum = datum;
            PlacaPoSatu = placa;
            RadniSati = radniSati;
            RadniDani = radniDani;
            Ukupno = ukupno;
        }
        /// <summary>
        /// Funkcija na load puni report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {

            this.rpvPreglednik.RefreshReport();
            NapuniIzvjestaj();
            this.KeyPreview = true;
        }
        /// <summary>
        /// Funkcija koja izvjestaju salje parametre
        /// </summary>
        private void NapuniIzvjestaj()
        {
            ReportParameterCollection parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("ImeKorisnika", Ime));
            parametri.Add(new ReportParameter("PrezimeKorisnika", Prezime));
            parametri.Add(new ReportParameter("PlacaSat", PlacaPoSatu.ToString()));
            parametri.Add(new ReportParameter("RadniSat", RadniSati.ToString()));
            parametri.Add(new ReportParameter("RadniDan", RadniDani.ToString()));
            parametri.Add(new ReportParameter("Ukupno", Ukupno.ToString()));
            parametri.Add(new ReportParameter("Datum", Datum.ToString()));
            this.rpvPreglednik.LocalReport.SetParameters(parametri);
            this.rpvPreglednik.RefreshReport();

        }
        /// <summary>
        /// User help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIzvjestaj_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "U ovoj formi je prikazan izvjestaj, klikon na pisac ispisuje se dani izvjestaj";
                pomoc.ShowDialog();
            }
        }
    }
}
