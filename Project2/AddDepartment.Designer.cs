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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
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
            button2.Location = new Point(80, 304);
            button2.Name = "button2";
            button2.Size = new Size(109, 28);
            button2.TabIndex = 38;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(80, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 52);
            label1.Name = "label1";
            label1.Size = new Size(430, 22);
            label1.TabIndex = 35;
            label1.Text = "Enter Employee email to change or add department";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(80, 137);
            button1.Name = "button1";
            button1.Size = new Size(109, 28);
            button1.TabIndex = 41;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 214);
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
            ClientSize = new Size(600, 390);
            Controls.Add(departmentLabel);
            Controls.Add(emailLabel);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(backButtonRegisterPage);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.Yellow;
            Name = "AddDepartment";
            Text = "AddDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button backButtonRegisterPage;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label emailLabel;
        private Label departmentLabel;
    }
}