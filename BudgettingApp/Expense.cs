using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgettingApp
{
    internal class Expense
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        Category Category { get; set; }

        public Expense(int _id, Category _category, float _amount, string name, string _description, DateTime _dateTime) { 
            _id = Id;
            Category = _category;
            Amount = _amount;
            Name = name;
            Description = _description;
            DateTime = _dateTime;
        }
    }
}
