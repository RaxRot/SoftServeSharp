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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            GetAboutInfo();
        }

        private void GetAboutInfo()
        {
            labelComanyName.Text = "Company: " + Application.CompanyName;
            labelProductName.Text = "Product Name: " + Application.ProductName;
            labelVersionname.Text = "Version: " + Application.ProductVersion;
            labelWebSite.Text = "WebSite:" + Properties.Settings.Default.siteUrl;
            labelProgramer.Text = "Developer:" + Properties.Settings.Default.programmerInfo;
        }
    }
}
