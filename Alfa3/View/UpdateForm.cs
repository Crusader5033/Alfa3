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

namespace Alfa3.View
{
    public partial class UpdateForm : Form
    {
        private UtvarController utvarController = new UtvarController();
        private SluzbaController sluzbaController = new SluzbaController();
        public UpdateForm()
        {
           
            InitializeComponent();
            LoadUtvaryIntoDataGridView();
            LoadSluzbyIntoDataGridView();
        }
        private void LoadUtvaryIntoDataGridView()
        {
            // Call the ListVojaci method to get the DataTable
            var utvarDataTable = utvarController.Listutvary();

            // Check if the DataTable is not null
            if (utvarDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                utvarView.DataSource = utvarDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }

        private void LoadSluzbyIntoDataGridView()
        {
            // Call the ListVojaci method to get the DataTable
            var sluzbyDataTable = sluzbaController.ListSluzbyWithID();

            // Check if the DataTable is not null
            if (sluzbyDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                sluzbaView.DataSource = sluzbyDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }
        private void SluzbaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sluzbaView.SelectedRows.Count > 0)
                {
                    int selectedSluzbaId = Convert.ToInt32(sluzbaView.SelectedRows[0].Cells["id"].Value);

                    // Get the updated values from the textboxes
                    string updatedRole = newroleBox.Text;

                    // Call the UpdateSluzba method to update the Sluzba
                    // sluzbaController.UpdateSluzba(selectedSluzbaId, updatedRole);

                    // Reload the DataGridView to reflect the changes
                    LoadSluzbyIntoDataGridView();

                    MessageBox.Show("Sluzba byla aktualizována.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vyberte záznam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba při aktualizaci služby.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void utvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (utvarView.SelectedRows.Count > 0)
                {
                    int selectedUtvarId = Convert.ToInt32(utvarView.SelectedRows[0].Cells["id"].Value);

                    // Get the updated values from the textboxes
                    string updatedPusobiste = newPlaceBox.Text;

                    // Call the UpdateUtvar method to update the Utvar
                    utvarController.UpdateUtvarPusobiste(selectedUtvarId, updatedPusobiste);

                    // Reload the DataGridView to reflect the changes
                    LoadUtvaryIntoDataGridView();
                    MessageBox.Show("Utvar byl aktualizován.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vyberte záznam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba při aktualizaci útvaru.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
