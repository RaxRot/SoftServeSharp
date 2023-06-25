using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject.My_Forms
{
    public partial class ShowData : Form
    {
        private List<string[]> contacts;
        private int currentContactIndex;

        public ShowData()
        {
            InitializeComponent();
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            contacts = LoadContactsFromFile();
            if (contacts.Count > 0)
            {
                currentContactIndex = 0; 
                DisplayCurrentContact(); 
            }
            else
            {
                DisplayNoContact(); 
            }
        }

        private List<string[]> LoadContactsFromFile()
        {
            List<string[]> contacts = new List<string[]>();

            string[] lines = File.ReadAllLines("Users.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                contacts.Add(values);
            }

            return contacts;
        }

        private void DisplayCurrentContact()
        {
            string[] currentContact = contacts[currentContactIndex];
            
            textBoxFirstName.Text = currentContact[0];
            textBoxLastName.Text = currentContact[1];
            textBoxPhone.Text = currentContact[2];
            textBoxEmail.Text = currentContact[3];
        }

        private void DisplayNoContact()
        {
            
            textBoxFirstName.Text = "-";
            textBoxLastName.Text = "-";
            textBoxPhone.Text = "-";
            textBoxEmail.Text = "-";
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (currentContactIndex > 0)
            {
                currentContactIndex--; 
                DisplayCurrentContact(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentContactIndex < contacts.Count - 1)
            {
                currentContactIndex++; 
                DisplayCurrentContact(); 
            }
        }
    }
}
