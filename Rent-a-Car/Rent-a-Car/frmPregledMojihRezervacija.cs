using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Rent_a_Car
{
    public partial class frmPregledMojihRezervacija : Form
    {
        public frmPregledMojihRezervacija()
        {
            InitializeComponent();
        }

        /*
         * Metoda koja dohvaća rezervacije za trenutno prijavljenog korisnika i prikazuje ih.
         */
        /// <summary>
        /// Metoda koja dohvaća rezervacije za trenutno prijavljenog korisnika i prikazuje ih.
        /// </summary>
        private void prikaziRezervacije()
        {
            using (RentACarEntities db = new RentACarEntities())
            {
                voziloBindingSource.DataSource = Vozilo.DohvatiVozila();
                rezervacijaBindingSource.DataSource = Rezervacija.DohvatiMojeRezervacije(Korisnik.PrijavljeniKorisnik);
                dgvMojeRezervacije.DataSource = rezervacijaBindingSource;

                dgvMojeRezervacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                int sirina = 0;
                foreach (DataGridViewColumn c in dgvMojeRezervacije.Columns)
                {
                    if (c.Displayed)
                    {
                        sirina += c.Width;
                    }
                }
                dgvMojeRezervacije.Width = sirina + dgvMojeRezervacije.RowHeadersWidth + 2;
                dgvMojeRezervacije.Height = (dgvMojeRezervacije.Rows.Count + 1) * 25;
                btnAzuriraj.Location = new Point(dgvMojeRezervacije.Location.X + dgvMojeRezervacije.Width + 3, dgvMojeRezervacije.Location.Y);
                btnObrisi.Location = new Point(dgvMojeRezervacije.Location.X + dgvMojeRezervacije.Width + 3, btnAzuriraj.Location.Y + btnAzuriraj.Height);
            }
        }

        private void frmPregledMojihRezervacija_Load(object sender, EventArgs e)
        {
            prikaziRezervacije();   
        }

        /*
         * Rukuje događajem klika na gumb btnObrisi.
         */
        /// <summary>
        /// Rukuje događajem klika na gumb btnObrisi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Rezervacija rezervacijaZaBrisanje = (Rezervacija)rezervacijaBindingSource.Current;
            if (rezervacijaZaBrisanje != null)
            {
                DialogResult odgovor = MessageBox.Show("Jeste li sigurni da želite otkazati rezervaciju " + dgvMojeRezervacije.CurrentRow.Cells[0] + "?", "Otkazivanje rezervacije", MessageBoxButtons.YesNo);
                if (odgovor == DialogResult.Yes)
                {
                    using (RentACarEntities db = new RentACarEntities())
                    {
                        db.Rezervacija.Attach(rezervacijaZaBrisanje);
                        db.Rezervacija.Remove(rezervacijaZaBrisanje);
                        db.SaveChanges();
                    }
                    prikaziRezervacije();
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali rezervaciju!");
            }
        }
        /*
         * Rukuje događajem klika na gumb btnAzuriraj. Otvara formu frmDodajRezervaciju.
         */
         /// <summary> 
         /// Rukuje događajem klika na gumb btnAzuriraj. Otvara formu frmDodajRezervaciju.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Rezervacija rezervacijaZaAzuriranje = (Rezervacija)rezervacijaBindingSource.Current;
            if (rezervacijaZaAzuriranje != null)
            {
                Vozilo voziloNaRezervaciji = (Vozilo)voziloBindingSource.Current;
                frmDodajPromijeniRezervaciju frmDodajRezervaciju = new frmDodajPromijeniRezervaciju(rezervacijaZaAzuriranje);
                this.Hide();
                frmDodajRezervaciju.ShowDialog();
                this.Show();
                prikaziRezervacije();
            }
            else
            {
                MessageBox.Show("Niste odabrali rezervaciju!");
            }
        }
    }
}
