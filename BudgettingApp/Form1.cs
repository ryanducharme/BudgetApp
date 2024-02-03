using BudgettingApp;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BudgettingApp
{
    public partial class Form1 : Form
    {
        BudgetManager _manager;
        DataTable _dataTable;

        public Form1()
        {
            InitializeComponent();
            _manager = new BudgetManager();

            //come up with a way to store the last used budget location to auto open when opening the application
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //if there is data in the fields
            if (!String.IsNullOrEmpty(AmountTextBox.Text) && !String.IsNullOrEmpty(NameBox.Text))
            {
                if (IncomeRadioButton.Checked)
                {
                    _manager.CurrentBudget.AddIncomeSource(new IncomeSource(null, double.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));
                    _manager.SaveBudget();

                    IncomeDataGridView.DataSource = null;
                    IncomeDataGridView.DataSource = _manager.CurrentBudget.IncomeSources;

                }
                if (ExpenseRadioButton.Checked)
                {
                    _manager.CurrentBudget.AddExpense(new Expense(null, double.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));
                    _manager.SaveBudget();

                    var lastExpense = _manager.CurrentBudget.Expenses.Last();
                    //dataGridView1.Rows.Add(lastExpense);

                    //these two lines of code will update the data grid view with the new information
                    ExpenseDataGridView.DataSource = null;
                    ExpenseDataGridView.DataSource = _manager.CurrentBudget.Expenses;

                }
                UpdateStats();
            }
        }


        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manager.NewBudget();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manager.LoadBudget();

            DoDataTableStuff();

            UpdateStats();

            BudgetNameLabel.Text = _manager.CurrentBudget.Name;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manager.SaveBudget();
        }

        public void DoDataTableStuff()
        {
            IncomeDataGridView.DataSource = _manager.CurrentBudget.IncomeSources;
            ExpenseDataGridView.DataSource = _manager.CurrentBudget.Expenses;
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
            SumOfIncomeLabel.Text = $"Total Income: {_manager.CurrentBudget.SumOfIncomes}";
            SumOfExpensesLabel.Text = $"Total Expenses: {_manager.CurrentBudget.SumOfExpenses}";
        }

        private void IncomeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStats();
        }
    }
}



