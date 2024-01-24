using System.Diagnostics;
using System.IO;

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
            int amount;
            if (AmountTextBox.Text != "" && NameBox.Text != "")
            {
                //expenseManager.CurrentExpenseGroup.AddEntry(new Expense(1, null, float.Parse(AmountTextBox.Text), NameBox.Text, DescriptionBox.Text, DatePicker.Value));

                //var lastExpense = expenseManager.CurrentExpenseGroup.Last<Expense>();
                //Debug.WriteLine(lastExpense.Name);
                //ListViewItem item = new ListViewItem(lastExpense.Name);
                //item.SubItems.Add(lastExpense.Amount.ToString());
                //item.SubItems.Add(lastExpense.Description);
                //item.SubItems.Add(lastExpense.DateTime.ToString());
                //ExpenseView.Items.Add(item);
            }
        }

        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File";
            string folderName = "Budgets";

            // Combine base directory with the folder name
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

            // Check if the folder exists, if not, create it
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Set the file path within the folder
            string filePath = Path.Combine(folderPath, "budget.json");
            
            // Show the file dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                //string filePath = openFileDialog.FileName;

                //Debug.WriteLine(filePath);
            }
            else
            {
                
            }
            
        }
    }
}
