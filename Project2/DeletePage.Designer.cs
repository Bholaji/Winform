namespace Project2
{
    partial class DeletePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePage));
            label1 = new Label();
            Email = new TextBox();
            backButtonRegisterPage = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(204, 22);
            label1.TabIndex = 0;
            label1.Text = "Enter Employee Email :";
            // 
            // Email
            // 
            Email.Location = new Point(49, 93);
            Email.Name = "Email";
            Email.Size = new Size(309, 23);
            Email.TabIndex = 1;
            // 
            // backButtonRegisterPage
            // 
            backButtonRegisterPage.Image = (Image)resources.GetObject("backButtonRegisterPage.Image");
            backButtonRegisterPage.Location = new Point(49, 7);
            backButtonRegisterPage.Name = "backButtonRegisterPage";
            backButtonRegisterPage.Size = new Size(75, 23);
            backButtonRegisterPage.TabIndex = 33;
            backButtonRegisterPage.Text = "<-- back";
            backButtonRegisterPage.UseVisualStyleBackColor = true;
            backButtonRegisterPage.Click += backButtonRegisterPage_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(49, 144);
            button2.Name = "button2";
            button2.Size = new Size(109, 28);
            button2.TabIndex = 34;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DeletePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(414, 181);
            Controls.Add(button2);
            Controls.Add(backButtonRegisterPage);
            Controls.Add(Email);
            Controls.Add(label1);
            ForeColor = Color.Yellow;
            Name = "DeletePage";
            Text = "DeleteEployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Email;
        private Button backButtonRegisterPage;
        private Button button2;
    }
}