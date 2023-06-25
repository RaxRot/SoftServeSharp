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
    public partial class Search : Form
    {
        string path = "Users.txt";
        public Search()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearchPhone.Text))
            {
                MessageBox.Show("Please enter Phone");
            }
            else
            {
                string phoneNumber = textBoxSearchPhone.Text;
                string fileContent = File.ReadAllText(path);

                string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    string[] values = line.Split(',');

                    if (values.Length >= 3 && values[2] == phoneNumber)
                    {
                        textBoxFirstName.Text = values[0];
                        textBoxLastName.Text = values[1];
                        textBoxPhone.Text = values[2];
                        textBoxEmail.Text = values[3];

                        buttonDeleate.Enabled = true;

                        return;
                    }
                }

                DontFindForm();
            }
            
        }

        private void DontFindForm()
        {
            MessageBox.Show("I dont have this contact");
           
            ResetTexts();
        }

        private void buttonDeleate_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBoxPhone.Text;

            string fileContent = File.ReadAllText(path);
            string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length >= 4 && values[2] == phoneNumber)
                {
                    lines[i] = string.Empty;
                    break;
                }
            }

            string newFileContent = string.Join(Environment.NewLine, lines);
            File.WriteAllText(path, newFileContent);
            
            ResetTexts();

            buttonDeleate.Enabled = false;

            MessageBox.Show("Data was deleted");
        }

        private void Search_Load(object sender, EventArgs e)
        {
            buttonDeleate.Enabled = false;
        }

        private void ResetTexts()
        {
            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();
            textBoxPhone.ResetText();
            textBoxEmail.ResetText();
        }
    }
}
