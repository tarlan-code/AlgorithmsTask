using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;

            Console.WriteLine("Ededi daxil edin: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);
           
        }
    }
}
