
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the secand number ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1 ; i <= num2; i++)
            {
                int x = 1;
                int sum = 0;
                while (x < i)
                {
                    if (i % x == 0)
                        sum = sum + x;
                    x++;
                }
              

                if (sum == i && i !=0)
                {
                   
                    Console.WriteLine("--------");
                    Console.WriteLine("{0}",i);
                }

            }




        }
    }
}
