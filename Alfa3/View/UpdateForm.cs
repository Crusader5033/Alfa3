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
        //Handles loading data do DataGridView for Utvary
        private void LoadUtvaryIntoDataGridView()
        {
            var utvarDataTable = utvarController.Listutvary();

            if (utvarDataTable != null)
            {
                utvarView.DataSource = utvarDataTable;
            }
            else
            {
                MessageBox.Show("Chyba při získávání dat z databáze.");
            }
        }
        //Handles loading data do DataGridView for Sluzby
        private void LoadSluzbyIntoDataGridView()
        {
            var sluzbyDataTable = sluzbaController.ListSluzbyWithID();

            if (sluzbyDataTable != null)
            {
                sluzbaView.DataSource = sluzbyDataTable;
            }
            else
            {
                MessageBox.Show("Chyba při získávání dat z databáze.");
            }
        }
        //WORk IN PROGRESS
        private void BtnSluzba_Click(object sender, EventArgs e)
        {
            try
            {
                if (sluzbaView.SelectedRows.Count > 0)
                {
                    int selectedSluzbaId = Convert.ToInt32(sluzbaView.SelectedRows[0].Cells["id"].Value);

                    string updatedRole = newroleBox.Text;

               
                    LoadSluzbyIntoDataGridView();

                    MessageBox.Show("Sluzba byla aktualizována.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vyberte záznam.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void sluzbaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newroleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
