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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }


        // Nurse Selected 
        void SelectionNurse()
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
        private void pictureBoxNurse_Click(object sender, EventArgs e)
        {
            SelectionNurse();           
        }

        private void labelNurse_Click(object sender, EventArgs e)
        {
            SelectionNurse();
        }
        // -----------------------------------------------------------------------



        // Patient Selected 
        void SelectionPatient()
        {
            this.Hide();
            Services log = new Services();
            log.Show();
        }


        private void pictureBoxPat_Click(object sender, EventArgs e)
        {
            SelectionPatient();
        }

        private void labelPatient_Click(object sender, EventArgs e)
        {
            SelectionPatient();
        }

        // -----------------------------------------------------------------------

        // Admin Selected 

        void SelectionAdmin()
        {
            this.Hide();
            Admin log = new Admin();
            log.Show();
        }

        private void pictureBoxAdmin_Click(object sender, EventArgs e)
        {
            SelectionAdmin();
        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {
            SelectionAdmin();
        }

        // -----------------------------------------------------
    }
}
