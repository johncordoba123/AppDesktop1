﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void GoLogin_Click(object sender, EventArgs e)
        {

            Form form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
