using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public enum EarningsCategory
    {
        Work, Gifts, Investments, RentalIncome, PersonalLoans, Other
    }
    public class Earning
    {
        public double Amount { get; set; }
        public string AmountString => $"+{Amount}$";

        public EarningsCategory EarningCategory { get; set; }
        public string Details { get; set; }
    }
}
