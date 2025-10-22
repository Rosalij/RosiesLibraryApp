namespace RosiesLibraryApp.UI
{
    partial class UserDashboardForm
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
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            rentButton = new Button();
            returnButton = new Button();
            dataGridView2 = new DataGridView();
            currentUserText = new Label();
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 43);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 8;
            label4.Text = "User Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 9);
            label3.Name = "label3";
            label3.Size = new Size(186, 34);
            label3.TabIndex = 7;
            label3.Text = "Rosies Library";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(294, 315);
            dataGridView1.TabIndex = 9;
            // 
            // rentButton
            // 
            rentButton.Location = new Point(22, 84);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(149, 23);
            rentButton.TabIndex = 10;
            rentButton.Text = "Rent selected book";
            rentButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(331, 84);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(139, 23);
            returnButton.TabIndex = 11;
            returnButton.Text = "return selected book";
            returnButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(331, 113);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(294, 315);
            dataGridView2.TabIndex = 12;
            // 
            // currentUserText
            // 
            currentUserText.AutoSize = true;
            currentUserText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUserText.Location = new Point(12, 9);
            currentUserText.Name = "currentUserText";
            currentUserText.Size = new Size(0, 17);
            currentUserText.TabIndex = 14;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(713, 9);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 15;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(currentUserText);
            Controls.Add(dataGridView2);
            Controls.Add(returnButton);
            Controls.Add(rentButton);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button rentButton;
        private Button returnButton;
        private DataGridView dataGridView2;
        private Label currentUserText;
        private Button logoutButton;
    }
}