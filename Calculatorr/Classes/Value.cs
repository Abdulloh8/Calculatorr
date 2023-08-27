
using System;

namespace Calculatorr.Classes
{
    public class Value
    {
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public string Operation { get; set; }

        public Value()
        {
            string firstNumber = ValueManipulator.GetUserValueByMessage("Enter values. \nFirst number: ");
            this.Operation = ValueManipulator.GetUserValueByMessage("Operation [+, -, *, /, % , s]: ");
            string secondNumber = "";
            if (Operation != "s")
            {
                secondNumber = ValueManipulator.GetUserValueByMessage("Second number: ");
            }
            else
            {
                secondNumber = "0";
            }
            
            Reporter.ReportProgress("Converting values in progress...");
            this.FirstNumber = ValueManipulator.ConvertUserValueToDecimal(firstNumber);
            this.SecondNumber = ValueManipulator.ConvertUserValueToDecimal(secondNumber);
        }
    }
}
