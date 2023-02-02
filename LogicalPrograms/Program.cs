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
            int rem = 0, rev=0;
            Console.WriteLine("Enter the number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            while ( num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num=num/10;
            }
            Console.WriteLine("The reverse number is {0}",rev); 
            Console.ReadLine();
        }
    }
}
