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
    public partial class frmObracunPlacePregledSmjena : Form
    {
        private DateTime datum;

        /// <summary>
        /// Konsturktor
        /// </summary>
        public frmObracunPlacePregledSmjena()
        {
            InitializeComponent();
            this.Text = "Obracun place i planiranje smjena";
            btnSmjena.Hide();
            btnPlaca.Hide();
        }
        /// <summary>
        /// Na load se popunjava forma s podacima o radniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmObracunPlacePregledSmjena_Load(object sender, EventArgs e)
        {
            cmbZaposlenik.DataSource = Korisnik.dohvatiRadnike(4);
            cmbZaposlenik.ValueMember = "KorisnikID";
            cmbZaposlenik.DisplayMember = "Prezime";
            btnPlaca.Visible = false;
            btnSmjena.Visible = false;
            this.KeyPreview = true;
        }
        /// <summary>
        /// Otvaranje forme za pregled smjena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSmjena_Click(object sender, EventArgs e)
        {
            frmPregledSmjena pregled = new frmPregledSmjena(datum);
            this.Hide();
            pregled.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// odabir mjeseca za smjenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cdrSmjena_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnSmjena.Visible = true;
            cdrSmjena.MaxSelectionCount = 1;
            datum = DateTime.Parse(cdrSmjena.SelectionRange.Start.ToString());
            if (datum != null)
                btnSmjena.Show();
        }
        /// <summary>
        /// event handler za promjenu datuma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cdrPlaca_DateChanged(object sender, DateRangeEventArgs e)
        {
            cdrPlaca.MaxSelectionCount = 1;

            datum = DateTime.Parse(cdrPlaca.SelectionRange.Start.ToString());
            if (datum != null)
                btnPlaca.Show();
        }
        /// <summary>
        /// otvaranje forme za obracun placa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlaca_Click(object sender, EventArgs e)
        {
            frmObracunPlace placa = new frmObracunPlace(datum, cmbZaposlenik.SelectedValue.ToString());
            this.Hide();
            placa.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// User help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmObracunPlacePregledSmjena_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Forma za obracun place i pregled smjena ima dvije grupe \n" +
                "jedna grupa je placa, a druga smjene. Placa sluzi za \n" +
                "obracun placa, odabere se zaposlenik u padajucem izborniku\n" +
                "i mjesec za koji mu zelite isplatiti ili izracunati placu. \n" +
                "Kada je sve ispravno odabrano pokazuje se gumb obracunaj \n" +
                "placu koji vodi na novu formu za obracun place. \n" +
                "Kod grupe za planiranje smjena postupak je jos jednostavniji \n" +
                "odabere se dan, kada je dan ispravno odabran prikazuje se\n" +
                "gumb za planiranje smjena koji otvara novu formu.";

                pomoc.ShowDialog();
            }
        }

        private void cmbZaposlenik_SelectedValueChanged(object sender, EventArgs e)
        {
            btnPlaca.Visible = true;
        }
    }
}
