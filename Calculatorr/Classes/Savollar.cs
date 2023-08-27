
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorr.Classes
{
    public class Savollar
    {
        public Savol[] savollar = new Savol[3];

        public void Add()
        {
            savollar[0] = new Savol();
            savollar[1] = new Savol();
            savollar[2] = new Savol();

            savollar[0].savol = "savol 2010 yilgi jahon chempionatida qaysi davlat 1 urindi olgan: ";
            savollar[0].variant1 = "1 : Brazilya";
            savollar[0].variant2 = "2 : Anglya";
            savollar[0].variant3 = "3 : Ispanya";
            savollar[0].variant4 = "4 : Fransiya";
            savollar[0].tugrijavob = "3";

            savollar[1].savol = "savol 2018 yilgi jahon chempionatida qaysi davlat 1 urindi olgan: ";
            savollar[1].variant1 = "1 : Brazilya";
            savollar[1].variant2 = "2 : Anglya";
            savollar[1].variant3 = "3 : Ispanya";
            savollar[1].variant4 = "4 : Fransiya";
            savollar[1].tugrijavob = "4";

            savollar[2].savol = "savol 2006 yilgi jahon chempionatida qaysi davlat 1 urindi olgan: ";
            savollar[2].variant1 = "1 : Germanya";
            savollar[2].variant2 = "2 : Anglya";
            savollar[2].variant3 = "3 : Italiya";
            savollar[2].variant4 = "4 : Argentina";
            savollar[2].tugrijavob = "3";
        }
        public void Question()
        {
            Add();
            for (int i = 0; i < savollar.Length; i++)
            {
                Reporter.ReportProgress(savollar[i].savol);
                Console.WriteLine();
                Reporter.ReportProgress(savollar[i].variant1);
                Reporter.ReportProgress(savollar[i].variant2);
                Reporter.ReportProgress(savollar[i].variant3);
                Reporter.ReportProgress(savollar[i].variant4);
                string answer = Console.ReadLine();
                if (answer == savollar[i].tugrijavob)
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
