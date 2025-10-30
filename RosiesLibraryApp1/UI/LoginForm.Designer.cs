namespace RosiesLibraryApp.UI
{
    partial class LoginForm
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
            loginButton = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            registerButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            passwordText = new TextBox();
            usernameText = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlText;
            loginButton.Location = new Point(138, 247);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(166, 65);
            loginButton.TabIndex = 0;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passwordText);
            groupBox1.Controls.Add(usernameText);
            groupBox1.Controls.Add(loginButton);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(448, 456);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 344);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 8;
            label5.Text = "No account yet?";
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.ActiveCaption;
            registerButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.ForeColor = SystemColors.ControlText;
            registerButton.Location = new Point(138, 368);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(166, 47);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(155, 71);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 6;
            label4.Text = "User Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 25);
            label3.Name = "label3";
            label3.Size = new Size(237, 43);
            label3.TabIndex = 5;
            label3.Text = "Rosies Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 184);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 125);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter username:";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(138, 208);
            passwordText.Margin = new Padding(3, 4, 3, 4);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(165, 27);
            passwordText.TabIndex = 2;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(138, 149);
            usernameText.Margin = new Padding(3, 4, 3, 4);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(165, 27);
            usernameText.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 493);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox passwordText;
        private TextBox usernameText;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registerButton;
    }
}