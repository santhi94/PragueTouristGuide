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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            History.add_history(this.Name);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            if (date == "06-10-2021" || date == "12-10-2021" || date == "18-10-2021" || date == "21-10-2021" || date == "23-10-2021")
            {
                MessageBox.Show("Gala Show στο Aqua Park Čestlice\n Ώρα 21:00");
            }
            else if (date == "07-10-2021" || date == "13-10-2021" || date == "19-10-2021" || date == "22-10-2021" || date == "24-10-2021")
            {
                MessageBox.Show("Gala δείπνο για το MAPFRE στο Palace Žofín \n Ώρα 22:00");
            }
            else if (date == "08-10-2021" || date == "14-10-2021" || date == "20-10-2021" || date == "25-10-2021" || date == "26-10-2021")
            {
                MessageBox.Show("Έκθεση του graffity artist BANKSY στο στούντιο κινηματογράφου Barrandov\n Ώρα 18:00 ");

            }
            else if (date == "09-10-2021" || date == "10-10-2021" || date == "15-10-2021" || date == "17-10-2021" || date == "28-10-2021")
            {
                MessageBox.Show("Εκδηλώσεις Golden Prague στο Ξενοδοχείο Hilton\n Ώρα 19:00");

            }
            else if (date == "11-10-2021" || date == "16-10-2021" || date == "27-10-2021" || date == "29-10-2021" || date == "30-10-2021" || date == "31-10-2021")
            {
                MessageBox.Show("Αφιέρωμα στην γερμανόφωνη μουσική στο Prague National Theater Opera \n Ώρα 18:00");

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form General = new General();
            General.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form Gallery = new Gallery();
            Gallery.Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Ellisanthi!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Form Destinations = new Destinations();
            Destinations.Show();
            Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "events");
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
