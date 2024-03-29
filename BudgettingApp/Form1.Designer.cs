﻿namespace BudgettingApp
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
            components = new System.ComponentModel.Container();
            DatePicker = new DateTimePicker();
            AmountTextBox = new TextBox();
            AmountLabel = new Label();
            DescriptionLabel = new Label();
            NameBox = new TextBox();
            NameLabel = new Label();
            AddItemButton = new Button();
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
            ExpenseRadioButton = new RadioButton();
            IncomeRadioButton = new RadioButton();
            SumOfExpensesLabel = new Label();
            AddItemBox = new GroupBox();
            DescriptionBox = new RichTextBox();
            BudgetNameLabel = new Label();
            groupBox1 = new GroupBox();
            SumOfIncomeLabel = new Label();
            ExpenseDataGridView = new DataGridView();
            PopupMenu = new ContextMenuStrip(components);
            Remove = new ToolStripMenuItem();
            IncomeDataGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            AddItemBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseDataGridView).BeginInit();
            PopupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(150, 93);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 1;
            DatePicker.Value = new DateTime(2024, 1, 21, 22, 14, 23, 0);
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(150, 39);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(138, 23);
            AmountTextBox.TabIndex = 8;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(150, 21);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(51, 15);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "Amount";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(7, 119);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Description";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(6, 39);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(138, 23);
            NameBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 21);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(365, 190);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(75, 23);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 93);
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
            menuStrip1.Size = new Size(929, 24);
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
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(139, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
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
            statusStrip1.Location = new Point(0, 734);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(929, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ExpenseRadioButton
            // 
            ExpenseRadioButton.AutoSize = true;
            ExpenseRadioButton.Location = new Point(76, 68);
            ExpenseRadioButton.Name = "ExpenseRadioButton";
            ExpenseRadioButton.Size = new Size(68, 19);
            ExpenseRadioButton.TabIndex = 13;
            ExpenseRadioButton.Text = "Expense";
            ExpenseRadioButton.UseVisualStyleBackColor = true;
            // 
            // IncomeRadioButton
            // 
            IncomeRadioButton.AutoSize = true;
            IncomeRadioButton.Checked = true;
            IncomeRadioButton.Location = new Point(7, 68);
            IncomeRadioButton.Name = "IncomeRadioButton";
            IncomeRadioButton.Size = new Size(65, 19);
            IncomeRadioButton.TabIndex = 12;
            IncomeRadioButton.TabStop = true;
            IncomeRadioButton.Text = "Income";
            IncomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SumOfExpensesLabel
            // 
            SumOfExpensesLabel.AutoSize = true;
            SumOfExpensesLabel.Location = new Point(6, 39);
            SumOfExpensesLabel.Name = "SumOfExpensesLabel";
            SumOfExpensesLabel.Size = new Size(86, 15);
            SumOfExpensesLabel.TabIndex = 16;
            SumOfExpensesLabel.Text = "Total Expenses:";
            // 
            // AddItemBox
            // 
            AddItemBox.Controls.Add(DescriptionBox);
            AddItemBox.Controls.Add(AddItemButton);
            AddItemBox.Controls.Add(ExpenseRadioButton);
            AddItemBox.Controls.Add(DatePicker);
            AddItemBox.Controls.Add(DescriptionLabel);
            AddItemBox.Controls.Add(IncomeRadioButton);
            AddItemBox.Controls.Add(comboBox1);
            AddItemBox.Controls.Add(NameLabel);
            AddItemBox.Controls.Add(NameBox);
            AddItemBox.Controls.Add(AmountTextBox);
            AddItemBox.Controls.Add(AmountLabel);
            AddItemBox.Location = new Point(12, 27);
            AddItemBox.Name = "AddItemBox";
            AddItemBox.Size = new Size(446, 225);
            AddItemBox.TabIndex = 18;
            AddItemBox.TabStop = false;
            AddItemBox.Text = "Add New Item";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(6, 137);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(344, 76);
            DescriptionBox.TabIndex = 14;
            DescriptionBox.Text = "";
            // 
            // BudgetNameLabel
            // 
            BudgetNameLabel.AutoSize = true;
            BudgetNameLabel.Location = new Point(12, 267);
            BudgetNameLabel.Name = "BudgetNameLabel";
            BudgetNameLabel.Size = new Size(38, 15);
            BudgetNameLabel.TabIndex = 17;
            BudgetNameLabel.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SumOfIncomeLabel);
            groupBox1.Controls.Add(SumOfExpensesLabel);
            groupBox1.Location = new Point(464, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 225);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stats";
            // 
            // SumOfIncomeLabel
            // 
            SumOfIncomeLabel.AutoSize = true;
            SumOfIncomeLabel.Location = new Point(6, 21);
            SumOfIncomeLabel.Name = "SumOfIncomeLabel";
            SumOfIncomeLabel.Size = new Size(78, 15);
            SumOfIncomeLabel.TabIndex = 17;
            SumOfIncomeLabel.Text = "Total Income:";
            // 
            // ExpenseDataGridView
            // 
            ExpenseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExpenseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpenseDataGridView.Location = new Point(12, 285);
            ExpenseDataGridView.Name = "ExpenseDataGridView";
            ExpenseDataGridView.Size = new Size(446, 366);
            ExpenseDataGridView.TabIndex = 20;
            ExpenseDataGridView.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // PopupMenu
            // 
            PopupMenu.Items.AddRange(new ToolStripItem[] { Remove });
            PopupMenu.Name = "contextMenuStrip1";
            PopupMenu.Size = new Size(118, 26);
            PopupMenu.Click += PopupMenu_Click;
            // 
            // Remove
            // 
            Remove.Name = "Remove";
            Remove.Size = new Size(117, 22);
            Remove.Text = "Remove";
            // 
            // IncomeDataGridView
            // 
            IncomeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IncomeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncomeDataGridView.Location = new Point(464, 285);
            IncomeDataGridView.Name = "IncomeDataGridView";
            IncomeDataGridView.Size = new Size(455, 366);
            IncomeDataGridView.TabIndex = 21;
            IncomeDataGridView.CellValueChanged += IncomeDataGridView_CellValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 657);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(464, 657);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 756);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(IncomeDataGridView);
            Controls.Add(ExpenseDataGridView);
            Controls.Add(groupBox1);
            Controls.Add(BudgetNameLabel);
            Controls.Add(AddItemBox);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Budgetting App";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            AddItemBox.ResumeLayout(false);
            AddItemBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseDataGridView).EndInit();
            PopupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IncomeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private Label DescriptionLabel;
        private TextBox NameBox;
        private Label NameLabel;
        private Button AddItemButton;
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
        private Label SumOfExpensesLabel;
        private RadioButton ExpenseRadioButton;
        private RadioButton IncomeRadioButton;
        private GroupBox AddItemBox;
        private RichTextBox DescriptionBox;
    private Label BudgetNameLabel;
    private GroupBox groupBox1;
    private DataGridView ExpenseDataGridView;
    private ContextMenuStrip PopupMenu;
    private ToolStripMenuItem Remove;
        private DataGridView IncomeDataGridView;
        private Label SumOfIncomeLabel;
        private Button button1;
        private Button button2;
    }
}
