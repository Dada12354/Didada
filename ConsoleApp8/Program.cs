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
            double z, h, s;
            Console.WriteLine("Введите a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a=" + a);
            Console.WriteLine("Введите r=");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r=" + r);
            h = 2 * a;
            s = Math.PI * Math.Pow(r, 2);
            z = Math.PI * r * h + s;
            z = Math.Round(z, 4);
            Console.WriteLine("z=" + z);
            Console.ReadKey();
        }
    }
}
