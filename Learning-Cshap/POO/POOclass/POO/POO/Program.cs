using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangule rec1 = new Rectangule();

            Console.WriteLine(rec1.calculateArea());
            Console.WriteLine(rec1.calculatePerimeter());

            Rectangule rec2 = new Rectangule(5, 6);

            Console.WriteLine(rec2.calculateArea());
            Console.WriteLine(rec2.calculatePerimeter());

            Rectangule rec3 = new Rectangule(4, 2, "brown");

            Console.WriteLine(rec3.calculateArea());
            Console.WriteLine(rec3.calculatePerimeter());
        }
    }
}
