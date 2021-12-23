using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAB2
{
    class Code
    {
        private static object х;

        static void Main(string[] args)
        {
            Console.WriteLine(funks.funks.Power(5, 2));
            Console.WriteLine(Math.Pow(5, 2));


            double a = Math.Log(1024, 2);
            double b = Math.Log(1024) / Math.Log(2);


            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine(Math.Log(100));
            Console.WriteLine(funks.funks.Power(5, 2));
            Console.WriteLine("\n\n");
            Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            if (x <= 0) 
            {
               result = ((funks.funks.Power((funks.funks.Power(funks.funks.sec(х) / funks.funks.соt(x)) ^ 2) ^ 2) * funks.funks.cosec(х) + funks.funks.Cos(х)) + funks.funks.Tan(х)) / funks.funks.cosec(х) / funks.funks.cosec(х);
            }
            
            else
           
            {
                result = ((((funks.funks.Power(funks.funks.Log_3(х) ^ 2) - funks.funks.Log_2(х)) / funks.funks.log_10(х))^ 2) ^2);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
