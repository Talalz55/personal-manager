using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public static class ExpensesRepository
    {
        private static List<Expense> _expenses;
        static ExpensesRepository()
        {
            _expenses = new List<Expense>();
        }
       
        public static double GetTotal()
        {
            double total = 0;
            foreach(var expense in _expenses)
            {
                total += expense.Amount;
            }
            return total;
        }

        public static List<Expense> GetEarnings()
        {
            return _expenses;
        }

        public static void AddExpense(Expense expense)
        {
            _expenses.Insert(0, expense);
        }

        public static string GetLastExpense()
        {
            try
            {
                var last = _expenses[0].AmountString;

                return last;
            }
            catch (Exception ex) {
                return null;
            }
        }

        //Housing, Transportation, Electronics, Food, HealthFitness, PersonalCare, Education, DebtPayments, Insuarance, GiftsDonations, Other

        public static List<ExpensePercentage> CalculatePercentage()
        {
            double total = GetTotal();
            if (total == 0)
                total = 1;
            double housing = 0;
            double transportation = 0;
            double electronics = 0;
            double food = 0;
            double healthFitness = 0;
            double personalCare = 0;
            double education = 0;
            double debtPayments = 0;
            double insuarance = 0;
            double giftsDonations = 0;
            double other = 0;
            foreach(var expense in _expenses)
            {
                switch (expense.ExpenseCategory)
                {
                    case ExpensesCategory.Housing: housing += expense.Amount; break;
                    case ExpensesCategory.Transportation: transportation += expense.Amount; break;
                    case ExpensesCategory.Electronics: electronics += expense.Amount; break;
                    case ExpensesCategory.Food: food += expense.Amount; break;
                    case ExpensesCategory.HealthFitness: healthFitness += expense.Amount; break;
                    case ExpensesCategory.PersonalCare: personalCare += expense.Amount; break;
                    case ExpensesCategory.Education: education += expense.Amount; break;
                    case ExpensesCategory.DebtPayments: debtPayments += expense.Amount; break;
                    case ExpensesCategory.Insurance: insuarance += expense.Amount; break;
                    case ExpensesCategory.GiftsDonations: giftsDonations+= expense.Amount; break;
                    case ExpensesCategory.Other: other += expense.Amount; break;

                }


            }

            double housingPercentage = Math.Round(housing * 100 / total, 2);
            double transportationPercentage = Math.Round(transportation * 100 / total, 2);
            double electronicsPercentage = Math.Round(electronics * 100 / total, 2);
            double foodPercentage = Math.Round(food * 100 / total, 2);
            double healthFitnessPercentage = Math.Round(healthFitness * 100 / total, 2);
            double personalCarePercentage = Math.Round(personalCare * 100 / total, 2);
            double educationPercentage = Math.Round(education * 100 / total, 2);
            double debtPaymentsPercentage = Math.Round(debtPayments * 100 / total, 2);
            double insuarancePercentage = Math.Round(insuarance * 100 / total, 2);
            double giftsDonationsPercentage = Math.Round(giftsDonations * 100 / total, 2); ;
            double otherPercentage = Math.Round(other * 100 / total, 2); 

            List<ExpensePercentage> percentages= new List<ExpensePercentage>()
            {
                new ExpensePercentage {Category = "Housing", Percentage = housingPercentage},
                new ExpensePercentage {Category = "Transportation", Percentage = transportationPercentage},
                new ExpensePercentage {Category = "Electronics", Percentage = electronicsPercentage},
                new ExpensePercentage {Category = "Food", Percentage = foodPercentage},
                new ExpensePercentage {Category = "Health/Fitness", Percentage = healthFitnessPercentage},
                new ExpensePercentage {Category = "Personal Care", Percentage = personalCarePercentage},
                new ExpensePercentage {Category = "Education", Percentage = educationPercentage},
                new ExpensePercentage {Category = "Debt Payments", Percentage = debtPaymentsPercentage},
                new ExpensePercentage {Category = "Insuarance", Percentage = insuarancePercentage},
                new ExpensePercentage {Category = "Gifts/Donations", Percentage = giftsDonationsPercentage},
                new ExpensePercentage {Category = "Other", Percentage = otherPercentage}
            };
            percentages.Sort((y, x) => x.Percentage.CompareTo(y.Percentage));


            return percentages;
        }
    }
}
