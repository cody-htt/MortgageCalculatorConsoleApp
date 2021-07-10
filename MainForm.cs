using FluentValidation.Results;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class MainForm : Form
    {
        //We declare a format for the out put result inside the listbox Results
        private const string FORMAT = "{0:0.00}";
        /*
         * This BindingList is used to display the error if the data is invalid with fail result
         * If the data is validated with pass result, the out put will be the final calculation result
         */
        private readonly BindingList<string> results = new BindingList<string>();

        public MainForm()
        {
            InitializeComponent();
            resultListBox.DataSource = results;
            ClearAll();
        }

        /*
         * The following code will display a tooltip message whenever the user hover the mouse on the text boxes
         *The tooltip will display a brief data rule for the user to know how the value should be enterred
        */
        private void annualInterestTextBox_MouseHover(object sender, EventArgs e)
        {
            MortgageToolTip.SetToolTip(annualInterestTextBox, "Enter number between 0 and 30 ");
        }

        private void principalTextBox_MouseHover(object sender, EventArgs e)
        {
            MortgageToolTip.SetToolTip(principalTextBox, "Enter a number between 1.000 and 1.000.000 ");
        }

        private void yearsTextBox_MouseHover(object sender, EventArgs e)
        {
            MortgageToolTip.SetToolTip(yearsTextBox, "Enter number between 0 and 30 ");
        }

        //When clicking the Reset button, the system firstly clear all the text boxes and listbox Results
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        // This method will clear all the text from the text boxes and the list box [Results]
        private void ClearAll()
        {
            results.Clear();
            principalTextBox.Clear();
            annualInterestTextBox.Clear();
            yearsTextBox.Clear();
        }

        /*
         * When clicking the Calculate button, the system will first validate the input data
         * If the data is invalid, then the warning message will be promped within the listbox Results
         * If the data is valid, then the system will calculate then printing the result
        */
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            results.Clear();

            MortgageModel mortgageModel = new MortgageModel
            {
                Principal = principalTextBox.Text,
                AnnualInterest = annualInterestTextBox.Text,
                Years = yearsTextBox.Text
            };
            //Validate the created object data
            MortgageValidator validator = new MortgageValidator();
            ValidationResult result = validator.Validate(mortgageModel);

            if (result.IsValid == false)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    results.Add($"{failure.ErrorMessage}");
                }
            }
            else
            {
                results.Clear();
                int principal = Convert.ToInt32(principalTextBox.Text);
                float annualInterest = float.Parse(annualInterestTextBox.Text);
                byte years = Convert.ToByte(yearsTextBox.Text);
                BtnCalculateMortgage_Click(principal, annualInterest, years);
            }
        }

        //This method contain 2 methods to display the result of mortgage calculation
        private void BtnCalculateMortgage_Click(int principal, float annualInterest, byte years)
        {
            MortgageCalculate mortgageCalculate = new MortgageCalculate(principal, annualInterest, years);
            DisplayMortgage(mortgageCalculate);
            DisplayBalance(mortgageCalculate);
        }

        //This method will convert double to string then format the value and display the mortage payment on the Listbox
        private void DisplayMortgage(MortgageCalculate mortgageCalculate)
        {
            string mortgageFormatted = String.Format(FORMAT, mortgageCalculate.CalculateMortgage());
            results.Add("MORGAGE PAYMENT");
            results.Add("Monthly mortgage payment: " + mortgageFormatted);
            results.Add("-------------------------------------------");
        }

        //This method will convert double to string then format the value and display the mortage balance on the Listbox
        private void DisplayBalance(MortgageCalculate mortgageCalculate)
        {
            results.Add("PAYMENT SCHEDULE");
            results.Add("");
            string[] listBalance = new string[mortgageCalculate.GetRemainingBalances().Length];
            int i = 0;
            foreach (var balance in mortgageCalculate.GetRemainingBalances())
            {
                listBalance[i] = String.Format(FORMAT, balance);
                results.Add($"Month {i + 1}: {listBalance[i]}");
                i++;
            }
        }

    }
}
