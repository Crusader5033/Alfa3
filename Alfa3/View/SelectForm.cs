using Alfa3.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alfa3.Controller;
namespace Alfa3.View
{
    public partial class SelectForm : Form

        
    {
        VojakController vojakController = new VojakController();
        RoleController roleController = new RoleController();
        UtvarController utvarController = new UtvarController();
        SpecializaceController specializaceController = new SpecializaceController();
        SluzbaController sluzbaController = new SluzbaController();
        ZkouskaController zkouskaController = new ZkouskaController();
        public SelectForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectVojaci_Click(object sender, EventArgs e)
        {
            // Call the ListVojaci method to get the DataTable
            var vojaciDataTable = vojakController.ListVojaci();

            // Check if the DataTable is not null
            if (vojaciDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = vojaciDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Chyba při získávání dat z databáze.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var roleDataTable = roleController.ListRole();

            // Check if the DataTable is not null
            if (roleDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = roleDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }

        private void UtvaryBtn_Click(object sender, EventArgs e)
        {
            var utvarDataTable = utvarController.Listutvary();

            // Check if the DataTable is not null
            if (utvarDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = utvarDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }

        private void SpecializaceBtn_Click(object sender, EventArgs e)
        {
            var specializaceDataTable = specializaceController.ListSpecializace();

            // Check if the DataTable is not null
            if (specializaceDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = specializaceDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }

        private void SluzbyBtn_Click(object sender, EventArgs e)
        {
            var sluzbyDataTable = sluzbaController.ListSluzby();

            // Check if the DataTable is not null
            if (sluzbyDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = sluzbyDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Chyba při získávání dat z databáze.");
            }
        }

        private void VojaciSpecializaceBtn_Click(object sender, EventArgs e)
        {
            var vojaciSpecializaceDataTable = vojakController.ListVojaciSpecializace();

            // Check if the DataTable is not null
            if (vojaciSpecializaceDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = vojaciSpecializaceDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Chyba při získávání dat z databáze.");
            }
        }

        private void ZkouskaBtn_Click(object sender, EventArgs e)
        {
            var zkouskyDataTable = zkouskaController.ListZkousky();

            // Check if the DataTable is not null
            if (zkouskyDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = zkouskyDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Chyba při získávání dat z databáze.");
            }
        }
    }
    }








    

