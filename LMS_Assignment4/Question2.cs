using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Assignment4
{
    public class Question2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range of number N\n");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Fibonacci series for range of {n} is ");

            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
