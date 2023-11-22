using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Project2
{
    public partial class SubUpdatePage : Form
    {
        DataAccess.DataAccess db = new();
        public SubUpdatePage()
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
            
            string email = emailTextBox.Text;

            if (!string.IsNullOrEmpty(email))
            {
                bool existingEmail = db.ExistingEmail(email);

                if (existingEmail)
                {
                    this.Hide();
                    UpdatePage updatePage = new();
                    updatePage.Show();
                }
                else
                {
                    MessageBox.Show("email not found");
                }
            }
            
        }
    }
}
