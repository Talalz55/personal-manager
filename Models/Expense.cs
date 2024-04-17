using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{

    public enum ExpensesCategory
    {
        Housing, Transportation, Electronics, Food, HealthFitness, PersonalCare, Education, DebtPayments, Insurance, GiftsDonations, Other
    }
    public class Expense
    {
        public double Amount { get; set; }
        public string AmountString => $"-{Amount}$";
        public ExpensesCategory ExpenseCategory { get; set; }
        public string Details { get; set; }
    }
}
