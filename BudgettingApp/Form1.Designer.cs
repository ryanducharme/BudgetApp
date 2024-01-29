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
      BudgetView = new ListView();
      NameHeader = new ColumnHeader();
      AmountHeader = new ColumnHeader();
      DateHeader = new ColumnHeader();
      CategoryHeader = new ColumnHeader();
      DescriptionHeader = new ColumnHeader();
      label2 = new Label();
      AddItemBox = new GroupBox();
      DescriptionBox = new RichTextBox();
      BudgetNameLabel = new Label();
      groupBox1 = new GroupBox();
      dataGridView1 = new DataGridView();
      menuStrip1.SuspendLayout();
      statusStrip1.SuspendLayout();
      AddItemBox.SuspendLayout();
      groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
      menuStrip1.Size = new Size(1345, 24);
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
      statusStrip1.Location = new Point(0, 832);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(1345, 22);
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
      // BudgetView
      // 
      BudgetView.Columns.AddRange(new ColumnHeader[] { NameHeader, AmountHeader, DateHeader, CategoryHeader, DescriptionHeader });
      BudgetView.Location = new Point(847, 43);
      BudgetView.Name = "BudgetView";
      BudgetView.Size = new Size(258, 118);
      BudgetView.TabIndex = 15;
      BudgetView.UseCompatibleStateImageBehavior = false;
      BudgetView.View = View.Details;
      // 
      // NameHeader
      // 
      NameHeader.Text = "Name";
      // 
      // AmountHeader
      // 
      AmountHeader.Text = "Amount";
      // 
      // DateHeader
      // 
      DateHeader.Text = "Date";
      DateHeader.Width = 100;
      // 
      // CategoryHeader
      // 
      CategoryHeader.Text = "Category";
      // 
      // DescriptionHeader
      // 
      DescriptionHeader.Text = "Description";
      DescriptionHeader.Width = 300;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(6, 19);
      label2.Name = "label2";
      label2.Size = new Size(38, 15);
      label2.TabIndex = 16;
      label2.Text = "label2";
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
      groupBox1.Controls.Add(label2);
      groupBox1.Location = new Point(464, 27);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(377, 225);
      groupBox1.TabIndex = 19;
      groupBox1.TabStop = false;
      groupBox1.Text = "Stats";
      // 
      // dataGridView1
      // 
      dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Location = new Point(12, 285);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.Size = new Size(829, 436);
      dataGridView1.TabIndex = 20;
      dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1345, 854);
      Controls.Add(dataGridView1);
      Controls.Add(groupBox1);
      Controls.Add(BudgetNameLabel);
      Controls.Add(AddItemBox);
      Controls.Add(BudgetView);
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
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ListView BudgetView;
        private ColumnHeader NameHeader;
        private ColumnHeader AmountHeader;
        private ColumnHeader DateHeader;
        private ColumnHeader DescriptionHeader;
        private ColumnHeader CategoryHeader;
        private Label label2;
        private RadioButton ExpenseRadioButton;
        private RadioButton IncomeRadioButton;
        private GroupBox AddItemBox;
        private RichTextBox DescriptionBox;
    private Label BudgetNameLabel;
    private GroupBox groupBox1;
    private DataGridView dataGridView1;
  }
}
