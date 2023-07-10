using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classes_externos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Console.WriteLine(p.Nome());
           

            Console.ReadKey();
        }
    }
}
