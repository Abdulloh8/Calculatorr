

using System;

namespace Calculatorr.Classes
{
    public class CalculateR3 : Value
    {
        public void Calculate()
        {
            Reporter.ReportProgress("Calculating results...");
            string template;

            if (Operation == "s")
            {
                template = $"{FirstNumber} {Operation} =";
            }
            else
            {
                template = $"{FirstNumber} {Operation} {SecondNumber} =";
            }

            
            decimal result = Operation switch
            {
                "+" => Sum(FirstNumber, SecondNumber),
                "-" => Substract(FirstNumber, SecondNumber),
                "*" => Multply(FirstNumber, SecondNumber),
                "/" => Divide(FirstNumber, SecondNumber),
                "%" => CalculateRemainder(FirstNumber, SecondNumber),
                "s" => Squr(FirstNumber),
                _ => 0
            };

            Reporter.ReportProgress($"{template} {result}");
        }
        
        private static decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static decimal Substract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private static decimal Multply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private static decimal CalculateRemainder(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber % secondNumber;
        }
        private static decimal Squr(decimal firstNumber)
        {
            return firstNumber * firstNumber;
        }
    }
}
