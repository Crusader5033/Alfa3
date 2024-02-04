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
    public partial class DeleteForm : Form
    {

         VojakController vojakController = new VojakController();
         SluzbaController sluzbaController = new SluzbaController();
         UtvarController utvarController = new UtvarController();
        ZkouskaController zkouskaController = new ZkouskaController();
        public DeleteForm()
        {
            InitializeComponent();
            LoadUtvaryIntoDataGridView();
            LoadSluzbyIntoDataGridView();
            LoadVojaciIntoDataGridView();
        }


        private void LoadUtvaryIntoDataGridView()
        {
            // Call the ListVojaci method to get the DataTable
            var utvarDataTable = utvarController.Listutvary();

            // Check if the DataTable is not null
            if (utvarDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridViewUtvar.DataSource = utvarDataTable;
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
                dataGridViewSluzba.DataSource = sluzbyDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }

        private void LoadVojaciIntoDataGridView()
        {
            var vojaciDataTable = vojakController.ListVojaci();

            // Check if the DataTable is not null
            if (vojaciDataTable != null)
            {
                // Bind the DataTable to the DataGridView
                dataGridViewVojak.DataSource = vojaciDataTable;
            }
            else
            {
                // Handle the case when the DataTable is null or an error occurs
                MessageBox.Show("Error retrieving data from the database.");
            }
        }
    
        private void VojakBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVojak.SelectedRows.Count > 0)
                {
                    // Get the selected Vojak's ID from the DataGridView
                    int selectedVojakId = Convert.ToInt32(dataGridViewVojak.SelectedRows[0].Cells["id"].Value);

                    // Show a confirmation dialog
                    DialogResult result = MessageBox.Show("Opravdu chcete tento zaznam smazat?", "Povrzeni", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // If user confirms the deletion, proceed with deletion
                    if (result == DialogResult.Yes)
                    {
                        // Delete the selected Vojak from the database
                        sluzbaController.DeleteSluzbyByVojakId(selectedVojakId);
                        zkouskaController.DeleteZkouskaByVojakId(selectedVojakId);
                        vojakController.DeleteVojak(selectedVojakId);

                        // Reload the DataGridView to reflect the changes
                        LoadVojaciIntoDataGridView();

                        MessageBox.Show("Vojak byl odstraněn.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vyberte záznam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastal problem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUtvar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSluzba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVojak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sluzbaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSluzba.SelectedRows.Count > 0)
                {
                    int selectedSluzbaId = Convert.ToInt32(dataGridViewSluzba.SelectedRows[0].Cells["id"].Value);

                    DialogResult result = MessageBox.Show("Opravdu chcete smazat tento zaznam?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        sluzbaController.DeleteSluzba(selectedSluzbaId);
                        LoadSluzbyIntoDataGridView();
                        MessageBox.Show("Záznam byl úspěšně odstraněn.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vyberte záznam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void utvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUtvar.SelectedRows.Count > 0)
                {
                    int selectedUtvarId = Convert.ToInt32(dataGridViewUtvar.SelectedRows[0].Cells["id"].Value);

                    DialogResult result = MessageBox.Show("Opravdu chcete smazat tento utvar?", "Potvrzeni", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        sluzbaController.DeleteSluzbyByVojakId(selectedUtvarId);

                        utvarController.DeleteUtvar(selectedUtvarId);
                        LoadUtvaryIntoDataGridView();
                        MessageBox.Show("Utvar byl úspěšně odstraněn.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vyberte záznam.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
