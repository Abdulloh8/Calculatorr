
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorr.Classes
{

    public class Misollar
    {
        private Misol[] misollar = new Misol[3];


        private void Add()
        {
            misollar[0] = new Misol();
            misollar[0].Question = "5 + 17 = ?";
            misollar[0].Answer = "22";
            misollar[1] = new Misol();
            misollar[1].Question = "31 - 14 = ?";
            misollar[1].Answer = "17";
            misollar[2] = new Misol();
            misollar[2].Question = "5 + 7 = ?";
            misollar[2].Answer = "12";
        }
        public void Question()
        {
            Add();
            for (int i = 0; i < misollar.Length; i++)
            {
                Reporter.ReportProgress(misollar[i].Question);
                string answer = Console.ReadLine();
                if (answer == misollar[i].Answer)
                {
                    Reporter.ReportProgress("Correct");
                }
                else
                {
                    Reporter.ReportProgress("error");
                }
            }
        }
    }
}
