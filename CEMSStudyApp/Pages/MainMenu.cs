﻿using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Part75 part75 = new Part75();
            part75.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Part60 part60 = new Part60();
            part60.Show();
        }

        private void buttonFormulas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulas formulas = new Formulas();
            formulas.Show();
        }

        private void buttonAcronyms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acronyms acronyms = new Acronyms();
            acronyms.Show();
        }

        private void buttonHowTos_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowTos howTos = new HowTos();
            howTos.Show();
        }
    }
}
