using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rezultats = Aprekins();
            Console.WriteLine("Summa: " + rezultats);
            Izvade();
            Console.Read();
        }

        static int Aprekins()
        {
            int a = 2;
            int b = 10;
            return a + b;
        }

        static void Izvade()
        {
            int a = 2;
            int b = 10;
            int vertiba = a + b;
            Console.WriteLine("Summa: " + vertiba);
        }

    }
}
