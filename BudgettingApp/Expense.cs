using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BudgettingApp
{
    internal class Expense
    {
        public double Amount { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        Category Category { get; set; }

        public Expense() { }

        public Expense(Category _category, double _amount, string name, string _description, DateTime _date) { 
            Category = _category;
            Amount = _amount;
            Name = name;
            Description = _description;
            Date = _date;
        }
    }
}
