using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BudgettingApp
{
    internal class ExpenseManager
    {
        public ExpenseGroup CurrentExpenseGroup { get; private set; }
        public ExpenseManager() {
            
        }

        //public void SaveExpenses()
        //{
        //    TextWriter writer = null;
        //    try
        //    {
        //        var serializer = new XmlSerializer(typeof(T));
        //        writer = new StreamWriter(filePath, append);
        //        serializer.Serialize(writer, objectToWrite);
        //    }
        //    finally
        //    {
        //        if (writer != null)
        //            writer.Close();
        //    }
        //}

        public void LoadExpenses()
        {
            CurrentExpenseGroup = new ExpenseGroup("JuneExpenses");
        }
    }
}
