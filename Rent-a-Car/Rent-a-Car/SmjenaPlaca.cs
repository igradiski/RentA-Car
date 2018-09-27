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
    public partial class SmjenaPlaca : Form
    {
        public SmjenaPlaca()
        {
            InitializeComponent();
        }

        

        private void OtvoriFormuZaObracun(object sender, EventArgs e)
        {
            ObracunPlace obracun = new ObracunPlace();
            obracun.ShowDialog();
        }

        private void OtvoriPlaniranjeSmjene(object sender, EventArgs e)
        {
            PregledSmjena smjena = new PregledSmjena();
            smjena.ShowDialog();
        }
    }
}
