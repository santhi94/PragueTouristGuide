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
    public partial class Form_Hotels2 : Form
    {
        public Form_Hotels2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Απαιτείται εγγραφή");
        }

        private void label15_Click(object sender, EventArgs e)
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
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Hotel");
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

        private void Form_Hotels2_Load(object sender, EventArgs e)
        {

            History.add_history(this.Name);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Form General2 = new General2();
            General2.Show();
            Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
     
}
