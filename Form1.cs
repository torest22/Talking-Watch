using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;


namespace Talking_Watch
{
    public partial class Form1 : Form
    {
        Form mdiChildForm = new Form();

        private void Form1_Load(object sender, System.EventArgs e)
        {

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
          //  SetBackGroundColorOfMDIForm();
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

       

      

        public Form1 TheForm1;

        private void B_new_wind_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Form2(this).Show();
           


            // B_new_wind.Enabled = false;
            // B_new_wind.Enabled = true;


        }
        
       



        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

       

        private void TimeSec_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm");
            TimeSec.Text = DateTime.Now.ToString("ss");
            Date.Text = DateTime.Now.ToString("dd MMM yyyy");
            Week.Text = DateTime.Now.ToString("dddd");
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

    }
}
