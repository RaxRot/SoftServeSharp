﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.My_Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginControll();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = Properties.Settings.Default.UserName;
        }

        private void LoginControll()
        {
            if (textBoxPasword.Text == Properties.Settings.Default.UserPass)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect values!");
            }
        }
    }

}
