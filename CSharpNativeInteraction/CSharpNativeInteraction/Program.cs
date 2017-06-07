using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNativeInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CLRBridge.Calc();
            double a = 1.25;
            double b = 7.38;
            double c = calc.Sum(a, b);
            Console.WriteLine($"{a} + {b} = {c}");
        }
    }
}
