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
    public partial class frmDodajVozilo : Form

    {
        /// <summary>
        /// Svojstvo koje omogućava praćenje dali se radi o dodavanju vozila ili o ažuriranju odabranog
        /// </summary>
        private Vozilo vozilo { get; set; }
        /// <summary>
        /// Konstruktor forme koji koristimo za inicijalizaciju komponenti
        /// </summary>
        public frmDodajVozilo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Konstruktor forme koji koristimo za izmejenu postojećeg vozila
        /// </summary>
        /// <param name="selektiranoVozilo"> Vozilo koje treba izmjeniti</param>
        public frmDodajVozilo(Vozilo selektiranoVozilo)
        {
            InitializeComponent();
            vozilo = selektiranoVozilo;
            btnDodajVozilo.Text = "Azuriraj";
        }
        /// <summary>
        /// Rukuje događajem pokretanje forme te dohvaća te puni combobox-eve podacima, te ako je odabranoo vozilo za izmjenu popunjava podatke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajVozilo_Load(object sender, EventArgs e)
        {
            kategorijaBindingSource.DataSource = Kategorija.DohvatiKategorije();
            tipMotoraBindingSource.DataSource = TipMotora.DohvatiTipoveMotora();
            if (vozilo != null)
            {
                txtRegistracija.Text = vozilo.VoziloID;
                txtRegistracija.Enabled = false;
                txtNaziv.Text = vozilo.Naziv;
                txtGodinaProizvodnje.Text = vozilo.GodinaProizvodnje.ToString();
                txtSnagaMotora.Text = vozilo.SnagaMotora.ToString();
                txtKilometri.Text = vozilo.Kilometri.ToString();
                txtBrojSjedala.Text = vozilo.BrojSjedala.ToString();
                dtpDatumRegistriranja.Text = vozilo.DatumRegistracije.ToString();
                cmbKategorija.SelectedValue = vozilo.KategorijaID;
                cmbTipMotora.SelectedValue = vozilo.TipMotoraID;
                txtCijenaPoDanu.Text = vozilo.CijenaPoDanu.ToString();

                this.Text = "Ažuriranje vozila";
            }
            this.KeyPreview = true;
            this.KeyUp += frmDodajVozilo_KeyUp;
        }
        /// <summary>
        /// Rukuje događajem pritisak tipke na tipkovnici. Ako se pritisne tipa F1 otvara se forma za pomoć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajVozilo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (vozilo == null)
                {
                    frmPomoc pomoc = new frmPomoc();
                    RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                    richTextBox.Clear();
                    richTextBox.Text = "Rent-A-Car Help Center\n\n";
                    richTextBox.Text += "Trenutno ste pritisnuli F1 na formi DodajVozilo.\n\n" +
                        "Na formi DodajVozilo možete vidjeti tekstulna polja za unos novog vozila te gumb ''Dodaj vozilo''\n\n " +
                        "Registracijska oznaka mora imati  9 ili 10 znakova npr(KR-111-IB), ukoliko je registracijska oznaka dostupna tekstualno polje je zelene boje inače je crvene .\n\n" +
                        "Ukoliko su uneseni svi uneseni  podaci ispravni i pritisnite gumb ''Dodaj vozilo'' dodaje se novo vozilo te Vas aplikacija vodi na formu Vozila. \n\n";

                    pomoc.ShowDialog();
                }
                else
                {
                    frmPomoc pomoc = new frmPomoc();
                    RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtPomoc", true)[0];
                    richTextBox.Clear();
                    richTextBox.Text = "Rent-A-Car Help Center\n\n";
                    richTextBox.Text += "Trenutno ste pritisnuli F1 na formi DodajVozilo.\n\n" +
                        "Na formi DodajVozilo možete vidjeti tekstulna polja za unos novog vozila te gumb ''Ažuriraj vozilo''\n\n " +
                        "Možete vidjeti da su sva polja već popunjena, te možete izmeniti podatake o vozilu.\n\n" +
                        "Ukoliko su uneseni svi uneseni  podaci ispravni i pritisnite gumb ''Ažuriraj vozilo'' ažurira se  vozilo te Vas aplikacija vodi na formu Vozila. \n\n";

                    pomoc.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za dodavanje ili ažuriranje vozila
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if (txtRegistracija.Text != null && txtNaziv.Text != "" && txtGodinaProizvodnje.Text != "" && txtSnagaMotora.Text != "" && txtKilometri.Text != "" && dtpDatumRegistriranja.Text != "" && cmbKategorija.SelectedValue != null && cmbTipMotora.SelectedValue != null && txtCijenaPoDanu.Text != "")
            {
                if (int.TryParse(txtGodinaProizvodnje.Text, out int godina) && int.TryParse(txtBrojSjedala.Text, out int sjedala) && int.TryParse(txtSnagaMotora.Text, out int snaga) && int.TryParse(txtKilometri.Text, out int kilometri) && double.TryParse(txtCijenaPoDanu.Text, out double cijenapo))
                {
                    int IdKategorije = int.Parse(cmbKategorija.SelectedValue.ToString());
                    int IdTipMotora = int.Parse(cmbTipMotora.SelectedValue.ToString());
                    if (vozilo == null)
                    {
                        if (Vozilo.ProvjeriDostupnostRegistraciskihOznaka(txtRegistracija.Text))
                        {
                            Vozilo vozilo = new Vozilo
                            {
                                VoziloID = txtRegistracija.Text,
                                Naziv = txtNaziv.Text,
                                GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                                SnagaMotora = int.Parse(txtSnagaMotora.Text),
                                Kilometri = int.Parse(txtKilometri.Text),
                                BrojSjedala = int.Parse(txtBrojSjedala.Text),
                                DatumRegistracije = dtpDatumRegistriranja.Value.Date,
                                KategorijaID = IdKategorije,
                                TipMotoraID = IdTipMotora,
                                CijenaPoDanu = float.Parse(txtCijenaPoDanu.Text.ToString())

                            };
                            Vozilo.DodajVozilo(vozilo);
                            txtRegistracija.Clear();
                            txtNaziv.Clear();
                            txtSnagaMotora.Clear();
                            txtKilometri.Clear();
                            txtBrojSjedala.Clear();
                            txtCijenaPoDanu.Clear();
                            txtGodinaProizvodnje.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Vozilo s tim registracijskim oznakama već postoji", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        using (RentACarEntities db = new RentACarEntities())
                        {
                            db.Vozilo.Attach(vozilo);
                            vozilo.VoziloID = txtRegistracija.Text;
                            vozilo.Naziv = txtNaziv.Text;
                            vozilo.GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text);
                            vozilo.SnagaMotora = int.Parse(txtSnagaMotora.Text);
                            vozilo.Kilometri = int.Parse(txtKilometri.Text);
                            vozilo.BrojSjedala = int.Parse(txtBrojSjedala.Text);
                            vozilo.DatumRegistracije = dtpDatumRegistriranja.Value.Date;
                            vozilo.KategorijaID = IdKategorije;
                            vozilo.TipMotoraID = IdTipMotora;
                            vozilo.CijenaPoDanu = float.Parse(txtCijenaPoDanu.Text.ToString());
                            db.SaveChanges();
                        }
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Podaci koji bi trebali biti broj nisu ispravnog formata", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nisu ispunjeni svi podaci koji su potrebni za dodavanje novog vozila", "GREŠKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Rukuje događajem promjene teksta te u ovisnosti o ispravnosti unosa mijenja pozadinsku boju na texbox-u
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRegistracija_TextChanged(object sender, EventArgs e)
        {
            if (vozilo == null)
            {
                if (txtRegistracija.Text.Length > 8 && txtRegistracija.Text.Length < 11)
                {
                    if (Vozilo.ProvjeriDostupnostRegistraciskihOznaka(txtRegistracija.Text) == true)
                    {
                        txtRegistracija.BackColor = Color.Green;
                    }
                    else
                    {
                        txtRegistracija.BackColor = Color.Red;
                    }
                }
                else
                {
                    txtRegistracija.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Rukuje događajem klika na gumb. Prilikom klika zatvara se forma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
