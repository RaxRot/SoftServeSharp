using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMinMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Do you want to exit?", "Exit",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           My_Forms.Login loginForm=new My_Forms.Login();
            loginForm.ShowDialog();

           GetTime();

           GetCalendarDate();
        }

        private void GetTime()
        {
            this.labelClock.Text = DateTime.Now.ToString("HH:mm");
        }

        private void GetCalendarDate()
        {
            System.Globalization.GregorianCalendar gregorianCalendar 
                = new System.Globalization.GregorianCalendar();
            System.Globalization.CultureInfo englishCulture 
                = new System.Globalization.CultureInfo("en-US");

            
            DateTime currentDate = DateTime.Now;

            
            labelMonth.Text = englishCulture.DateTimeFormat.GetMonthName(gregorianCalendar.GetMonth(currentDate));
            labelDayInt.Text = gregorianCalendar.GetDayOfMonth(currentDate).ToString();
            labelDayStr.Text = gregorianCalendar.GetDayOfWeek(currentDate).ToString();

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           My_Forms.AboutUs aboutUsForm = new My_Forms.AboutUs();
           aboutUsForm.MdiParent = this;
           aboutUsForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Forms.Users userForm= new My_Forms.Users();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            My_Forms.AddData addData = new My_Forms.AddData();
            addData.MdiParent = this;
            addData.Show();
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            My_Forms.Search search = new My_Forms.Search();
            search.MdiParent = this;
            search.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Forms.Help helpForm = new My_Forms.Help();
            helpForm.MdiParent = this;
            helpForm.Show();
        }

        private void toolStripButtonCalculator_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void toolStripButtonAll_Click(object sender, EventArgs e)
        {
            My_Forms.ShowData showData = new My_Forms.ShowData();
            showData.MdiParent = this;
            showData.Show();
        }
    }
}
