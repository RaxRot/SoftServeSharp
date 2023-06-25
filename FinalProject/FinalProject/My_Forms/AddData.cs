using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject.My_Forms
{
    public partial class AddData : Form
    {

        string path = "Users.txt";

        public AddData()
        {
            InitializeComponent();
        }

        private void toolStripButtonAddData_Click(object sender, EventArgs e)
        {
            ClickButton(false, true);

            groupBoxInformation.Enabled = true;
           
        }

        private void toolStripButtonSaveData_Click(object sender, EventArgs e)
        {
            ClickButton(true, false);

            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please fill Name");
            }
            else if (string.IsNullOrEmpty(textBoxTel.Text))
            {
                MessageBox.Show("Please fill tel");
            }
            else if (!textBoxTel.Text.StartsWith("+"))
            {
                MessageBox.Show("Please enter + in phone");
            }
            else if (!textBoxEmail.Text.Contains("@") && !string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Email must Contain @");
            }
            else
            {
                string fileContent = File.ReadAllText(path);
                string phoneNumber = textBoxTel.Text;

                if (IsPhoneNumberExists(fileContent, phoneNumber))
                {
                    MessageBox.Show("Phone number already exists");
                }
                else
                {
                    Person person = new Person();
                    person.FirstName = textBoxFirstName.Text;
                    person.LastName = textBoxLastName.Text;
                    person.Tel = phoneNumber;
                    person.Email = textBoxEmail.Text;

                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                    {
                        streamWriter.WriteLine(person.FirstName + "," + person.LastName +
                            "," + person.Tel + "," + person.Email);

                        MessageBox.Show("Added");
                    }
                }
            }

            ClearValues();

            groupBoxInformation.Enabled = false;
        }

        private bool IsPhoneNumberExists(string fileContent, string phoneNumber)
        {
            string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                if (values.Length >= 3 && values[2] == phoneNumber)
                {
                    return true;
                }
            }

            return false;
        }

        private void ClickButton(bool addBuuton,bool saveButton)
        {
            this.toolStripButtonAddData.Enabled = addBuuton;
            this.toolStripButtonSaveData.Enabled = saveButton;
        }

        private void ClearValues()
        {
            textBoxFirstName.ResetText();
            textBoxLastName.ResetText();
            textBoxTel.ResetText();
            textBoxEmail.ResetText();
        }

        private void AddData_Load(object sender, EventArgs e)
        {
            groupBoxInformation.Enabled = false;
        }
    }
}
