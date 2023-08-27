

using System;


namespace Calculatorr.Classes
{
    public static class Reporter
    {
        public static void ShowGratitude()
        {
            Console.WriteLine("Thank you for using our calculator.");
        }
        public static void ReportProgress(string message)
        {
            Console.WriteLine(message);
        }
        public static void ShowMultiplicationTable()
        {
            Console.WriteLine("Here is the multiplication table for your reference.");
            for (int outerIteration = 2; outerIteration < 10; outerIteration++)
            {
                Console.WriteLine("********");
                for (int iteration = 1; iteration < 10; iteration++)
                {
                    Console.WriteLine($"{outerIteration} * {iteration} = {outerIteration * iteration}");
                }
            }
        }
    }
}
