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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Πληροφορίες")
            {
                Form General = new General();
                General.Show();
                Hide();

            } else if (comboBox1.Text == "Αξιοθέατα")
            {
                Form Gallery = new Gallery();
                Gallery.Show();
                Hide();
            } else if (comboBox1.Text == "Εκδηλώσεις")
            {
                Form Events = new Events();
                Events.Show();
                Hide();

            }
            else if (comboBox1.Text == "Γαστρονομία")
            {
                Form Form_Restaurants = new Form_Restaurants();
                Form_Restaurants.Show();
                Hide();
            } else if (comboBox1.Text == "Διαμονή")
            {
                Form Form_Hotels = new Form_Hotels();
                Form_Hotels.Show();
                Hide();
            } else if (comboBox1.Text == "Προορισμοί")
            {
                Form Destinations = new Destinations();
                Destinations.Show();
                Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Elisanthi");
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

        private void Menu_form_Load(object sender, EventArgs e)
        {
            History.add_history(Name);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Menu_form");

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
