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
    public partial class PregledFeedbackova : Form
    {
        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public PregledFeedbackova()
        {
            InitializeComponent();
            this.Text = "Pregled povratnih informacija";
        }
        /// <summary>
        /// Metoda koja na klik gumba poziva metodu za brisanje povratne informacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BrisanjePovratneInformacije();
            MessageBox.Show("Povratna informacija obrisana!");
            dgvPovratneInformacije.Refresh();
        }
        /// <summary>
        /// Metoda za brisanje povratne informacije
        /// </summary>
        private void BrisanjePovratneInformacije()
        {
            try
            {
                string ID = dgvPovratneInformacije.CurrentRow.Cells["PovratnaInformacijaID"].Value.ToString();
                PovratnaInformacija.BrisanjePovratneInformacije(int.Parse(ID));
                dgvPovratneInformacije.DataSource = PovratnaInformacija.PrikazVozilaPoID(cmbVozilo.SelectedValue.ToString());
                dgvPovratneInformacije.Refresh();
            }
            catch
            {

                MessageBox.Show("Brisanje nije uspjelo!");
            }


        }


        /// <summary>
        /// Metoda na klik otvara formu za dodavanje nove povratne informacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajPovratnu_Click(object sender, EventArgs e)
        {
            frmPovratnaInformacija pov = new frmPovratnaInformacija();
            this.Hide();
            pov.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Metoda koja na load puni data grid view i puni sve ostale dijelo forme
        /// potrebne za normalan rad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PregledFeedbackova_Load(object sender, EventArgs e)
        {
            NajmanjiProfit();
            NajveciProfit();
            cmbVozilo.DataSource = PovratnaInformacija.PrikazVozila();
            cmbVozilo.ValueMember = "VoziloID";
            dgvPovratneInformacije.Columns["Korisnik"].Visible = false;
            dgvPovratneInformacije.Columns["Vozilo"].Visible = false;
            txtOcjenaUkupna.Text = prosjecnaOcjenaUsluge().ToString();
            txtOcjenaUkupna.ForeColor = Color.Red;
            txtOcjenaAuta.ForeColor = Color.Red;
            this.KeyPreview = true;
            NajboljiAutomobil();
            NajgoriAutomobili();
            //this.KeyUp += PregledFeedbackova_KeyUp;

        }

        /// <summary>
        /// Trazenje najgorih vozila
        /// </summary>
        private void NajgoriAutomobili()
        {
            
            foreach (var item in PovratnaInformacija.PovratneInformacije())
            {
                if(item.Ocjena == 1)
                {
                    BindingList<Vozilo> voz = new BindingList<Vozilo>();
                    voz = Vozilo.DohvatiVozilaPoRegistracijskimOznakama(item.VoziloID);
                    foreach (var item2 in voz)
                    {
                        rxtNajgori.Text += "\n" + item2.Naziv + " " + item2.VoziloID + "\n";
                        rxtNajgori.Text += "\n=================\n";
                    }
                }
            }

        }
        /// <summary>
        /// Trazenje najboljih automobila
        /// </summary>
        private void NajboljiAutomobil()
        {
            foreach (var item in PovratnaInformacija.PovratneInformacije())
            {
                if (item.Ocjena >=4)
                {
                    BindingList<Vozilo> voz = new BindingList<Vozilo>();
                    voz= Vozilo.DohvatiVozilaPoRegistracijskimOznakama(item.VoziloID);
                    foreach (var item2 in voz)
                    {

                        rxtNajbolji.Text += "\n"+item2.Naziv + " " + item2.VoziloID + "\n";
                        rxtNajbolji.Text += "\n=================\n";
                    }
                }
            }

        }
        /// <summary>
        /// Metoda za racunanje prosjecne ocjene usluge
        /// </summary>
        /// <returns></returns>
        private float prosjecnaOcjenaUsluge() {
            float suma = 0;
            foreach (var item in PovratnaInformacija.PovratneInformacije())
            {
                suma += item.Ocjena;
            }
            suma = suma / PovratnaInformacija.PovratneInformacije().Count;
            return suma;

        }
        /// <summary>
        /// Metoda za racucanje prosjecne ocjene vozila
        /// </summary>
        /// <returns></returns>
        private float ocjenaVozila()
        {
            float ocjena = 0;
            try
            {
                foreach (var item in PovratnaInformacija.PrikazVozilaPoID(cmbVozilo.SelectedValue.ToString()))
                {
                    ocjena += item.Ocjena;
                }
                ocjena = ocjena / PovratnaInformacija.PrikazVozilaPoID(cmbVozilo.SelectedValue.ToString()).Count;
            }
            catch
            {
                ocjena = 0;
            }
            return ocjena;
        }
        /// <summary>
        /// Metoda koja na promjenu odabrana povratne informacije 
        /// mijenja sadrzaj u raznim text boxivima u svrhu prikaza novo odabranog vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPovratneInformacije_SelectionChanged(object sender, EventArgs e)
        {
            txtOpis.Clear();
            if (dgvPovratneInformacije.SelectedRows.Count > 0)
            {
                if (dgvPovratneInformacije.CurrentRow.Cells[1].Value != null)
                    txtOpis.Text = dgvPovratneInformacije.CurrentRow.Cells[1].Value.ToString();
                else
                    txtOpis.Text = "";

            }
            txtOcjenaAuta.Text = ocjenaVozila().ToString();

        }
        /// <summary>
        /// Metoda koja baca povratne informacije za odredeno vozilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVozilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPovratneInformacije.DataSource = PovratnaInformacija.PrikazVozilaPoID(cmbVozilo.SelectedValue.ToString());
            try
            {
                lblNaziv.Text = Vozilo.DohvatiVoziloPoRegistraciji(cmbVozilo.SelectedValue.ToString()).Naziv;
            }
            catch
            {
                lblNaziv.Text = "";
            }
                
                
            
            
        }
        /// <summary>
        /// Metoda za prikaz pomoci na formi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PregledFeedbackova_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPomoc pomoc = new frmPomoc();
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Rent-A-Car Help Center\n\n";
                richTextBox.Text += " Forma za pregled vozila ima par mogucnosti koje ce biti opisane \n" +
                " Vozilo za kojeg zelimo povratne informacije odabire se na  \n" +
                "  padajucem izborniku, te se s desne strane vide sve povratne \n" +
                " informacije te ispod padajuceg izbornika vidimo prosjecnu ocjenu \n" +
                " za to vozilo. U listi podataka s desne strane mozemo odabrati \n" +
                " tocno odredenu povratnu informaciju. Tim odabirom se automatski \n" +
                " puni tekstualni okvir zbog lakse i preglednijeg citanja komentara \n" +
                " U donjem desnom kutu se vidi opcenita ocjena cjelokupne usluge \n" +
                " U slucaju nepozeljnog ili bezobraznog komentara cak i u slucaju manipulacije \n" +
                "  postoji gumb za brisanje povratne informacije. Odabere se povratna informacija \n" +
                "  te klikom na gumb za brisanje ona nestaje \n"+
                "Tekstualni okviri pokazuju vozila s ocjenuom 1 i \n"+
                "Vozila s ocjenom 4 ili vise kao najbolja";
                pomoc.ShowDialog();
            }
        }
        private void txtPoRegistraciji_TextChanged(object sender, EventArgs e)
        {
            
            BindingList<Vozilo> listaVozila = new BindingList<Vozilo>();
            BindingList<PovratnaInformacija> svePovratne = new BindingList<PovratnaInformacija>();
            listaVozila = Vozilo.DohvatiVozilaPoRegistraciji(txtPoRegistraciji.Text);
            if (listaVozila.Count > 0)
            {
                txtPoRegistraciji.BackColor = Color.Green;
                foreach (var item in listaVozila)
                {
                    svePovratne = PovratnaInformacija.PrikazVozilaPoID(item.VoziloID);
                    lblNaziv.Text = item.Naziv;
                    
                }

            }
            BindingList<PovratnaInformacija> listaSve = new BindingList<PovratnaInformacija>();
            foreach (var item in svePovratne)
            {
                listaSve.Add(item);
                dgvPovratneInformacije.DataSource = listaSve;

            }
            txtPoRegistraciji.BackColor = Color.White;
        }

        private void txtPretraziPoNazivu_TextChanged(object sender, EventArgs e)
        {
            
            BindingList<Vozilo> listaVozila = new BindingList<Vozilo>();
            BindingList<PovratnaInformacija> svePovratne = new BindingList<PovratnaInformacija>();
            listaVozila = Vozilo.DohvatiVozilaPoNazivu(txtPretraziPoNazivu.Text);
            if(listaVozila.Count > 0)
            {
                txtPretraziPoNazivu.BackColor = Color.Green;
                foreach (var item in listaVozila)
                {
                    svePovratne = PovratnaInformacija.PrikazVozilaPoID(item.VoziloID);
                    lblNaziv.Text = item.Naziv;
                    
                }
                
            }
            BindingList<PovratnaInformacija> listaSve = new BindingList<PovratnaInformacija>();
            foreach (var item in svePovratne)
            {
                listaSve.Add(item);
                dgvPovratneInformacije.DataSource = listaSve;
                
            }
            txtPretraziPoNazivu.BackColor = Color.White;

        }

        private void NajveciProfit()
        {
            List<Vozilo> listaVozila = Vozilo.SvaVozila();
            
            foreach (var item in listaVozila)
            {
                BindingList<Iznajmljivanje> listaIznajmljivanja = Iznajmljivanje.Iznajmljivanja();
                foreach (var item2 in listaIznajmljivanja)
                {
                    if(item2.VoziloID == item.VoziloID)
                    {
                       double suma = item.CijenaPoDanu * listaIznajmljivanja.Count;
                       if(double.Parse(txtProfitMaxBroj.Text) < suma)
                        {
                            txtProfitMaxBroj.Text = suma.ToString();
                            txtProfitMaxIme.Text = item.Naziv;
                        }
                    }
                }
                    
               
            }



        }
        private void NajmanjiProfit()
        {
            List<Vozilo> listaVozila = Vozilo.SvaVozila();
            txtMinProfitBroj.Text = "50000";
            foreach (var item in listaVozila)
            {
                BindingList<Iznajmljivanje> listaIznajmljivanja = Iznajmljivanje.Iznajmljivanja();
                foreach (var item2 in listaIznajmljivanja)
                {
                    if (item2.VoziloID == item.VoziloID)
                    {
                        double suma = item.CijenaPoDanu * listaIznajmljivanja.Count;
                        if (double.Parse(txtMinProfitBroj.Text) > suma)
                        {
                            txtMinProfitBroj.Text = suma.ToString();
                            txtMinProfitIme.Text = item.Naziv;
                        }
                    }
                }


            }



        }

        
    }
}
