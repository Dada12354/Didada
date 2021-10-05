using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double z, p;
            Console.WriteLine("Введите a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a=" + a);
            Console.WriteLine("Введите b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=" + b);
            Console.WriteLine("Введите h=");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("h=" + h);
            Console.ReadKey();
            p = 3 * (Math.Pow(a, 2) + Math.Pow(b, 2));
            z = ((Math.PI * h) / 6) * (p + Math.Pow(h, 2));
            z = Math.Round(z, 3);
            Console.WriteLine("z=" + z);
            Console.ReadKey();

        }
    }
}
