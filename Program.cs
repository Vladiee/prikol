using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("выберите действие:");
            string c = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());

            if (c == "+")
            {
                Console.WriteLine(pluse(a,b));
            }
            else if (c == "-")
            {               
                Console.WriteLine(minus(a,b));
            }
            else if (c == "*")
            {
                Console.WriteLine(umno(a, b));
            }
            else if (c == "/") 
            {
                Console.WriteLine(del(a, b));
            }
            Console.ReadLine();
            
        }

        public static double pluse(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public static double minus(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public static double umno(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public static double del(double a, double b)
        {
            double result = a / b;
            return result;
        }
    }
}

