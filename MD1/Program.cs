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
            Izvade(rezultats);
            Console.Read();
        }

        static int Aprekins()
        {
            Console.Write("Ievadiet pirmo skaitli: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadiet otro skaitli: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }

        static void Izvade(int vertiba)
        {
            Console.WriteLine("Summa: " + vertiba);
        }

    }
}
