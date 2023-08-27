

using System;

namespace Calculatorr.Classes
{
    public static class ValueManipulator
    {
        public static string GetUserValueByMessage(string message)
        {
            Console.WriteLine(message);
            string a = Console.ReadLine();
            return a;
        }

        public static  decimal ConvertUserValueToDecimal(string userValue)
        {
            return Convert.ToDecimal(userValue);
        }
    }
}
