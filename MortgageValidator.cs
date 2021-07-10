using FluentValidation;
using System;
using System.Linq;

namespace MortgageCalculator
{
    public class MortgageValidator : AbstractValidator<MortgageModel>
    {
        public MortgageValidator()
        {
            //Validate input data in Principal
            RuleFor(p => p.Principal)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please enter data for {PropertyName}")
                .Must(IsANumber).WithMessage("Contain invalid characters (char or blank) in {PropertyName}")
                .Must(CheckPrincipalInRange).WithMessage("Please enter data between 1.000$ and 1.000.000$ for {PropertyName}");

            //Validate input data in Annual interest
            RuleFor(p => p.AnnualInterest)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please enter data for {PropertyName}")
                .Must(IsANumber).WithMessage("Contain invalid characters (char or blank) in {PropertyName}")
                .Must(CheckRateInRange).WithMessage("Please enter data between 0 and 30 for {PropertyName}");

            //Validate input data in Years
            RuleFor(p => p.Years)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please enter data for {PropertyName}")
                .Must(IsANumber).WithMessage("Contain invalid characters (char or blank) in {PropertyName}")
                .Must(CheckYearsInRange).WithMessage("Please enter data between 0 and 30 for {PropertyName}");
        }

        /* 
         * The following method will be a predicate rule to additionally checking the data is qualified
         */

        //Check if the input data is a number
        private bool IsANumber(string number)
        {
            number = number.ToString().Replace(".", "");
            return number.All(char.IsNumber);
        }

        //Check if the principal is in the valid value range
        private bool CheckPrincipalInRange(string readNumber)
        {
            double number;
            bool isInRange;
            try
            {
                number = double.Parse(readNumber);
                isInRange = number >= 1_000 && number <= 1_000_000;
            }
            catch (FormatException)
            {
                isInRange = false;
            }
            return isInRange;
        }

        //Check if the interest reate is in the valid value range         
        private bool CheckRateInRange(string readNumber)
        {
            double number;
            bool isInRange;
            try
            {
                number = double.Parse(readNumber);
                isInRange = number > 0 && number <= 30;
            }
            catch (FormatException)
            {
                isInRange = false;
            }
            return isInRange;
        }

        //Check if the years is in the valid value range         
        private bool CheckYearsInRange(string readNumber)
        {
            int number;
            bool isInRange;
            try
            {
                number = int.Parse(readNumber);
                isInRange = number > 0 && number <= 30;
            }
            catch (FormatException)
            {
                isInRange = false;
            }
            return isInRange;
        }
       
    }
}
