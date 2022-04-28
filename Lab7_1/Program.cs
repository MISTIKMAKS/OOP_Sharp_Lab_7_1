using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Matrix a = Matrix.Create();
            a.Fill();
            Console.WriteLine("");
            a.Display();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Matrix b = Matrix.Create();
            b.Fill();
            Console.WriteLine("");
            b.Display();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("a + b: ");
            var c = a + b;
            Console.WriteLine("");
            c.Display();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("\na == b: {0}\n", a == b);
            Console.WriteLine("\na != b: {0}\n", a != b);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Matrix Norm From Matrix a: {0}", a.Norm());
            Console.ReadKey();
        }
    }
}
