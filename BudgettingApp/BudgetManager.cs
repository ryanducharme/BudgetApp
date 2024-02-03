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
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BudgettingApp
{
    internal class BudgetManager
    {
        public Budget CurrentBudget { get; private set; }
        
        string folderName = "Budgets";
        string folderPath;
        public BudgetManager() 
        {
             folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);
        }

        public void NewBudget()
        {
            string budgetName = "";
            //create a new json file to save the budget data
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Combine base directory with the folder name
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

                saveFileDialog.Title = "Save a budget";
                saveFileDialog.InitialDirectory = folderPath;
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = ".json";

                Debug.WriteLine(folderPath + " " + saveFileDialog.FileName);

                // Check if the folder exists, if not, create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }


                // Show the file dialog and check if the user clicked OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = Path.Combine(folderPath, saveFileDialog.FileName);
                    Debug.WriteLine(folderPath + " " + saveFileDialog.FileName);
                    budgetName = saveFileDialog.FileName;
                    
                    Budget newBudget = new Budget(Path.GetFileNameWithoutExtension(filePath));
                    CurrentBudget = newBudget;
                    SaveBudget();
                    
                    //CurrentBudget = LoadBudget(filePath);
                    Debug.WriteLine(CurrentBudget.Name);
                }
            }
        }

        public void LoadBudget()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Combine base directory with the folder name
                string folderName = "Budgets";
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

                ofd.Title = "Save a budget";
                ofd.InitialDirectory = folderPath;
                ofd.DefaultExt = ".json";


                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    Debug.WriteLine($"{ofd.FileName}");
                    string json = File.ReadAllText(ofd.FileName);
                    CurrentBudget = JsonSerializer.Deserialize<Budget>(json);
                    Debug.WriteLine(CurrentBudget.Name);
                }
                
            }
            
        }

        public void SaveBudget()
        {
            string json = JsonSerializer.Serialize(CurrentBudget);
            
            try
            {
                File.WriteAllText(Path.Combine(folderPath, CurrentBudget.Name) + ".json", json);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

    }
}
