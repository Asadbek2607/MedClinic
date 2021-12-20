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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (UidTable.Text == "" || PassTable.Text == "")
            {
                MessageBox.Show("Enter Username or Password");
            }
            else if (UidTable.Text == "b1904039" || PassTable.Text == "b1904039")
            {

                this.Hide();
                Users log = new Users();
                log.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
