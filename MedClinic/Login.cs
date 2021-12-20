using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedClinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kenjabaev\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30";
          
            string query = "Select * from UserTable where Uname = '" + UidTable.Text + "' and Upass =  '" + PassTable.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);


            if(UidTable.Text == "" || PassTable.Text == "")
            {
                MessageBox.Show("Enter Username or Password");
            }
            else if(dtb1.Rows.Count ==1)
            {
                this.Hide();
                Patient log = new Patient();
                log.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }         
            
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin log = new Admin();
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UidTable.Clear();
            PassTable.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection log = new Selection();
            log.Show();
        }
    }
}
