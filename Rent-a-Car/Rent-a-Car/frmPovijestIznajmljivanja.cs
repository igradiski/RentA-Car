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
    public partial class frmPovijestIznajmljivanja : Form
    {
        public frmPovijestIznajmljivanja()
        {
            InitializeComponent();
            this.Text = "Povijest iznajmljivanja";
        }
        /// <summary>
        /// Na load forme za pregled povijesti iznajmljivanja  se dohvacaju podaci u combo box i prikazuju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPovijestIznajmljivanja_Load(object sender, EventArgs e)
        {
            cmbZaposlenik.DataSource = Korisnik.dohvatiRadnike(4);
            cmbZaposlenik.ValueMember = "KorisnikID";
            cmbZaposlenik.DisplayMember = "Prezime";
            this.KeyPreview = true;
            //this.KeyUp += frmPovijestIznajmljivanja_KeyUp;
        }
        /// <summary>
        /// Na promjenu odabranog zaposlenika mijenjaju se i iznajmljivanja koja su njegova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            try
            {
                dgvIznajmljivanja.DataSource = Iznajmljivanje.IznajmljivanjaRadnika(cmbZaposlenik.SelectedValue.ToString());
                txtBrojIznajmljivanja.Text = Iznajmljivanje.IznajmljivanjaRadnika(cmbZaposlenik.SelectedValue.ToString()).Count.ToString();
               
                dgvIznajmljivanja.Columns["Korisnik"].Visible = false;
                dgvIznajmljivanja.Columns["Korisnik1"].Visible = false;
                dgvIznajmljivanja.Columns["Racun"].Visible = false;
                dgvIznajmljivanja.Columns["Vozilo"].Visible = false;
            }
            catch
            {

            }
        }
        /// <summary>
        /// Help box za korisnike
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPovijestIznajmljivanja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += "U padajucem izborniku se moze odabrati radnik za kojeg zelimo vidjeti iznajmljivanja \n"+
                    "Te se u pogledu mogu onda vidjeti sva izmajmljivanja za pojedinog radnika";
                pomoc.ShowDialog();
            }
        }

        private void dgvIznajmljivanja_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvIznajmljivanja.SelectedRows.Count > 0)
            {
                if (dgvIznajmljivanja.CurrentRow.Cells[1].Value != null)
                    txtNaziv.Text = dgvIznajmljivanja.CurrentRow.Cells[1].Value.ToString();
                if (dgvIznajmljivanja.CurrentRow.Cells[2].Value != null)
                    txtOpis.Text=dgvIznajmljivanja.CurrentRow.Cells[2].Value.ToString();
                if (dgvIznajmljivanja.CurrentRow.Cells[11].Value != null)
                    txtCijena.Text = dgvIznajmljivanja.CurrentRow.Cells[11].Value.ToString();
                if (dgvIznajmljivanja.CurrentRow.Cells[4].Value != null)
                    txtPocetak.Text = dgvIznajmljivanja.CurrentRow.Cells[4].Value.ToString();
                if (dgvIznajmljivanja.CurrentRow.Cells[5].Value != null)
                    txtKraj.Text = dgvIznajmljivanja.CurrentRow.Cells[5].Value.ToString();
                if (dgvIznajmljivanja.CurrentRow.Cells[12].Value != null)
                    if (dgvIznajmljivanja.CurrentRow.Cells[12].Value.ToString() == "True")
                    {
                        txtNaplaceno.Text = "Naplaceno";
                        txtNaplaceno.BackColor = Color.Green;
                    }

                    else
                    {
                        txtNaplaceno.Text = "Nije naplaceno";
                        txtNaplaceno.BackColor = Color.Red;
                    }
                        
            }
        }
    }
}
