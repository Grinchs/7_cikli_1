using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_cikli_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            do
            {
                Console.WriteLine("Ievadiet skaitli no 1 līdz 5 vai IZIET lai beigtu darbību");

                string viens = Console.ReadLine();

                switch (viens)
                {
                    case "1":
                        Console.WriteLine("Viens");
                        break;

                    case "2":
                        Console.WriteLine("Divi");
                        break;

                    case "3":
                        Console.WriteLine("Trīs");
                        break;

                    case "4":
                        Console.WriteLine("Četri");
                        break;

                    case "5":
                        Console.WriteLine("Pieci");
                        break;

                    case "IZIET":
                        x = !x;
                        break;
                }
                
            }
            while (x);
        }

    }
}    