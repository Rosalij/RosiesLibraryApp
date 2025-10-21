

namespace RosiesLibraryApp1
{
    partial class Form1
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
            addButton = new Button();
            loadButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            IDText = new TextBox();
            authorText = new TextBox();
            titleText = new TextBox();
            yearText = new TextBox();
            ISBNText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(713, 73);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(713, 44);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(102, 32);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(21, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 337);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 32);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Rosies Library";
            // 
            // IDText
            // 
            IDText.Location = new Point(21, 72);
            IDText.Name = "IDText";
            IDText.Size = new Size(41, 23);
            IDText.TabIndex = 6;
            IDText.Text = "ID";
            // 
            // authorText
            // 
            authorText.Location = new Point(68, 72);
            authorText.Name = "authorText";
            authorText.Size = new Size(130, 23);
            authorText.TabIndex = 7;
            authorText.Text = "Author";
            // 
            // titleText
            // 
            titleText.Location = new Point(204, 72);
            titleText.Name = "titleText";
            titleText.Size = new Size(156, 23);
            titleText.TabIndex = 8;
            titleText.Text = "Title";
            // 
            // yearText
            // 
            yearText.Location = new Point(472, 72);
            yearText.Name = "yearText";
            yearText.Size = new Size(75, 23);
            yearText.TabIndex = 9;
            yearText.Text = "Year";
            // 
            // ISBNText
            // 
            ISBNText.Location = new Point(366, 72);
            ISBNText.Name = "ISBNText";
            ISBNText.Size = new Size(100, 23);
            ISBNText.TabIndex = 10;
            ISBNText.Text = "ISBN";
     
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ISBNText);
            Controls.Add(yearText);
            Controls.Add(titleText);
            Controls.Add(authorText);
            Controls.Add(IDText);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(loadButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button loadButton;
        private Button updateButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox IDText;
        private TextBox authorText;
        private TextBox titleText;
        private TextBox yearText;
        private TextBox ISBNText;
    }
}
