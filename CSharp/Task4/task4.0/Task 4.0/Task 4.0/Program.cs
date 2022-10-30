using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.WriteLine("Ayı daxil edin: ");
            month = Console.ReadLine();

            switch (month)
            {
                case "january":
                    Console.WriteLine(31);
                    break;
                case "february":
                    Console.WriteLine("28(29)");
                    break;
                case "march":
                    Console.WriteLine(31);
                    break;
                case "april":
                    Console.WriteLine(30);
                    break;
                case "may":
                    Console.WriteLine(31);
                    break;
                case "june":
                    Console.WriteLine(30);
                    break;
                case "july":
                    Console.WriteLine(31);
                    break;
                case "august":
                    Console.WriteLine(31);
                    break;
                case "september":
                    Console.WriteLine(30);
                    break;
                case "october":
                    Console.WriteLine(31);
                    break;
                case "november":
                    Console.WriteLine(30);
                    break;
                case "december":
                    Console.WriteLine(31);
                    break;
                default:
                    Console.WriteLine("Xeta!\nAy adi duzgun daxil edilmeyib");
                    break;
            }

        }
    }
}
