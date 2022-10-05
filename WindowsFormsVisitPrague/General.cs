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

namespace WindowsFormsVisitPrague
{
    public partial class General : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();

        public General()
        {
            InitializeComponent();
        }

        private void General_Load(object sender, EventArgs e)
        {
            History.add_history(this.Name);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Ellisanthi !!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "prague.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tospeak = label3.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tospeak2 = label4.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak2);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "general");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form Gallery = new Gallery();
            Gallery.Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form Events = new Events();
            Events.Show();
            Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form Form_Restaurants = new Form_Restaurants();
            Form_Restaurants.Show();
            Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form Form_Hotels = new Form_Hotels();
            Form_Hotels.Show();
            Hide();

        }

        private void label10_Click(object sender, EventArgs e)
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
