using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void addEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new();
            frm2.Show();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePage updatePage = new();
            updatePage.Show();
        }

        private void deleteEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePage deletePage = new();
            deletePage.Show();
        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDepartment addDepartment = new();
            addDepartment.Show();
        }

        private void viewDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new();
            frm1.Show();
        }
    }
}
