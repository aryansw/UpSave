using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpSave.Our_Scripts
{
    public class RequestHandling
    {   
        static private Dictionary<string, decimal> avgMonthExpenses = new Dictionary<string, decimal>();
        static private Dictionary<string, decimal> amountPerMonth = new Dictionary<string, decimal>();
        static private Dictionary<string, decimal> dues = new Dictionary<string, decimal>();
        static private Dictionary<string, decimal> possibleSavings = new Dictionary<string, decimal>();
        static private decimal goals = new decimal();
        static private decimal CurrentSavings = new decimal();
        static private decimal Income = new decimal();


        public Dictionary<string, Decimal> SetavgMonthExpenses( Dictionary<string, decimal> a )
        {
            avgMonthExpenses = a;
            return avgMonthExpenses;
        }

        public Dictionary<string, decimal> GetavgMonthExpenses => avgMonthExpenses;

        public Dictionary<string, decimal> GetamountPerMonth() => amountPerMonth;

        public Dictionary<string, Decimal> SetAmountPerMonth(Dictionary<string, decimal> b)
        {
            amountPerMonth = b;
            return amountPerMonth;
        }

        public Dictionary<string, Decimal> SetDues(Dictionary<string, decimal> a)
        {
            dues = a;
            return dues;
        }

        public Dictionary<string, decimal> GetDues => dues;

        public Dictionary<string, decimal> GetPossibleSavings() => amountPerMonth;

        public Dictionary<string, decimal> SetPossibleSavings(Dictionary<string, decimal> b)
        {
            possibleSavings = b;
            return possibleSavings;
        }

        public decimal SetGoals(decimal c)
        {
            goals = c;
            return goals;
        }

        public decimal GetGoals() => goals;

        public decimal SetCurrentSavings(decimal c)
        {
            CurrentSavings = c;
            return CurrentSavings;
        }

        public decimal GetCurrentSavings() => CurrentSavings;

        public decimal SetIncome(decimal c)
        {
            Income = c;
            return Income;
        }

        public decimal GetIncome() => Income;

        
        
    }
}   