using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAB2.funks
{
    public class funks
    {
        
        public static double Factorial(int num)
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }

        
        public static double Power(double num, int pow)
        {
            double result = 1;
            if (pow == 0)
            {
                return 1;
            }
            for (int i = 1; i <= pow; i++) result = result * num;
            return result;
        }

        
        public static double Sin(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n + 1) / Factorial((int)(2 * n + 1));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Sin(x, n + 1, precision);
        }

        internal static int Tan(object х)
        {
            throw new NotImplementedException();
        }

        internal static int Cos(object х)
        {
            throw new NotImplementedException();
        }

        internal static int cosec(object х)
        {
            throw new NotImplementedException();
        }

        internal static int Log_3(object х)
        {
            throw new NotImplementedException();
        }

        internal static int log_10(object х)
        {
            throw new NotImplementedException();
        }

        internal static int Log_2(object х)
        {
            throw new NotImplementedException();
        }

        internal static int Power(double v)
        {
            throw new NotImplementedException();
        }

        internal static double sec(object х)
        {
            throw new NotImplementedException();
        }

        internal static double соt(double x)
        {
            throw new NotImplementedException();
        }

        public static double Cos(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((int)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Cos(x, n + 1, precision);
        }


        public static double Abs(double num)
        {
            if (num >= 0)
            {
                return num;
            }

            return -num;
        }


        public static double Tan(double x)
        {
            return Sin(x) / Cos(x);
        }

        public static double Ctan(double x)
        {
            return Cos(x) / Sin(x);
        }

 
        public static double cosec(double x)
        {

            return 1 / Sin(x);
        }

 
        public static double sec(double x)
        {

            return 1 / Cos(x);
        }

        public static double Ln(double X)
        {
            double a = 1000;
            double b = 0;
            double y = 1 + X;
            for (int e = 1; e < a; e++)
            {
                b += Power(-1, e + 1) + Power(X - 1, e) / Factorial(e);
            }
            return b;
        }

        public static double Log(double A, double B)
        {
            return Ln(B) / Ln(A);
        }

        public static double Log_2(double A, double B)
        {
            return Ln(B) / Ln(A);
        }

        public static double Log_3(double A, double B)
        {
            return Ln(B) / Ln(A);
        }

        public static double Log_5(double A, double B)
        {
            return Ln(B) / Ln(A);
        }

        public static double Log_10(double A, double B)
        {
            return Ln(B) / Ln(A);
        }
    }
}
