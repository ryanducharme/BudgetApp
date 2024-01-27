using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BudgettingApp
{
    public partial class Form1 : Form
    {
        BudgetManager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new BudgetManager();
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            if (AmountTextBox.Text != "" && NameBox.Text != "")
            {
                manager.CurrentBudget.AddExpense(new Expense(null, float.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));
                manager.SaveBudget();

                var lastExpense = manager.CurrentBudget.Expenses.Last();

                ListViewItem item = new ListViewItem(lastExpense.Name);
                item.SubItems.Add(lastExpense.Amount.ToString());
                item.SubItems.Add(lastExpense.Date.ToShortDateString());
                item.SubItems.Add("");
                item.SubItems.Add(lastExpense.Description);
                BudgetView.Items.Add(item);


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
            BudgetView.Items.Clear();
            //fill the list view with the expenses and stuff
            foreach(Expense expense in manager.CurrentBudget.Expenses)
            {
                ListViewItem item = new ListViewItem(expense.Name);
                item.SubItems.Add(expense.Amount.ToString());
                item.SubItems.Add(expense.Date.ToShortDateString());
                item.SubItems.Add("");

                item.SubItems.Add(expense.Description);
                BudgetView.Items.Add(item);
            }

            toolStripStatusLabel1.Text = manager.CurrentBudget.SumOfExpenses.ToString();
            label2.Text = $"Total Expenses: {manager.CurrentBudget.SumOfExpenses.ToString()}";
        }
    }
}
