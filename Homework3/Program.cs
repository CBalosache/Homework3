using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine(productAndSum(4,5,6,out sum));
            Console.WriteLine(sum);
            Console.Read();
        }
        public static double productAndSum(double value1, double value2, double value3, out double sumIn)
        {
            sumIn = value1 + value2 + value3;
            return value1 * value2 * value3;
        }
    }
}
