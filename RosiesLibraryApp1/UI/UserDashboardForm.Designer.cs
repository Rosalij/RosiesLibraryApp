
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
            borrowButton = new Button();
            returnButton = new Button();
            logoutButton = new Button();
            dataGridView2 = new DataGridView();
            currentUserText = new Label();
            panel1 = new Panel();
            textSearchBookToBorrow = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(523, 53);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 8;
            label4.Text = "User Dashboard";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(484, 8);
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 164);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(537, 538);
            dataGridView1.TabIndex = 9;
            // 
            // borrowButton
            // 
            borrowButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            borrowButton.Location = new Point(298, 8);
            borrowButton.Margin = new Padding(3, 4, 3, 4);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(220, 31);
            borrowButton.TabIndex = 10;
            borrowButton.Text = "Borrow selected book";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += BorrowButton_Click;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            returnButton.Location = new Point(317, 8);
            returnButton.Margin = new Padding(3, 4, 3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(207, 31);
            returnButton.TabIndex = 11;
            returnButton.Text = "return selected book";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logoutButton.Location = new Point(1083, 8);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(86, 31);
            logoutButton.TabIndex = 15;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 47);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(538, 543);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textSearchBookToBorrow);
            panel1.Controls.Add(borrowButton);
            panel1.Location = new Point(30, 117);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 585);
            panel1.TabIndex = 16;
            // 
            // textSearchBookToBorrow
            // 
            textSearchBookToBorrow.Location = new Point(75, 11);
            textSearchBookToBorrow.Name = "textSearchBookToBorrow";
            textSearchBookToBorrow.Size = new Size(217, 27);
            textSearchBookToBorrow.TabIndex = 18;
            textSearchBookToBorrow.TextChanged += textSearchBookToBorrow_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(returnButton);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(618, 117);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 585);
            panel2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 18;
            label1.Text = "Search:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 90);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 18;
            label2.Text = "Borrow book";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(834, 90);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 19;
            label5.Text = "Return book";
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 715);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(logoutButton);
            Controls.Add(currentUserText);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserDashboardForm";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button borrowButton;
        private Button returnButton;
        private DataGridView dataGridView2;
        private Label currentUserText;
        private Button logoutButton;
        private Panel panel1;
        private Panel panel2;
        private TextBox textSearchBookToBorrow;
        private Label label1;
        private Label label2;
        private Label label5;
    }
}