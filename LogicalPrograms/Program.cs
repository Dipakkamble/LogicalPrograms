using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) 
            {
                if (num % i == 0)
                {
                    sum++;
                }
            }
            if (sum==2)
            {
                Console.WriteLine("The number is prime");
            }
            else 
            {
                Console.WriteLine("The number is not prime");
            }
            Console.ReadLine();
        }
    }
}
