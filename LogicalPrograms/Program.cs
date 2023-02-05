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
            Console.WriteLine("Enter the number for N distinct coupon: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int[] coupons= new int[num];
            Random random= new Random();
            int generated =0;

            while (i < num)
            {
                int randomNumber = random.Next(num+1);
                generated++;
                Console.WriteLine("Generated random number is:" + randomNumber);
                if (coupons.Contains(randomNumber))
                {
                    continue;
                }
                else 
                {
                    coupons[i] = randomNumber;
                }
                i++; 
            }
            foreach (int coupon in coupons)
            {
                Console.Write(coupon + " ");
            }
            Console.WriteLine("\n Random numbers needed to generate {0} distinct coupon are:{1}" ,num,generated);
            Console.ReadLine();
        }
    }
}
