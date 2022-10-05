using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsVisitPrague
{
    public partial class Gallery : Form
    {
        public Gallery()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true && label2.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label2.Visible = false;
                label3.Visible = true;
                label7.Visible = false;
                label8.Visible = true;
            }
            else if (pictureBox2.Visible == true && label3.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label8.Visible = false;
                label9.Visible = true;
            }
            else if (pictureBox3.Visible == true && label4.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                label4.Visible = false;
                label5.Visible = true;
                label9.Visible = false;
                label10.Visible = true;
            }
            else if (pictureBox4.Visible == true && label5.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label5.Visible = false;
                label6.Visible = true;
                label10.Visible = false;
                label11.Visible = true;
            }
            else if (pictureBox5.Visible == true && label6.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
                label6.Visible = false;
                label1.Visible = true;
                label11.Visible = false;
                label7.Visible = true;
            }
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            timer1.Start();
            History.add_history(this.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Ellisanthi!!");
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

        private void label13_Click(object sender, EventArgs e)
        {
            Form Destinations = new Destinations();
            Destinations.Show();
            Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form Form_Hotels = new Form_Hotels();
            Form_Hotels.Show();
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Gallery");
        }
    }
}
