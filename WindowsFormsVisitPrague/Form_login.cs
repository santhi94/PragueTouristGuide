using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsVisitPrague
{
    public partial class Form_login : Form
    {
        SQLiteConnection conn;
        public Form_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {

                MessageBox.Show("Απαιτείται Όνομα και/ή Κωδικός Χρήστη!");
                return;
            }


            //4.Create a Command Object in order to execute SQL commands
            SQLiteCommand command = new SQLiteCommand(conn);


            //5.Wrire your SQL in a String 
            String selectSQL = "SELECT * from User WHERE Username=@Username AND Password=@Password ";

            //6.Create a reader object in order to store the returning results 
            command.CommandText = selectSQL;
            command.Parameters.AddWithValue("@Username", textBox1.Text);
            command.Parameters.AddWithValue("@Password", textBox2.Text);
            command.Prepare();

            SQLiteDataReader reader = command.ExecuteReader();


            //7.With a loop iterate through the results of the reader

            if (reader.HasRows)
            {

                Form Menu_form = new Menu_form();
                Menu_form.Show();
                Hide();

  
            }
            else
            {
                MessageBox.Show("Εχετε εισάγει λάθος Όνομα ή/και Κωδικό Χρήστη");
            }
            reader.Close();
        }

           
        

        private void Form_login_Load(object sender, EventArgs e)
        {

            //1.Create connectionString
            String connectionString = "Data Source=MYUSERS.db;Version=3";

            //2.Create connection
            conn = new SQLiteConnection(connectionString);

            //3.Open the connection to connect to DB
            conn.Open();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form Registration_form = new Registration_Form();
            Registration_form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Menu_form2 = new Menu_form2();
            Menu_form2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Elisanthi");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Yann Tiersen - Le Banquet.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Form_login");
        }
    }
}
