namespace BudgettingApp
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
            DatePicker = new DateTimePicker();
            label1 = new Label();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            DescriptionBox = new TextBox();
            DescriptionLabel = new Label();
            NameBox = new TextBox();
            NameLabel = new Label();
            AddExpenseButton = new Button();
            comboBox1 = new ComboBox();
            Amount = new ColumnHeader();
            Description = new ColumnHeader();
            Category = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            newBudgetToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(12, 143);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 1;
            DatePicker.Value = new DateTime(2024, 1, 21, 22, 14, 23, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 149);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 9;
            label1.Text = "Date";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(12, 85);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(100, 23);
            AmountTextBox.TabIndex = 8;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(118, 88);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(51, 15);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "Amount";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(12, 56);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(100, 23);
            DescriptionBox.TabIndex = 6;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(118, 59);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Description";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 27);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(118, 30);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // AddExpenseButton
            // 
            AddExpenseButton.Location = new Point(12, 172);
            AddExpenseButton.Name = "AddExpenseButton";
            AddExpenseButton.Size = new Size(75, 23);
            AddExpenseButton.TabIndex = 0;
            AddExpenseButton.Text = "Add";
            AddExpenseButton.UseVisualStyleBackColor = true;
            AddExpenseButton.Click += AddExpenseButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // Amount
            // 
            Amount.Text = "Amount";
            // 
            // Description
            // 
            Description.Text = "Description";
            // 
            // Category
            // 
            Category.Text = "Category";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(793, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, newBudgetToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(139, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(139, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // newBudgetToolStripMenuItem
            // 
            newBudgetToolStripMenuItem.Name = "newBudgetToolStripMenuItem";
            newBudgetToolStripMenuItem.Size = new Size(139, 22);
            newBudgetToolStripMenuItem.Text = "New Budget";
            newBudgetToolStripMenuItem.Click += newBudgetToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 410);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(793, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 432);
            Controls.Add(statusStrip1);
            Controls.Add(comboBox1);
            Controls.Add(DatePicker);
            Controls.Add(label1);
            Controls.Add(NameBox);
            Controls.Add(AmountTextBox);
            Controls.Add(AddExpenseButton);
            Controls.Add(AmountLabel);
            Controls.Add(NameLabel);
            Controls.Add(DescriptionBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private TextBox DescriptionBox;
        private Label DescriptionLabel;
        private TextBox NameBox;
        private Label NameLabel;
        private Button AddExpenseButton;
        private Label label1;
        private DateTimePicker DatePicker;
        private ComboBox comboBox1;
        private ListView ExpenseView;
        
        private ColumnHeader Amount;
        private ColumnHeader Description;
        private ColumnHeader Category;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem newBudgetToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
