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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection log = new Selection();
            log.Show();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection log = new Selection();
            log.Show();
        }

        private void servicesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //PatName.Text = servicesDataGrid.SelectedRows[0].Cells[1].Value.ToString();
           // Clinics.Text = servicesDataGrid.SelectedRows[0].Cells[2].Value.ToString();
           // PatDistrict.Text = servicesDataGrid.SelectedRows[0].Cells[3].Value.ToString();
           // Service.Text = servicesDataGrid.SelectedRows[0].Cells[4].Value.ToString();
           
            
        }
        void populate()
        {
            MyServices Ser = new MyServices();
            string query = "select Patname as 'Patient Name'," +
                " PatDistrict," +
                " Service," +
                " PatAddress as 'Address'," +
                " Clinics"+
                " FROM PatientTable, ClinicsTable";



            DataSet dataSetService = Ser.ShowService(query);
            servicesDataGrid.DataSource = dataSetService.Tables[0];
        }
        private void Services_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
