﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadiaForm_Dekstop
{
    public partial class Data_Guruu : Form
    {
        public Data_Guruu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Master_data().Show();
            this.Hide();
        }
    }
}