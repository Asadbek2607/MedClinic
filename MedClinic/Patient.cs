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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }


        //SAVE BUTTON
        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "insert into PatientTable values('"+PatName.Text + "', '" + PatPhone.Text + "', '" + PatAddress.Text + "','" + PatDistrict.SelectedItem.ToString() + "','" + Service.SelectedItem.ToString() + "')";
            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Patient Successfully Added");
                populate();
                clearForm();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select PatName,PatPhone,PatAddress,PatDistrict,Service from PatientTable";
            DataSet ds = Pat.ShowPatient(query);
            PatientDataGrid.DataSource = ds.Tables[0];
        }
        private void Patient_Load_1(object sender, EventArgs e)
        {
           
            populate();
        }
        int key = 0;


        //PATIENT DATA GRID
        private void PatientDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatName.Text = PatientDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PatPhone.Text = PatientDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PatAddress.Text = PatientDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PatDistrict.Text = PatientDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Service.Text = PatientDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            
            if (PatName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }


        }


        //DELETE BUTTON
        private void deleteButton_Click(object sender, EventArgs e)
        {

            MyPatient Pat = new MyPatient();
            if (key ==0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    string query = "delete from PatientTable where PatId = " + key + "";
                    
                    Pat.DeletePatient(query);
                    MessageBox.Show("Patient Successfully Deleted");
                    populate();
                    clearForm();
                    
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
          
        }

        //clearing form
        void clearForm()
        {
            PatName.Clear();
            PatAddress.Clear();
            PatPhone.Clear();
            

         
        }


        // EDIT BUTTON
        private void editButton_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                try
                {
                    string query = "Update PatientTable set PatName ='"+PatName.Text+ "',PatAddress ='" + PatAddress.Text + "',PatPhone ='" + PatPhone.Text + "',Service ='" + Service.SelectedItem.ToString() + "',PatDistrict ='" + PatDistrict.SelectedItem.ToString() + "' where PatId="+key+"";

                    Pat.DeletePatient(query);
                    MessageBox.Show("Patient Successfully Updated");
                    populate();
                    clearForm();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

       public void HomePage()
        {
            Selection log = new Selection();
            log.Show();
        }
       
               
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomePage();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage();
        }
    }
}
