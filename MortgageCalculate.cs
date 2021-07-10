using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    public class MortgageCalculate
    {
        private readonly static byte MONTHS_IN_YEAR = 12;
        private readonly static byte PERCENT = 100;

        private readonly int Principal;
        private readonly float AnnualInterest;
        private readonly byte Years;

        public MortgageCalculate(int principal, float annualInterest, byte years)
        {
            this.Principal = principal;
            this.AnnualInterest = annualInterest;
            this.Years = years;
        }

        public double CalculateBalance(short numberOfPaymentsMade)
        {
            float monthlyInterest = MonthlyInterest();
            float numberOfPayments = GetNumberOfPayments();

            double balance = Principal
                    * (Math.Pow(1 + monthlyInterest, numberOfPayments) - Math.Pow(1 + monthlyInterest, numberOfPaymentsMade))
                    / (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);

            return balance;
        }

        public double CalculateMortgage()
        {
            float monthlyInterest = MonthlyInterest();
            float numberOfPayments = GetNumberOfPayments();

            double mortgage = Principal
                    * (monthlyInterest * Math.Pow(1 + monthlyInterest, numberOfPayments))
                    / (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);

            return mortgage;
        }

        public double[] GetRemainingBalances()
        {
            var balances = new double[GetNumberOfPayments()];
            for (short month = 1; month <= balances.Length; month++)
                balances[month - 1] = CalculateBalance(month);

            return balances;
        }

        private float MonthlyInterest() => AnnualInterest / PERCENT / MONTHS_IN_YEAR;

        private int GetNumberOfPayments() => Years * MONTHS_IN_YEAR;
    }
}
