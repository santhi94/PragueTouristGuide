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
    public partial class Form_Restaurants : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Form_Restaurants()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form_Res_Proposal = new Form_Res_Proposal();
            Form_Res_Proposal.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tospeak = label1.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Elisanthi");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form General = new General();
            General.Show();
            Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Form Gallery = new Gallery();
            Gallery.Show();
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

        private void Form_Restaurants_Load(object sender, EventArgs e)
        {
            History.add_history(this.Name);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Form_Restaurants");
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
    }
}
