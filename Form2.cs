using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Talking_Watch
{
    public partial class Form2 : Form
    {
        readonly Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

       
        public Form2()
        {
            InitializeComponent();
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void B_Start_Click(object sender, EventArgs e)
        {
            StatusButton.Text = "Alarm is: start";
            timer1.Start();
            b_Start1.Enabled = false;
        }

        private void B_Stop_Click(object sender, EventArgs e)
        {
            StatusButton.Text = "Alarm is: stop";
            b_Start1.Enabled = true;
            b_Stop1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            timer2.Start();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }





        private void timer1_Tick(object sender, EventArgs e)
        {


            DateTime currTime = DateTime.Now;
            DateTime alarmTime = default;
            alarmTime = dateTimePicker1.Value;
            string text1 = textBox1.Text;
       


            if (currTime.Hour == alarmTime.Hour && currTime.Minute == alarmTime.Minute && currTime.Second == alarmTime.Second)
            {
                timer1.Stop();

                

                SpeechSynthesizer synth_al2 = new SpeechSynthesizer();
                synth_al2.SelectVoice("Microsoft David Desktop");
                

                Thread thread = new Thread(() =>
                {
                    synth_al2.Speak(text1);
                });
                thread.Start();
            }

            Properties.Settings.Default.AlertTextBoxSave1 = text1 ;
            Properties.Settings.Default.AlertTimeSave1 = alarmTime;
            Properties.Settings.Default.Save();

          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker(object sender, EventArgs e)
        {

        }

        private void Start2_Click(object sender, EventArgs e)
        {
            StatusButton2.Text = "Alarm is: start";
            timer1.Start();
            b_Start2.Enabled = false;
        }

        private void Stop2_Click(object sender, EventArgs e)
        {
            StatusButton2.Text = "Alarm is: stop";
            b_Start2.Enabled = true;
            b_Stop2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateTime alarmTime2 = default;
            alarmTime2 = dateTimePicker2.Value;
          
            string text2 = textBox2.Text;

            if (currTime.Hour == alarmTime2.Hour && currTime.Minute == alarmTime2.Minute && currTime.Second == alarmTime2.Second)
            {
                timer2.Stop();

              

                SpeechSynthesizer synth_2 = new SpeechSynthesizer();
                synth_2.SelectVoice("Microsoft David Desktop");


                Thread thread = new Thread(() =>
                {
                    synth_2.Speak(text2);
                });
                thread.Start();
            }
            Properties.Settings.Default.AlertTextBoxSave2 = text2;
            Properties.Settings.Default.AlertTimeSave2 = alarmTime2;
            Properties.Settings.Default.Save();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            timer3.Start();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            timer4.Start();
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {
            timer5.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateTime alarmTime3 = default;
            alarmTime3 = dateTimePicker3.Value;

            string text3 = textBox3.Text;

            if (currTime.Hour == alarmTime3.Hour && currTime.Minute == alarmTime3.Minute && currTime.Second == alarmTime3.Second)
            {
                timer3.Stop();


                SpeechSynthesizer synth_3 = new SpeechSynthesizer();
                synth_3.SelectVoice("Microsoft David Desktop");


                Thread thread = new Thread(() =>
                {
                    synth_3.Speak(text3);
                });
                thread.Start();
            }

            Properties.Settings.Default.AlertTextBoxSave3 = text3;
            Properties.Settings.Default.AlertTimeSave3 = alarmTime3;
            Properties.Settings.Default.Save();
        }

        private void Start3_Click(object sender, EventArgs e)
        {
            StatusButton3.Text = "Alarm is: start";
            timer3.Start();
            b_Start3.Enabled = false;
        }

        private void Stop3_Click(object sender, EventArgs e)
        {
            StatusButton3.Text = "Alarm is: stop";
            b_Start3.Enabled = true;
            b_Stop3.Enabled = false;
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            StatusButton3.Text = "Alarm is: start";
            timer1.Start();
            b_Start1.Enabled = false;
        }

        private void b_Stop1_Click(object sender, EventArgs e)
        {
            StatusButton3.Text = "Alarm is: stop";
            b_Start1.Enabled = true;
            b_Stop1.Enabled = false;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateTime alarmTime3 = default;
            alarmTime3 = dateTimePicker3.Value;

            if (currTime.Hour == alarmTime3.Hour && currTime.Minute == alarmTime3.Minute && currTime.Second == alarmTime3.Second)
            {
                timer3.Stop();

                string text3 = textBox3.Text;

                SpeechSynthesizer synth_3 = new SpeechSynthesizer();
                synth_3.SelectVoice("Microsoft David Desktop");


                Thread thread = new Thread(() =>
                {
                    synth_3.Speak(text3);
                });
                thread.Start();
            }
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateTime alarmTime4 = default;
            alarmTime4 = dateTimePicker4.Value;
            string text4 = textBox4.Text;

            if (currTime.Hour == alarmTime4.Hour && currTime.Minute == alarmTime4.Minute && currTime.Second == alarmTime4.Second)
            {
                timer3.Stop();

                

                SpeechSynthesizer synth_4 = new SpeechSynthesizer();
                synth_4.SelectVoice("Microsoft David Desktop");

                Thread thread = new Thread(() =>
                {
                    synth_4.Speak(text4);
                });
                thread.Start();
            }

            Properties.Settings.Default.AlertTextBoxSave4 = text4;
            Properties.Settings.Default.AlertTimeSave4 = alarmTime4;
            Properties.Settings.Default.Save();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void b_Start4_Click(object sender, EventArgs e)
        {
            StatusButton4.Text = "Alarm is: start";
            timer4.Start();
            b_Start4.Enabled = false;
        }

        private void b_Stop4_Click(object sender, EventArgs e)
        {
            StatusButton4.Text = "Alarm is: stop";
            b_Start4.Enabled = true;
            b_Stop4.Enabled = false;
        }

        private void b_Start5_Click(object sender, EventArgs e)
        {
            StatusButton5.Text = "Alarm is: start";
            timer5.Start();
            b_Start5.Enabled = false;
        }

        private void b_Stop5_Click(object sender, EventArgs e)
        {
            StatusButton5.Text = "Alarm is: stop";
            b_Start5.Enabled = true;
            b_Stop5.Enabled = false;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateTime alarmTime5 = default;
            alarmTime5 = dateTimePicker5.Value;
            string text5 = textBox5.Text;

            if (currTime.Hour == alarmTime5.Hour && currTime.Minute == alarmTime5.Minute && currTime.Second == alarmTime5.Second)
            {
                timer3.Stop();

               
                

                SpeechSynthesizer synth_5 = new SpeechSynthesizer();
                //synth_5.SelectVoice("Microsoft David Desktop");

                
                Thread thread = new Thread(() =>
                {
                    synth_5.Speak(text5);
                });
                thread.Start();
            }

            Properties.Settings.Default.AlertTextBoxSave5 = text5;
            Properties.Settings.Default.AlertTimeSave5 = alarmTime5;
            Properties.Settings.Default.Save();
        }
      

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.AlertTextBoxSave1;
            dateTimePicker1.Value = Properties.Settings.Default.AlertTimeSave1;


            textBox2.Text = Properties.Settings.Default.AlertTextBoxSave2;
            dateTimePicker2.Value = Properties.Settings.Default.AlertTimeSave2;

            textBox3.Text = Properties.Settings.Default.AlertTextBoxSave3;
            dateTimePicker3.Value = Properties.Settings.Default.AlertTimeSave3;

            textBox4.Text = Properties.Settings.Default.AlertTextBoxSave4;
            dateTimePicker4.Value = Properties.Settings.Default.AlertTimeSave4;

            textBox5.Text = Properties.Settings.Default.AlertTextBoxSave5;
            dateTimePicker5.Value = Properties.Settings.Default.AlertTimeSave5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F = Application.OpenForms["Form1"];
            F.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
