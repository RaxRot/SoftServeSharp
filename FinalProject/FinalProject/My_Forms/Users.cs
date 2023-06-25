using System;
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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName=textBoxUserName.Text;
            Properties.Settings.Default.UserPass=textBoxPasword.Text;

            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Name field cant be empty");
            }else if(textBoxPasword.Text != textBoxConfirmPasword.Text)
            {
                MessageBox.Show("Passwords are not the same");
            }
            else
            {
                Properties.Settings.Default.Save();
                MessageBox.Show("Done");
            }

        }

        private void Users_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text=Properties.Settings.Default.UserName;
            textBoxPasword.Text = Properties.Settings.Default.UserPass;
        }
    }
}

