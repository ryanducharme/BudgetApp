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
            ExpenseView = new ListView();
            Name = new ColumnHeader();
            Amount = new ColumnHeader();
            Description = new ColumnHeader();
            Category = new ColumnHeader();
            SuspendLayout();
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(12, 128);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 1;
            DatePicker.Value = new DateTime(2024, 1, 21, 22, 14, 23, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 134);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 9;
            label1.Text = "Date";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(12, 70);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(100, 23);
            AmountTextBox.TabIndex = 8;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(118, 73);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(51, 15);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "Amount";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(12, 41);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(100, 23);
            DescriptionBox.TabIndex = 6;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(118, 44);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Description";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(12, 12);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(118, 15);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // AddExpenseButton
            // 
            AddExpenseButton.Location = new Point(12, 157);
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
            comboBox1.Location = new Point(12, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // ExpenseView
            // 
            ExpenseView.Columns.AddRange(new ColumnHeader[] { Name, Amount, Description, Category });
            ExpenseView.Location = new Point(283, 12);
            ExpenseView.Name = "ExpenseView";
            ExpenseView.Size = new Size(389, 270);
            ExpenseView.TabIndex = 11;
            ExpenseView.UseCompatibleStateImageBehavior = false;
            ExpenseView.View = View.Details;
            // 
            // Name
            // 
            Name.Text = "Name";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 294);
            Controls.Add(ExpenseView);
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
            Text = "Form1";
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
        private ColumnHeader Name;
        private ColumnHeader Amount;
        private ColumnHeader Description;
        private ColumnHeader Category;
    }
}
