namespace Project2
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            button2 = new Button();
            backButtonRegisterPage = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            emailLabel = new Label();
            departmentLabel = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(81, 139);
            button2.Name = "button2";
            button2.Size = new Size(109, 28);
            button2.TabIndex = 38;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // backButtonRegisterPage
            // 
            backButtonRegisterPage.Image = (Image)resources.GetObject("backButtonRegisterPage.Image");
            backButtonRegisterPage.Location = new Point(80, 12);
            backButtonRegisterPage.Name = "backButtonRegisterPage";
            backButtonRegisterPage.Size = new Size(75, 23);
            backButtonRegisterPage.TabIndex = 37;
            backButtonRegisterPage.Text = "<-- back";
            backButtonRegisterPage.UseVisualStyleBackColor = true;
            backButtonRegisterPage.Click += backButtonRegisterPage_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 51);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 39;
            label2.Text = "Enter Department :";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.Red;
            emailLabel.Location = new Point(81, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 15);
            emailLabel.TabIndex = 42;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.ForeColor = Color.Red;
            departmentLabel.Location = new Point(80, 286);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(0, 15);
            departmentLabel.TabIndex = 43;
            // 
            // AddDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(518, 217);
            Controls.Add(departmentLabel);
            Controls.Add(emailLabel);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(backButtonRegisterPage);
            ForeColor = Color.Yellow;
            Name = "AddDepartment";
            Text = "AddDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button backButtonRegisterPage;
        private TextBox textBox2;
        private Label label2;
        private Label emailLabel;
        private Label departmentLabel;
        private DataGridView dataGridView;
    }
}