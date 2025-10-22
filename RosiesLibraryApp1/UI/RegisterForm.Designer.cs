namespace RosiesLibraryApp.UI
{
    partial class RegisterForm
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
            registerNewButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            newPasswordText = new TextBox();
            newUsernameText = new TextBox();
            label5 = new Label();
            emailText = new TextBox();
            SuspendLayout();
            // 
            // registerNewButton
            // 
            registerNewButton.BackColor = SystemColors.ActiveCaption;
            registerNewButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerNewButton.ForeColor = SystemColors.ControlText;
            registerNewButton.Location = new Point(38, 238);
            registerNewButton.Name = "registerNewButton";
            registerNewButton.Size = new Size(167, 35);
            registerNewButton.TabIndex = 14;
            registerNewButton.Text = "Register new user";
            registerNewButton.UseVisualStyleBackColor = false;
            registerNewButton.Click += RegisterNewButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 54);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 13;
            label4.Text = "User Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 20);
            label3.Name = "label3";
            label3.Size = new Size(186, 34);
            label3.TabIndex = 12;
            label3.Text = "Rosies Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 134);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 11;
            label2.Text = "Enter password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 90);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 10;
            label1.Text = "Enter username:";
            // 
            // newPasswordText
            // 
            newPasswordText.Location = new Point(48, 152);
            newPasswordText.Name = "newPasswordText";
            newPasswordText.Size = new Size(145, 23);
            newPasswordText.TabIndex = 9;
            // 
            // newUsernameText
            // 
            newUsernameText.Location = new Point(48, 108);
            newUsernameText.Name = "newUsernameText";
            newUsernameText.Size = new Size(145, 23);
            newUsernameText.TabIndex = 8;
   
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 178);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 16;
            label5.Text = "Enter email:";
            // 
            // emailText
            // 
            emailText.Location = new Point(48, 196);
            emailText.Name = "emailText";
            emailText.Size = new Size(145, 23);
            emailText.TabIndex = 15;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 336);
            Controls.Add(label5);
            Controls.Add(emailText);
            Controls.Add(registerNewButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newPasswordText);
            Controls.Add(newUsernameText);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerNewButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox newPasswordText;
        private TextBox newUsernameText;
        private Label label5;
        private TextBox emailText;
    }
}