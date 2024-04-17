using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public static class EarningsRepository
    {
        private static List<Earning> _earnings;
        static EarningsRepository()
        {
            _earnings= new List<Earning>();
            PopulateList();
        }
        private static void PopulateList()
        {
            //_earnings.Add(new Earning { Amount = 124.12, EarningCategory = EarningsCategory.Work, Details = "1st part of salary in April" });
            //_earnings.Add(new Earning { Amount = 500, EarningCategory = EarningsCategory.Gifts, Details = "Gift from my friend" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            //_earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });

        }

        public static List<Earning> GetEarnings()
        {
            return _earnings;
        } 

        public static void AddEarning(Earning earning)
        {
            _earnings.Insert(0, earning);
        }

        public static double GetTotal()
        {
            double total = 0;
            foreach (var earning in _earnings)
            {
                total += earning.Amount;
            }
            return total;
        }

        public static string GetLastEarning()
        {
            try
            {


                var last = _earnings[0].AmountString;

                return last;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public static List<EarningPercentage> CalculatePercentage()
        {
            double total = GetTotal();
            if (total == 0)
                total = 1;
            double work = 0;
            double gifts = 0;
            double investments = 0;
            double rentalIncome = 0;
            double personalLoans = 0;
            double other = 0;
            foreach (var earning in _earnings)
            {
                            //< !--Work, Gifts, Investments, RentalIncome, PersonalLoans, Other-- >
                switch (earning.EarningCategory)
                {
                    case EarningsCategory.Work: work += earning.Amount; break;
                    case EarningsCategory.Gifts: gifts += earning.Amount; break;
                    case EarningsCategory.Investments: investments += earning.Amount; break;
                    case EarningsCategory.RentalIncome: rentalIncome += earning.Amount; break;
                    case EarningsCategory.PersonalLoans: personalLoans += earning.Amount; break;
                    case EarningsCategory.Other: other += earning.Amount; break;                  
                }


            }

            double workPercentage = Math.Round(work * 100 / total, 2);
            double giftsPercentage = Math.Round(gifts * 100 / total, 2);
            double investmentsPercentage = Math.Round(investments * 100 / total, 2);
            double rentalIncomePercentage = Math.Round(rentalIncome * 100 / total, 2);
            double personalLoansPercentage = Math.Round(personalLoans * 100 / total, 2);
            double otherPercentage = Math.Round(other * 100 / total, 2);

            List<EarningPercentage> percentages = new List<EarningPercentage>()
            {
                new EarningPercentage {Category = "Work", Percentage = workPercentage},
                new EarningPercentage {Category = "Gifts", Percentage = giftsPercentage},
                new EarningPercentage {Category = "Investments", Percentage = investmentsPercentage},
                new EarningPercentage {Category = "Rental Income", Percentage = rentalIncomePercentage},
                new EarningPercentage {Category = "Personal Loans", Percentage = personalLoansPercentage},
                new EarningPercentage {Category = "Other", Percentage = otherPercentage}
            };
            percentages.Sort((y, x) => x.Percentage.CompareTo(y.Percentage));


            return percentages;
        }
    }
}
