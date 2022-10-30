using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Ededi daxil edin: ");
            num = Convert.ToInt16(Console.ReadLine());

            sum += num % 10;
            num /= 10;
            sum += num % 10;
            num /= 10;
            sum += num % 10;
            num /= 10;
            sum += num % 10;
            num /= 10;

            Console.WriteLine("Cem: " + sum);
        }
    }
}
