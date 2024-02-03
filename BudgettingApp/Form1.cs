using BudgettingApp;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BudgettingApp
{
    public partial class Form1 : Form
    {
        BudgetManager manager;
        DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            manager = new BudgetManager();

            //come up with a way to store the last used budget location to auto open when opening the application
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //if there is data in the fields
            if (AmountTextBox.Text != "" && NameBox.Text != "")
            {

                if (IncomeRadioButton.Checked)
                {
                    manager.CurrentBudget.AddIncomeSource(new IncomeSource(null, double.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));
                    manager.SaveBudget();

                    IncomeDataGridView.DataSource = null;
                    IncomeDataGridView.DataSource = manager.CurrentBudget.IncomeSources;

                }
                if (ExpenseRadioButton.Checked)
                {
                    manager.CurrentBudget.AddExpense(new Expense(null, double.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));
                    manager.SaveBudget();

                    var lastExpense = manager.CurrentBudget.Expenses.Last();
                    //dataGridView1.Rows.Add(lastExpense);

                    //these two lines of code will update the data grid view with the new information
                    ExpenseDataGridView.DataSource = null;
                    ExpenseDataGridView.DataSource = manager.CurrentBudget.Expenses;

                }
                UpdateStats();
            }
        }


        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.NewBudget();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.LoadBudget();

            DoDataTableStuff();

            UpdateStats();

            BudgetNameLabel.Text = manager.CurrentBudget.Name;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.SaveBudget();
        }

        public void DoDataTableStuff()
        {
            IncomeDataGridView.DataSource = manager.CurrentBudget.IncomeSources;
            ExpenseDataGridView.DataSource = manager.CurrentBudget.Expenses;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStats();
        }

        private void PopupMenu_Click(object sender, EventArgs e)
        {

        }

        public void UpdateStats()
        {
            SumOfIncomeLabel.Text = $"Total Income: {manager.CurrentBudget.SumOfIncomes}";
            SumOfExpensesLabel.Text = $"Total Expenses: {manager.CurrentBudget.SumOfExpenses}";
        }

        private void IncomeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStats();
        }
    }
}



