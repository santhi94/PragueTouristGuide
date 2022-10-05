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
    public partial class Destinations : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Destinations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Κάρλοβι βάρι" || textBox1.Text == "Καρλοβι βαρι" || textBox1.Text == "καρλοβι βαρι" || textBox1.Text == "ΚΑΡΛΟΒΙ ΒΑΡΙ")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel2.Visible = true;
            }
            else if (textBox1.Text == "Μπρνο" || textBox1.Text == "μπρνο" || textBox1.Text == "ΜΠΡΝΟ")
            {
                panel4.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else if (textBox1.Text == "Όλομουτς" || textBox1.Text == "Ολομουτς" || textBox1.Text == "όλομουτς" || textBox1.Text == "ΟΛΟΜΟΥΤΣ")
            {
                panel5.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
            }
            else if (textBox1.Text == "Πιλσεν" || textBox1.Text == "πίλσεν" || textBox1.Text == "ΠΙΛΣΕΝ" || textBox1.Text == "πιλσεν")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;

            }
            else
            {
                MessageBox.Show("Προσοχή!Παρακαλώ εισάγεται σωστά τον προορισμό");
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tospeak = label2.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Visible = true;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tospeak2 = label3.Text;
            speech.SelectVoice("Microsoft Stefanos");
            speech.Speak(tospeak2);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "destinations");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Ellisanthi!!");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form Gallery = new Gallery();
            Gallery.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form General = new General();
            General.Show();
            Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form Events = new Events();
            Events.Show();
            Hide();
        }

        private void label14_Click(object sender, EventArgs e)
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

        private void Destinations_Load(object sender, EventArgs e)
        {
            History.add_history(this.Name);
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
