using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int second = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i=first ;i <= second ;i++) 
            {
                for (int x = 1; x <i; x++)
                {
                    if (i % x == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum = 0;    

                }
                else
                {
                    sum = 0;
                    continue;
                }
            }




        }
    }
}
