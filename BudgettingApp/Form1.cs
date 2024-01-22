using System.Diagnostics;

namespace BudgettingApp
{
    public partial class Form1 : Form
    {
        ExpenseManager expenseManager;

        public Form1()
        {
            InitializeComponent();
            expenseManager = new ExpenseManager();
            expenseManager.LoadExpenses();
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            int amount;
            if (AmountTextBox.Text != "" && NameBox.Text != "")
            {
                expenseManager.CurrentExpenseGroup.AddEntry(new Expense(1, null, float.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));

                var lastExpense = expenseManager.CurrentExpenseGroup.Last<Expense>();
                Debug.WriteLine(lastExpense.Name);
                ListViewItem item = new ListViewItem(lastExpense.Name);
                item.SubItems.Add(lastExpense.Amount.ToString());
                item.SubItems.Add(lastExpense.Description);
                item.SubItems.Add(lastExpense.DateTime.ToString());
                ExpenseView.Items.Add(item);
            }
        }

        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
