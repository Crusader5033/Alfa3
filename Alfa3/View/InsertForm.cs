using Alfa3.Controller;
using Alfa3.Model;
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
    public partial class InsertForm : Form
    {

        VojakController vojakController = new VojakController();
        RoleController roleController = new RoleController();
        UtvarController utvarController = new UtvarController();
        SpecializaceController specializaceController = new SpecializaceController();
        SluzbaController sluzbaController = new SluzbaController();
        ZkouskaController zkouskaController = new ZkouskaController();
        private DataTable vojaciList;
        private DataTable utvaryList;
        private DataTable roleList;
        private DataTable specializaceList;
        public InsertForm()
        {
            InitializeComponent();
            LoadVojaciIntoComboBox(SoldierCombo);
            LoadUtvaryIntoComboBox(UtvarCombo);
            LoadRoleIntoComboBox(RoleCombo);
            LoadVojaciIntoComboBox(VojakCombo);
            LoadSpecializaceIntoComboBox(specializaceCombo);
            
        }
        private void LoadSpecializaceIntoComboBox(ComboBox comboBoxName)
        {
            specializaceList = specializaceController.ListSpecializace();

            comboBoxName.DataSource = specializaceList;
            comboBoxName.DisplayMember = "Nazev_specializace";
            comboBoxName.ValueMember = "Id";
        }
        private void LoadVojaciIntoComboBox(ComboBox comboBoxName)
        {
            vojaciList = vojakController.ListVojaci();

            comboBoxName.DataSource = vojaciList;
            comboBoxName.DisplayMember = "Prijmeni";
            comboBoxName.ValueMember = "Id";
        }

        private void LoadUtvaryIntoComboBox(ComboBox comboBoxName)
        {
            utvaryList = utvarController.Listutvary();

            comboBoxName.DataSource = utvaryList;
            comboBoxName.DisplayMember = "Nazev_utvaru";
            comboBoxName.ValueMember = "Id";
        }

        private void LoadRoleIntoComboBox(ComboBox comboBoxName)
        {
            roleList = roleController.ListRole();

            comboBoxName.DataSource = roleList;
            comboBoxName.DisplayMember = "Nazev_role";
            comboBoxName.ValueMember = "Id";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeploymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddVojak_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            DateTime date = monthCalendar1.SelectionStart;
            Single height;
            try
            {
            if (Single.TryParse(HeightBox.Text, out height))
            {
                bool deploy = DeploymentCheckBox.Checked;

                vojakController.AddVojak(name, surname, date, height, deploy);
                MessageBox.Show("Vojak byl úspěšně přidán.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Neplatná hodnota pro výšku.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se přidat vojáka", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void RoleBtn_Click(object sender, EventArgs e)
        {
            string name = RoleBox.Text;
            try
            {
            roleController.AddRole(name);
            MessageBox.Show("Role byla úspěšně přidána.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)        
            {
                MessageBox.Show("Nepodařilo se přidat roli", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void UtvarBtn_Click(object sender, EventArgs e)
        {
            string name = nameBoxUtvar.Text;
            string type = typeBox.Text;
            string place = placeBox.Text;
            try
            {
                if (name.Length>=3)
                {
                    utvarController.AddUtvar(name, type, place);
                    MessageBox.Show("Útvar byl úspěšně přidána.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Je nutné zadat jmeno útvaru", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se přidat útvar", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SpecializaceBtn_Click(object sender, EventArgs e)
        {
            string name = nameSpecializaceBox.Text;
            string desc = decsBox.Text;
            try
            {
                if (name.Length >= 3)
                {
                    specializaceController.AddSpecializace(name, desc);
                    MessageBox.Show("Specializace byla úspěšně přidána.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Je nutné zadat jmeno specializace", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se přidat specializaci", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UtvarCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SoldierCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromPick_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void UntilPick_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void SluzbaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected Vojak and Utvar IDs from ComboBoxes
                int selectedVojakId = Convert.ToInt32(SoldierCombo.SelectedValue);
                int selectedUtvarId = Convert.ToInt32(UtvarCombo.SelectedValue);
                int selectedRoleId = Convert.ToInt32(RoleCombo.SelectedValue);

                // Get other data from your form as needed
                DateTime dateNastupu = FromPick.SelectionStart;
                DateTime dateOdchodu = UntilPick.SelectionStart;

                // Use the selected IDs to add a new Sluzba
                sluzbaController.AddSluzba(selectedVojakId, selectedUtvarId,selectedRoleId, dateNastupu, dateOdchodu);

                MessageBox.Show("Sluzba byla úspěšně přidána.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se přidat sluzbu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KZPVojakBtn_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            DateTime date = monthCalendar1.SelectionStart;
            Single height;
            try
            {
                if (Single.TryParse(HeightBox.Text, out height))
                {
                    bool deploy = DeploymentCheckBox.Checked;

                    vojakController.AddVojakWithZkouska(name, surname, date, height, deploy);
                    MessageBox.Show("Vojak byl úspěšně přidán.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Neplatná hodnota pro výšku.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se přidat vojáka", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addZkouskaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedVojakId = Convert.ToInt32(VojakCombo.SelectedValue);
                int selectedSpecializaceId = Convert.ToInt32(specializaceCombo.SelectedValue);
                string vysledek = resultBox.Text;
                string mistoZkousky = kdeBox.Text;


                DateTime datum = whenPick.SelectionStart;

                zkouskaController.AddZkouska(selectedVojakId, selectedSpecializaceId, mistoZkousky, vysledek, datum);

                MessageBox.Show("Sluzba byla úspěšně přidána.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se přidat sluzbu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VojakCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
