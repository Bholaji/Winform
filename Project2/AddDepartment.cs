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
    public partial class AddDepartment : Form
    {
        DataAccess.DataAccess db = new();
        Utilities.Utilities Utilities = new();
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void backButtonRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new();
            homePage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string department = textBox2.Text;

            var particularEmployee = db.GetEmployeeByEmail(email);

            if (!string.IsNullOrEmpty(email))
            {
                bool isEmailValid = Utilities.IsValidEmail(email);
                bool isEmailExist = db.ExistingEmail(email);

                if (!isEmailValid)
                {
                    emailLabel.Text = "Invalid Email!";
                    emailLabel.Visible = true;
                }
                else
                {
                    emailLabel.Visible = false;

                    if (isEmailExist)
                    {
                        textBox2.Text = particularEmployee.Department;
                    }
                    else
                    {
                        MessageBox.Show("Email does not exist");
                    }
                }
            }
        }
    }
}
