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
    public partial class General2 : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public General2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form Form_Hotels2 = new Form_Hotels2();
            Form_Hotels2.Show();
            Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Elisanthi");

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "general");

        }

        private void General2_Load(object sender, EventArgs e)
        {
            History.add_history(this.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "prague.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
    }
}
