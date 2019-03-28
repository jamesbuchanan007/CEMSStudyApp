﻿using System;
using System.Windows.Forms;

namespace CEMSStudyApp.Pages
{
    public partial class Acronyms : Form
    {
        public Acronyms()
        {
            InitializeComponent();
            comboBoxAcronym.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
    }
}
