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

        //if (IncomeRadioButton.Checked) { }
        if (ExpenseRadioButton.Checked)
        {

          manager.CurrentBudget.AddExpense(new Expense(null, double.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));
          manager.SaveBudget();

          var lastExpense = manager.CurrentBudget.Expenses.Last();
          //dataGridView1.Rows.Add(lastExpense);

          //these two lines of code will update the data grid view with the new information
          //dataGridView1.DataSource = null;
          //dataGridView1.DataSource = manager.CurrentBudget.Expenses;
        }
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

      DoDataTableStuff();


      //fill the list view with the expenses and stuff
      foreach (Expense expense in manager.CurrentBudget.Expenses)
      {
        ListViewItem item = new ListViewItem(expense.Name);
        item.SubItems.Add(expense.Amount.ToString());
        item.SubItems.Add(expense.Date.ToShortDateString());
        item.SubItems.Add("");

        item.SubItems.Add(expense.Description);
        BudgetView.Items.Add(item);
      }

      toolStripStatusLabel1.Text = manager.CurrentBudget.SumOfExpenses.ToString();
      label2.Text = $"Total Expenses: {manager.CurrentBudget.SumOfExpenses}";
      BudgetNameLabel.Text = manager.CurrentBudget.Name;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {

      manager.SaveBudget();
    }

    public void DoDataTableStuff()
    {
      dataGridView1.DataSource = manager.CurrentBudget.Expenses;

    }

    private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void PopupMenu_Click(object sender, EventArgs e)
    {

    }
  }
}



