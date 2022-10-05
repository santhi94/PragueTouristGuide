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
    public partial class Registration_Form : Form
    {
        SQLiteConnection conn;

        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {
            //1.Create connectionString
            String connectionString = "Data Source=MYUSERS.db;Version=3";

            //2.Create connection
            conn = new SQLiteConnection(connectionString);

            //3.Open the connection to connect to DB
            conn.Open();

        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String name = textBox1.Text;
            String surname = textBox2.Text;
            String Date_Of_Birth = textBox7.Text;
            String Email = textBox6.Text;
            String Username = textBox5.Text;
            String Password = textBox4.Text;

            //4.Create a Command Object in order to execute SQL commands
            SQLiteCommand command = new SQLiteCommand(conn);

            //5.Wrire your SQL in a String 

          
       
           String insertSQL = "INSERT INTO User(name, surname, Date_Of_Birth, Email, Username, Password) VALUES(@name,@surname,@Date_Of_Birth,@Email,@Username,@Password)";

            //6.Execute the command

            command.CommandText = insertSQL;

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@Date_Of_Birth", Date_Of_Birth);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            command.Prepare();
            command.ExecuteNonQuery();

            Form Form_login = new Form_login();
            Form_login.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form Form_login = new Form_login();
            Form_login.Show();
            Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is designed by Sofia and Elisanthi");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "guide/_tmphhp/guide.chm", "Registration_form");

        }
    }
}
