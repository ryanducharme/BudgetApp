using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BudgettingApp
{
    internal class BudgetManager
    {
        Budget currentBudget;
        public BudgetManager() 
        {
            //SaveBudget(NewBudget("MyBudget1"));
            currentBudget = LoadBudget("C:\\Users\\Ryan\\source\\repos\\BudgetApp\\BudgettingApp\\Budgets\\MyBudget1.json");
            Debug.WriteLine(currentBudget.Expenses[0].Name);
        }

        public Budget NewBudget(string name)
        {
            Budget b = new Budget(name);
            
            //test data
            b.AddExpense(new Expense(null, 100, "apple headphones", "something I got from best buy the other day", DateTime.Now));
            
            return b;
        }

        public Budget LoadBudget(string path)
        {
            string json = File.ReadAllText(path);
            var res = JsonSerializer.Deserialize<Budget>(json);
            return res;
        }

        public void SaveBudget(Budget budget)
        {
            string json = JsonSerializer.Serialize(budget);
            var path = $"C:\\Users\\Ryan\\source\\repos\\BudgetApp\\BudgettingApp\\Budgets\\{budget.Name}.json";
            
            try
            {
                File.WriteAllText(path , json);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            

            
            
        }

        

    }
}
