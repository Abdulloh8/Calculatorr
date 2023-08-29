
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorr.Classes
{
    public class Savollar
    {
        public Savol[] savollar = new Savol[10];
        private int count = 3;
        string selection = "";
        public Savollar() 
        {
            this.savollar[0] = new Savol();
            this.savollar[1] = new Savol();
            this.savollar[2] = new Savol();

            this.savollar[0].savol = "savol 2010 yilgi jahon chempionatida qaysi davlat 1 urindi olgan: ";
            this.savollar[0].variant1 = "Brazilya";
            this.savollar[0].variant2 = "Anglya";
            this.savollar[0].variant3 = "Ispanya";
            this.savollar[0].variant4 = "Fransiya";
            this.savollar[0].tugrijavob = "3";

            this.savollar[1].savol = "savol 2018 yilgi jahon chempionatida qaysi davlat 1 urindi olgan: ";
            this.savollar[1].variant1 = "Brazilya";
            this.savollar[1].variant2 = "Anglya";
            this.savollar[1].variant3 = "Ispanya";
            this.savollar[1].variant4 = "Fransiya";
            this.savollar[1].tugrijavob = "4";

            this.savollar[2].savol = "savol 2006 yilgi jahon chempionatida qaysi davlat 1 urindi olgan: ";
            this.savollar[2].variant1 = "Germanya";
            this.savollar[2].variant2 = "Anglya";
            this.savollar[2].variant3 = "Italiya";
            this.savollar[2].variant4 = "Argentina";
            this.savollar[2].tugrijavob = "3";
        }

        public void Show()
        {
            Console.WriteLine("1 : Savollardi topish");
            Console.WriteLine("2 : Savol qushish");
            selection = Console.ReadLine();
            switch (selection)
            {
                case "1": Question(); break;
                case "2": Add(); break;
                default: Console.WriteLine("non-existent choice"); break;

            }

        }


        public void Add()
        {
            Console.WriteLine("Savolni kiriting");
            savollar[count] = new Savol();
            savollar[count].savol = Console.ReadLine();
            Console.WriteLine("1 variantni kiriting");
            savollar[count].variant1 = Console.ReadLine();
            Console.WriteLine("2 variantni kiriting");
            savollar[count].variant2 = Console.ReadLine();
            Console.WriteLine("3 variantni kiriting");
            savollar[count].variant3 = Console.ReadLine();
            Console.WriteLine("4 variantni kiriting");
            savollar[count].variant4 = Console.ReadLine();
            Console.WriteLine("To'g'ri javobni raqamoni kiriting");
            savollar[count].tugrijavob = Console.ReadLine();
            Console.WriteLine("Savolingiz qushildi");
            count++;
        }
        public void Question()
        {
            for (int i = 0; i < count; i++)
            {
                Reporter.ReportProgress(savollar[i].savol);
                Console.WriteLine();
                Reporter.ReportProgress($"1 : {savollar[i].variant1}");
                Reporter.ReportProgress($"2 : {savollar[i].variant2}");
                Reporter.ReportProgress($"3 : {savollar[i].variant3}");
                Reporter.ReportProgress($"4 : {savollar[i].variant4}");
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
