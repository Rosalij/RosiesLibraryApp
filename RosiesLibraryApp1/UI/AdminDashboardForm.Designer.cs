

namespace RosiesLibraryApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            addButton = new Button();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            authorText = new TextBox();
            titleText = new TextBox();
            yearText = new TextBox();
            ISBNText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ISBNUpdate = new TextBox();
            yearUpdate = new TextBox();
            titleUpdate = new TextBox();
            authorUpdate = new TextBox();
            updateButton = new Button();
            copiesUpdate = new TextBox();
            label11 = new Label();
            userDashboardButton = new Button();
            label1 = new Label();
            label12 = new Label();
            searchText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(217, 91);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(102, 31);
            addButton.TabIndex = 0;
            addButton.Text = "Add book";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(14, 165);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(157, 31);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete selected book";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(14, 203);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1093, 381);
            dataGridView1.TabIndex = 4;
            // 
            // authorText
            // 
            authorText.Location = new Point(217, 11);
            authorText.Margin = new Padding(3, 4, 3, 4);
            authorText.Name = "authorText";
            authorText.Size = new Size(102, 27);
            authorText.TabIndex = 7;
            // 
            // titleText
            // 
            titleText.Location = new Point(57, 12);
            titleText.Margin = new Padding(3, 4, 3, 4);
            titleText.Name = "titleText";
            titleText.Size = new Size(102, 27);
            titleText.TabIndex = 8;
            // 
            // yearText
            // 
            yearText.Location = new Point(217, 46);
            yearText.Margin = new Padding(3, 4, 3, 4);
            yearText.Name = "yearText";
            yearText.Size = new Size(102, 27);
            yearText.TabIndex = 9;
            // 
            // ISBNText
            // 
            ISBNText.Location = new Point(57, 46);
            ISBNText.Margin = new Padding(3, 4, 3, 4);
            ISBNText.Name = "ISBNText";
            ISBNText.Size = new Size(102, 27);
            ISBNText.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 11;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 16);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 12;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 51);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 13;
            label4.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 50);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 14;
            label5.Text = "Year:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 170);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 16;
            label6.Text = "Search:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(titleText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(authorText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(yearText);
            panel1.Controls.Add(ISBNText);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(769, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 136);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 60);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 25;
            label7.Text = "Year:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 60);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 24;
            label8.Text = "ISBN:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(381, 23);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 23;
            label9.Text = "Author:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(211, 21);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 22;
            label10.Text = "Title:";
            // 
            // ISBNUpdate
            // 
            ISBNUpdate.Location = new Point(261, 55);
            ISBNUpdate.Margin = new Padding(3, 4, 3, 4);
            ISBNUpdate.Name = "ISBNUpdate";
            ISBNUpdate.Size = new Size(117, 27);
            ISBNUpdate.TabIndex = 21;
            // 
            // yearUpdate
            // 
            yearUpdate.Location = new Point(443, 56);
            yearUpdate.Margin = new Padding(3, 4, 3, 4);
            yearUpdate.Name = "yearUpdate";
            yearUpdate.Size = new Size(117, 27);
            yearUpdate.TabIndex = 20;
            // 
            // titleUpdate
            // 
            titleUpdate.Location = new Point(261, 16);
            titleUpdate.Margin = new Padding(3, 4, 3, 4);
            titleUpdate.Name = "titleUpdate";
            titleUpdate.Size = new Size(117, 27);
            titleUpdate.TabIndex = 19;
            // 
            // authorUpdate
            // 
            authorUpdate.Location = new Point(442, 17);
            authorUpdate.Margin = new Padding(3, 4, 3, 4);
            authorUpdate.Name = "authorUpdate";
            authorUpdate.Size = new Size(117, 27);
            authorUpdate.TabIndex = 18;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(395, 95);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(166, 31);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update selected book";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // copiesUpdate
            // 
            copiesUpdate.Location = new Point(261, 96);
            copiesUpdate.Margin = new Padding(3, 4, 3, 4);
            copiesUpdate.Name = "copiesUpdate";
            copiesUpdate.Size = new Size(117, 27);
            copiesUpdate.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(131, 99);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 27;
            label11.Text = "Available copies:";
            // 
            // userDashboardButton
            // 
            userDashboardButton.Location = new Point(838, 160);
            userDashboardButton.Margin = new Padding(3, 4, 3, 4);
            userDashboardButton.Name = "userDashboardButton";
            userDashboardButton.Size = new Size(269, 31);
            userDashboardButton.TabIndex = 28;
            userDashboardButton.Text = " Go to User Dashboard";
            userDashboardButton.UseVisualStyleBackColor = true;
            userDashboardButton.Click += userDashboardButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 29;
            label1.Text = "Rosies Library";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 45);
            label12.Name = "label12";
            label12.Size = new Size(138, 20);
            label12.TabIndex = 30;
            label12.Text = "Admin Dashboard";
            // 
            // searchText
            // 
            searchText.Location = new Point(255, 166);
            searchText.Margin = new Padding(3, 4, 3, 4);
            searchText.Name = "searchText";
            searchText.Size = new Size(233, 27);
            searchText.TabIndex = 31;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1123, 600);
            Controls.Add(searchText);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(userDashboardButton);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(copiesUpdate);
            Controls.Add(updateButton);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(ISBNUpdate);
            Controls.Add(yearUpdate);
            Controls.Add(titleUpdate);
            Controls.Add(authorUpdate);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private TextBox authorText;
        private TextBox titleText;
        private TextBox yearText;
        private TextBox ISBNText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox ISBNUpdate;
        private TextBox textBox4;
        private TextBox authorUpdate;
        public TextBox titleUpdate;
        public TextBox yearUpdate;
        private Button updateButton;
        private TextBox copiesUpdate;
        private Label label11;
        private Button userDashboardButton;
        private Label label1;
        private Label label12;
        private TextBox searchText;
    }
}
