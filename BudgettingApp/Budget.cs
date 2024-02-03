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
        public double SumOfExpenses
        {
            get
            {
                double total = 0;
                foreach (var expense in Expenses)
                {
                    total += expense.Amount;
                }
                return total;
            }
        }

        public double SumOfIncomes
        {
            get
            {
                double total = 0;
                foreach (var item in IncomeSources)
                {
                    total += item.Amount;
                }
                return total;
            }
        }
        

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
        public void RemoveExpense(Expense expense)
        { 
          if (Expenses.Contains(expense))
            {
              Expenses.Remove(expense);
            }
        }
        public void AddIncomeSource(IncomeSource income)
        {
            IncomeSources.Add(income);
        }  
    }
}
