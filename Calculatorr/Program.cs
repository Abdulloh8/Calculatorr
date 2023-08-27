using Calculatorr.Classes;
using Calculatorr.Interface;
using System;

namespace Calculatorr
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                        var misol = new Misollar();
                        misol.Question();
                        break;
                    case 3:
                        var savol = new Savollar();
                        savol.Question();
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
