

using Calculatorr.Interface;
using System;

namespace Calculatorr.Classes
{
    public class Show : IMenu
    {
        public void ShowMenu()
        {
            Reporter.ReportProgress("Menu : ");
            Reporter.ReportProgress("1 : Calculator");
            Reporter.ReportProgress("2 : Misol yechish");
            Reporter.ReportProgress("3 : Savol topish");
            Reporter.ReportProgress("4 : Karra jadvali");
        }
    }
}
