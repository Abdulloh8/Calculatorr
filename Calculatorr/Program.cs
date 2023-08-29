using Calculatorr.Classes;
using Calculatorr.Interface;
using System;

namespace Calculatorr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var misol = new Misollar();
            var savol = new Savollar();
            string yesorNo = "";
            do
            {
                IMenu menu = new Show();
                menu.ShowMenu();
                decimal operation = ValueManipulator.ConvertUserValueToDecimal(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        var calculator = new CalculateR3();
                        calculator.Calculate();
                        Reporter.ShowGratitude();
                        break;
                    case 2:
                        misol.Show();
                        break;
                    case 3:
                        savol.Show();
                        break;
                    case 4:
                        Reporter.ShowMultiplicationTable();
                        break;
                    default:
                        Reporter.ReportProgress("a value that does not exist");
                        break;
                }


                Console.WriteLine("Do you want to continue? [y/n]");
                yesorNo = Console.ReadLine();

            } while (yesorNo == "y" || yesorNo == "Y");
        }
    }
}
