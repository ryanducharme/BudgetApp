using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BudgettingApp
{
    internal class Budget
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<IncomeSource> IncomeSources { get; set; }
        public Budget(string name)
        {
            Name = name;
            Expenses = new List<Expense>();
            IncomeSources = new List<IncomeSource>();
        }

        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }
        public void AddIncomeSource(IncomeSource income)
        {
            IncomeSources.Add(income);
        }
    }
}
