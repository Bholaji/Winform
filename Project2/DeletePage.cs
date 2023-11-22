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
    public partial class DeletePage : Form
    {
        DataAccess.DataAccess db = new();
        public DeletePage()
        {
            InitializeComponent();
        }

        private void backButtonRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new();
            homePage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = Email.Text;

            if(!string.IsNullOrWhiteSpace(email))
            {
                db.DeleteEmployee(email);
                MessageBox.Show($"The Employee with the email {email} has been deleted");
            }else
            {
                MessageBox.Show("Enter an email");
            }


        }
    }
}
