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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            String cp1 = campo1.Text;
            int cp2 = int.Parse(campo2.Text);
            if (((cp1=="admin") && (cp2 == 1234)) || ((cp1=="john") && (cp2==4321)))
            {
                MessageBox.Show("Bienvenido a konoha  " + campo1.Text, "Alert");
                campo1.Text = "";

                Form home = new Home();
                home.Show();

                this.Hide();
            }
            else
            {
            MessageBox.Show("Usuario y contraseña invalidos  ", "Alert");
            }

        }

        
    }
}
