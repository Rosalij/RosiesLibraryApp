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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(378, 57);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 8;
            label4.Text = "User Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(339, 12);
            label3.Name = "label3";
            label3.Size = new Size(237, 43);
            label3.TabIndex = 7;
            label3.Text = "Rosies Library";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 164);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(422, 420);
            dataGridView1.TabIndex = 9;
            // 
            // rentButton
            // 
            rentButton.Location = new Point(107, 8);
            rentButton.Margin = new Padding(3, 4, 3, 4);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(170, 31);
            rentButton.TabIndex = 10;
            rentButton.Text = "Rent selected book";
            rentButton.UseVisualStyleBackColor = true;
            rentButton.Click += BorrowButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(145, 8);
            returnButton.Margin = new Padding(3, 4, 3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(159, 31);
            returnButton.TabIndex = 11;
            returnButton.Text = "return selected book";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(479, 164);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(422, 420);
            dataGridView2.TabIndex = 12;
            // 
            // currentUserText
            // 
            currentUserText.AutoSize = true;
            currentUserText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUserText.Location = new Point(14, 12);
            currentUserText.Name = "currentUserText";
            currentUserText.Size = new Size(0, 23);
            currentUserText.TabIndex = 14;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(815, 12);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(86, 31);
            logoutButton.TabIndex = 15;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rentButton);
            panel1.Location = new Point(14, 117);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 467);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(returnButton);
            panel2.Location = new Point(479, 117);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 467);
            panel2.TabIndex = 17;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(logoutButton);
            Controls.Add(currentUserText);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
    }
}