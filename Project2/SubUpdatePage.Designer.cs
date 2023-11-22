namespace Project2
{
    partial class SubUpdatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubUpdatePage));
            label1 = new Label();
            backButtonRegisterPage = new Button();
            emailTextBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(452, 24);
            label1.TabIndex = 0;
            label1.Text = "Enter the email of the employee you want to update";
            // 
            // backButtonRegisterPage
            // 
            backButtonRegisterPage.Image = (Image)resources.GetObject("backButtonRegisterPage.Image");
            backButtonRegisterPage.Location = new Point(12, 3);
            backButtonRegisterPage.Name = "backButtonRegisterPage";
            backButtonRegisterPage.Size = new Size(88, 23);
            backButtonRegisterPage.TabIndex = 34;
            backButtonRegisterPage.Text = "<-- back";
            backButtonRegisterPage.UseVisualStyleBackColor = true;
            backButtonRegisterPage.Click += backButtonRegisterPage_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 80);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(321, 26);
            emailTextBox.TabIndex = 35;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 141);
            button2.Name = "button2";
            button2.Size = new Size(109, 28);
            button2.TabIndex = 36;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SubUpdatePage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(514, 184);
            Controls.Add(button2);
            Controls.Add(emailTextBox);
            Controls.Add(backButtonRegisterPage);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Yellow;
            Margin = new Padding(4);
            Name = "SubUpdatePage";
            Text = "SubUpdatePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backButtonRegisterPage;
        private TextBox emailTextBox;
        private Button button2;
    }
}