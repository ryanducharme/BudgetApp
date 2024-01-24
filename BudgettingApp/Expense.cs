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
        public float Amount { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        Category Category { get; set; }

        public Expense() { }

        public Expense(Category _category, float _amount, string name, string _description, DateTime _dateTime) { 
            Category = _category;
            Amount = _amount;
            Name = name;
            Description = _description;
            DateTime = _dateTime;
        }
    }
}
