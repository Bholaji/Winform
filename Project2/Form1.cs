using DataAccess;
using Entities;

namespace Project2
{
    public partial class Form1 : Form
    {
        DataAccess.DataAccess db = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void allEmployees_Click(object sender, EventArgs e)
        {

        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allEmployees_Click_1(object sender, EventArgs e)
        {
            List<Employee> employees = db.viewAllEmployees();
            dataGridView3.DataSource = employees;
            dataGridView3.Visible = true;
            dataGridView2.Visible = false;
        }

        private void backButtonRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new();
            homePage.Show();
        }

        private void groupByDepartment_Click(object sender, EventArgs e)
        {
            List<string> departmenWithEmployee = db.GroupByDepartment();
            List<string> department = db.GetAllDepartments();

            /*dataGridView1.DataSource = department;*/
            dataGridView1.DataSource = departmenWithEmployee.Select(dep => new { Department = dep }).ToList();
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            /*foreach(string item in departmenWithEmployee)
            {
                dataGridView1.DataSource = item;
            }*/

        }

        private void unassignedDepartment_Click(object sender, EventArgs e)
        {
            List<string> departmenWithoutEmployee = db.EmployeesWithNoDepartment();
            List<string> department = db.GetAllDepartments();
            dataGridView1.DataSource = departmenWithoutEmployee.Select(dep => new { Department = dep }).ToList();
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
        }

        private void salary_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            // Call the method that groups employees by salary
            var groupedBySalary = db.GroupBySalary();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("SalaryRange", "Salary Range");
            dataGridView2.Columns.Add("Employees", "Employees");

            // Iterate through the grouped results and populate the DataGridView
            foreach (var kvp in groupedBySalary)
            {
                // Combine employees' names into a single string for display
                string employeeNames = string.Join(", ", kvp.Value.Select(emp => $"{emp.FirstName} {emp.LastName}"));

                // Add the salary range and corresponding employees' names to the DataGridView
                dataGridView2.Rows.Add(kvp.Key, employeeNames);
            }
            dataGridView2.Visible = true;
        }
    }
}