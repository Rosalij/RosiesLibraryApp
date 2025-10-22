

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
            loadButton = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(190, 69);
            addButton.Name = "addButton";
            addButton.Size = new Size(103, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Add book";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(533, 123);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load books";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 124);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(137, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete selected book";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 286);
            dataGridView1.TabIndex = 4;
            // 
            // authorText
            // 
            authorText.Location = new Point(190, 8);
            authorText.Name = "authorText";
            authorText.Size = new Size(90, 23);
            authorText.TabIndex = 7;
            // 
            // titleText
            // 
            titleText.Location = new Point(50, 9);
            titleText.Name = "titleText";
            titleText.Size = new Size(90, 23);
            titleText.TabIndex = 8;
            // 
            // yearText
            // 
            yearText.Location = new Point(685, 42);
            yearText.Name = "yearText";
            yearText.Size = new Size(90, 23);
            yearText.TabIndex = 9;
            // 
            // ISBNText
            // 
            ISBNText.Location = new Point(545, 42);
            ISBNText.Name = "ISBNText";
            ISBNText.Size = new Size(90, 23);
            ISBNText.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 12);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 46);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 13;
            label4.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 45);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Year:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(427, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 128);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 16;
            label6.Text = "Search:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(titleText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(authorText);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(493, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 103);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 45);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 25;
            label7.Text = "Year:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 45);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 24;
            label8.Text = "ISBN:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(333, 17);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 23;
            label9.Text = "Author:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(195, 16);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 22;
            label10.Text = "Title:";
            // 
            // ISBNUpdate
            // 
            ISBNUpdate.Location = new Point(228, 41);
            ISBNUpdate.Name = "ISBNUpdate";
            ISBNUpdate.Size = new Size(103, 23);
            ISBNUpdate.TabIndex = 21;
            // 
            // yearUpdate
            // 
            yearUpdate.Location = new Point(378, 42);
            yearUpdate.Name = "yearUpdate";
            yearUpdate.Size = new Size(103, 23);
            yearUpdate.TabIndex = 20;
            // 
            // titleUpdate
            // 
            titleUpdate.Location = new Point(228, 12);
            titleUpdate.Name = "titleUpdate";
            titleUpdate.Size = new Size(103, 23);
            titleUpdate.TabIndex = 19;
            // 
            // authorUpdate
            // 
            authorUpdate.Location = new Point(379, 13);
            authorUpdate.Name = "authorUpdate";
            authorUpdate.Size = new Size(103, 23);
            authorUpdate.TabIndex = 18;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(337, 72);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(145, 23);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update selected book";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // copiesUpdate
            // 
            copiesUpdate.Location = new Point(228, 72);
            copiesUpdate.Name = "copiesUpdate";
            copiesUpdate.Size = new Size(103, 23);
            copiesUpdate.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(134, 77);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 27;
            label11.Text = "Available copies:";
            // 
            // userDashboardButton
            // 
            userDashboardButton.Location = new Point(651, 123);
            userDashboardButton.Name = "userDashboardButton";
            userDashboardButton.Size = new Size(137, 23);
            userDashboardButton.TabIndex = 28;
            userDashboardButton.Text = " Go to User Dashboard";
            userDashboardButton.UseVisualStyleBackColor = true;
            userDashboardButton.Click += userDashboardButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 29;
            label1.Text = "Rosies Library";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 34);
            label12.Name = "label12";
            label12.Size = new Size(106, 15);
            label12.TabIndex = 30;
            label12.Text = "Admin Dashboard";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(802, 450);
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
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ISBNText);
            Controls.Add(yearText);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(panel1);
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
        private Button loadButton;
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
    }
}
