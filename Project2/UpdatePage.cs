using Entities;
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
    public partial class UpdatePage : Form
    {
        DataAccess.DataAccess db = new();
        Utilities.Utilities Utilities = new();
        public UpdatePage()
        {
            InitializeComponent();
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
            string email = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string state = stateTextBox.Text;
            string department = departmentTextBox.Text;
            string salary = salaryTextBox.Text;

            try
            {
                if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) &&
                    !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(phoneNumber) &&
                    !string.IsNullOrWhiteSpace(state) && !string.IsNullOrWhiteSpace(salary))
                {
                    bool isEmailValid = Utilities.IsValidEmail(email);
                    bool isPhoneNumberValid = Utilities.IsValidNigerianPhoneNumber(phoneNumber);
                    bool isEmailExist = db.ExistingEmail(email);
                    if (!isEmailValid || !isPhoneNumberValid || !int.TryParse(salary, out _))
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
                        if(!int.TryParse(salary, out _))
                        {
                            errorSalary.Text = "Enter a valid integer";
                            errorSalary.Visible = true;
                        }
                        else
                        {
                            errorSalary.Visible = false;
                        }
                    }
                    else
                    {
                        errorSalary.Visible = false;
                        errorLabel.Visible = false;
                        errorPhoneNumber.Visible = false;
                        db.DeleteEmployee(email);
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
                        MessageBox.Show($"You have successfully updated the employee");
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailCheckTextBox.Text;
            var particularEmployee = db.GetEmployeeByEmail(email);

            if (!string.IsNullOrEmpty(email))
            {
                bool isEmailValid = Utilities.IsValidEmail(email);
                bool isEmailExist = db.ExistingEmail(email);
                if (!isEmailValid)
                {
                    label10.Text = "Invalid email format";
                    label10.Visible = true;
                }
                else
                {
                    label10.Visible = false;
                    if (isEmailExist)
                    {
                        firstNametxtbox.Text = particularEmployee.FirstName;
                        lastNametextBox.Text = particularEmployee.LastName;
                        emailTextBox.Text = particularEmployee.Email;
                        phoneNumberTextBox.Text = particularEmployee.PhoneNumber;
                        stateTextBox.Text = particularEmployee.State;
                        departmentTextBox.Text = particularEmployee.Department;
                        salaryTextBox.Text = particularEmployee.Salary;


                    }
                    else
                    {
                        MessageBox.Show("Email does not exist");
                    }
                }
            }
            else
            {
                MessageBox.Show("Employee not found");
            }
        }
    }
}
