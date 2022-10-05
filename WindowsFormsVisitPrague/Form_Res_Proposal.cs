using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace WindowsFormsVisitPrague
{
    public partial class Form_Res_Proposal : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Form_Res_Proposal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tospeak1 = label1.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tospeak2 = label2.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tospeak3 = label2.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak3);
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void Form_Res_Proposal_Load(object sender, EventArgs e)
        {
            History.add_history(this.Name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("devinis.txt");
            sw.WriteLine(label4.Text);
            sw.Close();
            MessageBox.Show("Date save to file");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Hergetova_Cihelna.txt");
            sw.WriteLine(label5.Text);
            sw.Close();
            MessageBox.Show("Date save to file");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Estrella.txt");
            sw.WriteLine(label6.Text);
            sw.Close();
            MessageBox.Show("Date save to file");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Elisanthi");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Visible = true;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Visible = true; 
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            button6.Visible = true;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Visible = true;
        }

    
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            button7.Visible = true;
        }

        
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            button7.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form General = new General();
            General.Show();
            Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form Events = new Events();
            Events.Show();
            Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Form Form_Restaurants = new Form_Restaurants();
            Form_Restaurants.Show();
            Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Form_Res_Proposal");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form Form_Hotels = new Form_Hotels();
            Form_Hotels.Show();
            Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form Destinations = new Destinations();
            Destinations.Show();
            Hide();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string St = "";
            foreach (string s in History.history_list)
            {
                St += s;
                St += "\n";
            }
            MessageBox.Show(St);
        }
    }
 }