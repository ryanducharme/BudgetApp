using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgettingApp
{
    
    internal class ExpenseGroup : List<Expense>
    {
        public string Name { get; private set; }
        public ExpenseGroup(string _name) 
        { 
            Name = _name;
        }
        public void AddEntry(Expense expense)
        {
            Add(expense);
        }
        
    }
}
