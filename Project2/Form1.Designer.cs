namespace Project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupByDepartment = new Label();
            salary = new Label();
            unassignedDepartment = new Label();
            allEmployees = new Label();
            ExitApplication = new Label();
            backButtonRegisterPage = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // groupByDepartment
            // 
            groupByDepartment.AccessibleDescription = "ssss";
            groupByDepartment.AccessibleName = "groupDepartmentLabel";
            groupByDepartment.AutoSize = true;
            groupByDepartment.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupByDepartment.Location = new Point(30, 111);
            groupByDepartment.Name = "groupByDepartment";
            groupByDepartment.Size = new Size(185, 22);
            groupByDepartment.TabIndex = 9;
            groupByDepartment.Tag = "allEmployees";
            groupByDepartment.Text = "Group By Department";
            groupByDepartment.Click += groupByDepartment_Click;
            // 
            // salary
            // 
            salary.AccessibleName = "salaryLabel";
            salary.AutoSize = true;
            salary.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            salary.Location = new Point(30, 186);
            salary.Name = "salary";
            salary.Size = new Size(159, 22);
            salary.TabIndex = 8;
            salary.Tag = "allEmployees";
            salary.Text = "Salary: 150k-300k";
            salary.Click += salary_Click;
            // 
            // unassignedDepartment
            // 
            unassignedDepartment.AccessibleName = "unassignedDepartmentLabel";
            unassignedDepartment.AutoSize = true;
            unassignedDepartment.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            unassignedDepartment.Location = new Point(30, 257);
            unassignedDepartment.Name = "unassignedDepartment";
            unassignedDepartment.Size = new Size(209, 22);
            unassignedDepartment.TabIndex = 7;
            unassignedDepartment.Tag = "allEmployees";
            unassignedDepartment.Text = "Unassigned Departments";
            unassignedDepartment.Click += unassignedDepartment_Click;
            // 
            // allEmployees
            // 
            allEmployees.AccessibleName = "allEmployeesLabel";
            allEmployees.AutoSize = true;
            allEmployees.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            allEmployees.Location = new Point(30, 45);
            allEmployees.Name = "allEmployees";
            allEmployees.Size = new Size(124, 22);
            allEmployees.TabIndex = 5;
            allEmployees.Tag = "";
            allEmployees.Text = "All Employess";
            allEmployees.Click += allEmployees_Click_1;
            // 
            // ExitApplication
            // 
            ExitApplication.AccessibleName = "exitApplication";
            ExitApplication.AutoSize = true;
            ExitApplication.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApplication.Location = new Point(30, 329);
            ExitApplication.Name = "ExitApplication";
            ExitApplication.Size = new Size(32, 19);
            ExitApplication.TabIndex = 10;
            ExitApplication.Text = "Exit";
            ExitApplication.Click += ExitApplication_Click;
            // 
            // backButtonRegisterPage
            // 
            backButtonRegisterPage.Image = (Image)resources.GetObject("backButtonRegisterPage.Image");
            backButtonRegisterPage.Location = new Point(30, 5);
            backButtonRegisterPage.Name = "backButtonRegisterPage";
            backButtonRegisterPage.Size = new Size(75, 23);
            backButtonRegisterPage.TabIndex = 34;
            backButtonRegisterPage.Text = "<-- back";
            backButtonRegisterPage.UseVisualStyleBackColor = true;
            backButtonRegisterPage.Click += backButtonRegisterPage_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 0, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(333, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 277);
            dataGridView1.TabIndex = 35;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(192, 0, 192);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(333, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(443, 277);
            dataGridView2.TabIndex = 36;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(192, 0, 192);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(333, 45);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(443, 277);
            dataGridView3.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(808, 357);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(backButtonRegisterPage);
            Controls.Add(ExitApplication);
            Controls.Add(groupByDepartment);
            Controls.Add(salary);
            Controls.Add(unassignedDepartment);
            Controls.Add(allEmployees);
            ForeColor = Color.Yellow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "View Employees Page";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label groupByDepartment;
        private Label salary;
        private Label unassignedDepartment;
        private Label allEmployees;
        private Label ExitApplication;
        private Button backButtonRegisterPage;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}