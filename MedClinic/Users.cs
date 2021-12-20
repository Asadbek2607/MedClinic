using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedClinic
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }


        // SAVE BUTTON
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string query = "insert into UserTable values('" + Uname.Text + "', '" + Upass.Text + "', '" + Phone.Text + "')";
            MyUsers Usr = new MyUsers();
            try
            {
                Usr.AddUser(query);
                MessageBox.Show("Patient Successfully Added");
                populate();
                clearForm();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // EDIT BUTTON

        private void editButton_Click(object sender, EventArgs e)
        {
            MyUsers Usr = new MyUsers();
            if (key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    string query = "Update UserTable set Uname ='" + Uname.Text + "',Upass ='" + Upass.Text + "',Phone ='" + Phone.Text + "' where Uid=" + key + "";

                    Usr.DeleteUser(query);
                    MessageBox.Show("User Successfully Updated");
                    populate();
                    clearForm();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // POPULATE
        void populate()
        {
            MyPatient Usr = new MyPatient();
            string query = "select * from UserTable";
            DataSet dataSet = Usr.ShowPatient(query);
            UsersDataGrid.DataSource = dataSet.Tables[0];
        }
       
        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;


        //USERS DATA GRID
        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uname.Text = UsersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UsersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Phone.Text = UsersDataGrid.SelectedRows[0].Cells[3].Value.ToString();

            if (Uname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        //DELETE BUTTON
        private void deleteButton_Click(object sender, EventArgs e)
        {
            MyUsers Usr = new MyUsers();
            if (key == 0)
            {
                MessageBox.Show("Select the User");
            }
            else
            {
                try
                {
                    string query = "delete from UserTable where Uid = " + key + "";

                    Usr.DeleteUser(query);
                    MessageBox.Show("User Successfully Deleted");
                    populate();
                    clearForm();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //clearing form
        void clearForm()
        {
            Uname.Clear();
            Upass.Clear();
            Phone.Clear();

        }


       // --------------------------------------------------------------------------

        // linking to another windows

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient log = new Patient();
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient log = new Patient();
            log.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection log = new Selection();
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Selection log = new Selection();
            log.Show();
        }

       
    }
}
