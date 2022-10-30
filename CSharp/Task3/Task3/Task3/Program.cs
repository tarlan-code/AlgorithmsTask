using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lang;
            Console.WriteLine("Dil kodun daxil edin: ");
            lang = Convert.ToChar(Console.ReadLine());

            switch (lang)
            {
                case 'a':
                    Console.WriteLine("Azerbaycan dili seçildi");
                    break;
                case 'A':
                    Console.WriteLine("AZ dili seçildi");
                    break;
                case 'r':
                    Console.WriteLine("Rus dili seçildi");
                    break;
                case 'R':
                    Console.WriteLine("RU dili seçildi");
                    break;
                default:
                    Console.WriteLine("Yanlış sorğu");
                    break ;
            }
        }
    }
}
