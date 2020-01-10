using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WCYP.API.Model
{
    public class Expense
    {
        public string Type;
        public double Value;
        public string Description;

        public Expense()
        {
           
        }
        public static Expense Create(string aExpenseType)
        {
            Expense aExpense = new Expense();
            aExpense.Type = aExpenseType;
            aExpense.Value = 50.00;
            aExpense.Description = "Cena con fernanda";
            return aExpense;
        }
    }
}
