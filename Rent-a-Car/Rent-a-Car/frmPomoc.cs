﻿using System;
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
    public partial class frmPomoc : Form
    {
        public frmPomoc()
        {
            InitializeComponent();
            rxtPomoc.SelectAll();
            rxtPomoc.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
