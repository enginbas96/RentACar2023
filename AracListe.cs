﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar2023
{
    public partial class AracListe : Form
    {
        public AracListe()
        {
            InitializeComponent();
        }

        private void AracListe_Load(object sender, EventArgs e)
        {

        }

        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
