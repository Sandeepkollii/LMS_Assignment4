using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Assignment4
{
    public class Question1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Cel Temp:\n");
            double celsius = Convert.ToDouble(Console.ReadLine());

         
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Fahrenheit Temperature is : {fahrenheit}");
        }
    }
}
