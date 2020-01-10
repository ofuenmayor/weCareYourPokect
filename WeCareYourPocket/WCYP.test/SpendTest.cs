using System;
using WCYP.API.Model;
using Xunit;

namespace WCYP.test
{
    public class ExpenseTest
    {
        [Fact]
        public void CreateNewExpense()
        {
            Expense fuel = Expense.Create("");
            Assert.NotNull(fuel);
        }

        [Fact]
        public void CreateExpenseWithExpenseType()
        {
            Expense fuel = Expense.Create("Car");
            Assert.Equal("Car", fuel.Type);
        }

        [Fact]
        public void CreateExpenseWithExpenseValueAndDescription()
        {
            Expense aDinner = Expense.Create("Food");
            Assert.Equal("Food", aDinner.Type);
            Assert.Equal(50.00, aDinner.Value);
            Assert.Equal("Cena con fernanda", aDinner.Description);
        }
    }
}
