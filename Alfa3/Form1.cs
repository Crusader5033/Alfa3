using Alfa3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }
    }
}
