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
    public partial class frmPregledDostupnihVozila : Form
    {
        private DateTime datumPocetka { get; set; }
        private DateTime datumKraja { get; set; }

        private BindingList<Vozilo> listaVozila = null;

        public Vozilo OdabranoVozilo { get; set; }
        /*
         * Kontruktor forme frmPregledDostupnihVozila.
         */
        /// <summary>
        /// Kontruktor klase frmPregledDostupnihVozila.
        /// </summary>
        /// <param name="pocetak"></param>
        /// <param name="kraj"></param>
        public frmPregledDostupnihVozila(DateTime pocetak, DateTime kraj)
        {
            InitializeComponent();
            datumPocetka = pocetak;
            datumKraja = kraj;
            listaVozila = Vozilo.PrikaziVozila(datumPocetka, datumKraja);
            foreach(Vozilo v in listaVozila)
            {
                this.prikaziDostupnaVozila(v);
            }
        }
        /*
         * Za vozilo kreira i postavlja na flowLayoutPanel groupbox sa podacima o vozilu.
         */
        /// <summary>
        /// Za vozilo kreira i postavlja na flowLayoutPanel groupbox sa podacima o vozilu.
        /// </summary>
        /// <param name="vozilo"></param>
        private void prikaziDostupnaVozila(Vozilo vozilo)
        {
            GroupBox g = new GroupBox();
            g.Height = 200;
            g.Text = vozilo.Naziv;
            Label lblMotor = new Label();
            lblMotor.Name = "lblMotor" + vozilo.VoziloID;
            lblMotor.Text = "Motor:";
            Label lblGodiste = new Label();
            lblGodiste.Name = "lblGodiste" + vozilo.VoziloID;
            lblGodiste.Text = "Godište:";
            Label lblCijena = new Label();
            lblCijena.Name = "lblCijena" + vozilo.VoziloID;
            lblCijena.Text = "Cijena po danu:";
            TextBox txtMotor = new TextBox();
            TipMotora tipMotora = null;
            TextBox txtGodiste = new TextBox();
            TextBox txtCijena = new TextBox();


            Button btnRezerviraj = new Button();
            btnRezerviraj.Name = "btnRezerviraj" + vozilo.VoziloID;
            btnRezerviraj.Text = "Rezerviraj";
            btnRezerviraj.Click += new EventHandler((sender, e)=>odaberiVozilo(vozilo));

            using(RentACarEntities db=new RentACarEntities())
            {
                tipMotora = (from t in db.TipMotora where t.TipMotoraID == vozilo.TipMotoraID select t).FirstOrDefault();
            }
            txtMotor.Enabled = false;
            txtGodiste.Enabled = false;
            txtCijena.Enabled = false;
            txtMotor.Text = tipMotora.Naziv;
            txtGodiste.Text = vozilo.GodinaProizvodnje.ToString();
            txtCijena.Text = vozilo.CijenaPoDanu.ToString();
            g.Controls.Add(lblMotor);
            g.Controls.Add(txtMotor);
            g.Controls.Add(lblGodiste);
            g.Controls.Add(txtGodiste);
            g.Controls.Add(lblCijena);
            g.Controls.Add(txtCijena);
            g.Controls.Add(btnRezerviraj);
            lblMotor.Width = 50;
            lblGodiste.Width = 50;
            lblCijena.Width = 50;
            lblMotor.Location = new Point(g.Location.X + 10, g.Location.Y + 20);
            txtMotor.Location = new Point(lblMotor.Location.X+lblMotor.Width, g.Location.Y + 20);
            lblGodiste.Location = new Point(g.Location.X + 10, txtMotor.Location.Y + 30);
            txtGodiste.Location = new Point(lblGodiste.Location.X + lblGodiste.Width, lblMotor.Location.Y + 30);
            lblCijena.Location = new Point(g.Location.X + 10, txtGodiste.Location.Y + 30);
            txtCijena.Location = new Point(lblCijena.Location.X + lblCijena.Width, lblGodiste.Location.Y + 30);
            btnRezerviraj.Location = new Point(g.Location.X + 75, txtCijena.Location.X + 50);
            flpDostupnaVozila.Controls.Add(g);
        }
        /*
         * Prima objekt Vozilo. Zatvara formu frmPregledDostupnihVozila i vraca podatke o odabranom vozilu.
         */
        /// <summary>
        /// Prima objekt Vozilo. Zatvara formu frmPregledDostupnihVozila i vraca podatke o odabranom vozilu.
        /// </summary>
        /// <param name="v"></param>
        private void odaberiVozilo(Vozilo v)
        {
            this.OdabranoVozilo = v;
            this.Close();
        }

    }
}
