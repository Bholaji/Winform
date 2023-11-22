namespace Project2
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitApplication = new Label();
            updateEmployees = new Label();
            deleteEmployees = new Label();
            fetchRecords = new Label();
            addDepartment = new Label();
            addEmployees = new Label();
            viewDepartment = new Label();
            SuspendLayout();
            // 
            // ExitApplication
            // 
            ExitApplication.AccessibleName = "exitApplication";
            ExitApplication.AutoSize = true;
            ExitApplication.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitApplication.Location = new Point(658, 248);
            ExitApplication.Name = "ExitApplication";
            ExitApplication.Size = new Size(32, 19);
            ExitApplication.TabIndex = 16;
            ExitApplication.Text = "Exit";
            ExitApplication.Click += ExitApplication_Click;
            // 
            // updateEmployees
            // 
            updateEmployees.AccessibleDescription = "ssss";
            updateEmployees.AccessibleName = "groupDepartmentLabel";
            updateEmployees.AutoSize = true;
            updateEmployees.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            updateEmployees.Location = new Point(301, 24);
            updateEmployees.Name = "updateEmployees";
            updateEmployees.Size = new Size(157, 22);
            updateEmployees.TabIndex = 15;
            updateEmployees.Tag = "allEmployees";
            updateEmployees.Text = "Update Employees";
            updateEmployees.Click += updateEmployees_Click;
            // 
            // deleteEmployees
            // 
            deleteEmployees.AccessibleName = "salaryLabel";
            deleteEmployees.AutoSize = true;
            deleteEmployees.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleteEmployees.Location = new Point(566, 24);
            deleteEmployees.Name = "deleteEmployees";
            deleteEmployees.Size = new Size(148, 22);
            deleteEmployees.TabIndex = 14;
            deleteEmployees.Tag = "allEmployees";
            deleteEmployees.Text = "Delete Employees";
            deleteEmployees.Click += deleteEmployees_Click;
            // 
            // fetchRecords
            // 
            fetchRecords.AccessibleName = "unassignedDepartmentLabel";
            fetchRecords.AutoSize = true;
            fetchRecords.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            fetchRecords.Location = new Point(150, 93);
            fetchRecords.Name = "fetchRecords";
            fetchRecords.Size = new Size(121, 22);
            fetchRecords.TabIndex = 13;
            fetchRecords.Tag = "allEmployees";
            fetchRecords.Text = "Fetch Records";
            // 
            // addDepartment
            // 
            addDepartment.AccessibleName = "allEmployeesAndDepartmentLabel";
            addDepartment.AutoSize = true;
            addDepartment.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addDepartment.Location = new Point(465, 93);
            addDepartment.Name = "addDepartment";
            addDepartment.Size = new Size(141, 22);
            addDepartment.TabIndex = 12;
            addDepartment.Tag = "allEmployees";
            addDepartment.Text = "Add Department";
            addDepartment.Click += addDepartment_Click;
            // 
            // addEmployees
            // 
            addEmployees.AccessibleName = "allEmployeesLabel";
            addEmployees.AutoSize = true;
            addEmployees.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addEmployees.Location = new Point(36, 24);
            addEmployees.Name = "addEmployees";
            addEmployees.Size = new Size(133, 22);
            addEmployees.TabIndex = 11;
            addEmployees.Tag = "";
            addEmployees.Text = "Add Employees";
            addEmployees.Click += addEmployees_Click;
            // 
            // viewDepartment
            // 
            viewDepartment.AccessibleName = "allEmployeesAndDepartmentLabel";
            viewDepartment.AutoSize = true;
            viewDepartment.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            viewDepartment.Location = new Point(566, 144);
            viewDepartment.Name = "viewDepartment";
            viewDepartment.Size = new Size(148, 22);
            viewDepartment.TabIndex = 17;
            viewDepartment.Tag = "viewDepartment";
            viewDepartment.Text = "View Department";
            viewDepartment.Click += viewDepartment_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(751, 319);
            Controls.Add(viewDepartment);
            Controls.Add(ExitApplication);
            Controls.Add(updateEmployees);
            Controls.Add(deleteEmployees);
            Controls.Add(fetchRecords);
            Controls.Add(addDepartment);
            Controls.Add(addEmployees);
            ForeColor = Color.Yellow;
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExitApplication;
        private Label updateEmployees;
        private Label deleteEmployees;
        private Label fetchRecords;
        private Label addDepartment;
        private Label addEmployees;
        private Label viewDepartment;
    }
}