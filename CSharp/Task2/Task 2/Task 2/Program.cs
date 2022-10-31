using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded,num1,num2,num3;
            Console.WriteLine("Uc reqemli ededi daxil edin: ");
            

            try
            {
                eded = Convert.ToInt32(Console.ReadLine());
                int ededForTest = eded;
                num1 = eded % 10;
                eded = eded / 10;
                num2 = eded % 10;
                eded = eded / 10;
                num3 = eded % 10;
                if (ededForTest < 1000 && ededForTest > 99)
                {
                    if (num1 == num2 && num1 == num3 && num1 == num3)
                    {
                        Console.WriteLine("Bütün reqemler beraberdir");
                    }

                    else
                    {
                        Console.WriteLine("Bütün reqemler beraber deyil");
                    }
                }
                else
                {
                    Console.WriteLine("Ucreqemli eded daxil edilmeyib!");
                }
            }

            catch
            {
                Console.WriteLine("Xeta bas verdi!! Yeniden yoxlayin");
            }
            
            
        }
    }
}
