﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HockeyManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Accueil.identite != "coach")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Accueil.identite != "coach" && Accueil.identite != "assistant")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Accueil.identite != "coach" && Accueil.identite != "assistant")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Accueil.identite != "coach" && Accueil.identite != "assistant")
            {
                button1.Hide();
                button2.Hide();
            }
            else
            {
                button1.Show();
                button2.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
