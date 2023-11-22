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
            dataGridView1.DataSource = employees;
        }

        private void backButtonRegisterPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new();
            homePage.Show();
        }
    }
}