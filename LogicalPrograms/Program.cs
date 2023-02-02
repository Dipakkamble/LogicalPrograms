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
            int a = 0, b = 1, c;
            Console.WriteLine("Enter the number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < num; i++) 
            {
                c = a + b;
                Console.Write(c + " ");
                a=b; 
                b=c;
            }
            Console.ReadLine();
        }
    }
}
