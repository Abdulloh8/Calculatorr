
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorr.Classes
{

    public class Misollar
    {
        private int count = 3;
        private Misol[] misollar = new Misol[10];
        string selection = "";
        public Misollar() 
        {
            this.misollar[0] = new Misol();
            this.misollar[0].Question = "5 + 17 = ?";
            this.misollar[0].Answer = "22";
            this.misollar[1] = new Misol();
            this.misollar[1].Question = "31 - 14 = ?";
            this.misollar[1].Answer = "17";
            this.misollar[2] = new Misol();
            this.misollar[2].Question = "5 + 7 = ?";
            this.misollar[2].Answer = "12";
        }

        public void Show()
        {
            Console.WriteLine("1 : Misollarni yechish");
            Console.WriteLine("2 : Misol qushish");
            selection =  Console.ReadLine();
            switch(selection)
            {
                case "1": Question(); break;
                case "2": Add(); break;
                default: Console.WriteLine("non-existent choice"); break;
                    
            }

        }


        private void Add()
        {
            Console.WriteLine("Misolni kiriting");
            misollar[count] = new Misol();
            misollar[count].Question = Console.ReadLine();
            Console.WriteLine("Javobini kiriting");
            misollar[count].Answer = Console.ReadLine();
            Console.WriteLine("Misolingiz qushildi");
            count++;
        }
        public void Question()
        {
            for (int i = 0; i < count; i++)
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
