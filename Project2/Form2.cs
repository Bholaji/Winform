using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project2
{
    public partial class Form2 : Form
    {
        DataAccess.DataAccess db = new();
        Utilities.Utilities Utilities = new();
        public Form2()
        {
            InitializeComponent();
        }

        private void firstNametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButtonRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            string firstName = firstNametxtbox.Text;
            string lastName = lastNametextBox.Text;
            string email = emailtextBox.Text;
            string phoneNumber = phoneNumbertextBox.Text;
            string state = statetextBox.Text;
            string department = departmenttextBox.Text;
            string salary = salarytextBox.Text;
            try
            {
                if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) &&
                    !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(phoneNumber) &&
                    !string.IsNullOrWhiteSpace(state) && !string.IsNullOrWhiteSpace(salary))
                {
                    bool isEmailValid = Utilities.IsValidEmail(email);
                    bool isPhoneNumberValid = Utilities.IsValidNigerianPhoneNumber(phoneNumber);
                    bool isEmailExist = db.ExistingEmail(email);
                    if (!isEmailValid || !isPhoneNumberValid || isEmailExist)
                    {
                        if (!isEmailValid)
                        {

                            errorEmailValid.Text = "Invalid email format";
                            errorEmailValid.Visible = true;
                        }
                        else
                        {
                            errorLabel.Visible = false;
                        }

                        if (!isPhoneNumberValid)
                        {
                            errorPhoneNumber.Text = "Invalid Nigerian phone number";
                            errorPhoneNumber.Visible = true;
                        }
                        else
                        {
                            errorPhoneNumber.Visible = false;
                        }
                        if (isEmailExist)
                        {
                            errorLabel.Text = "Email already exist!";
                            errorLabel.Visible = true;
                        }
                        else
                        {
                            errorLabel.Visible = false;
                        }
                    }
                    else
                    {
                        errorLabel.Visible = false;
                        errorPhoneNumber.Visible = false;
                        db.RegisterEmployee(new Employee
                        {
                            Id = id,
                            FirstName = firstName,
                            LastName = lastName,
                            Email = email,
                            PhoneNumber = phoneNumber,
                            State = state,
                            Department = department,
                            Salary = salary
                        });
                        MessageBox.Show($"You have successfully registered");
                    }

                }
                else
                {
                    MessageBox.Show("Fill in the appropriate fields");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
