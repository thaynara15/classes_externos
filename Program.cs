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
            //Console.WriteLine(p.Nome());
           
            Carro c = new Carro(); //Criamos uma nova instrancia da classe carro
            c.Cor = "Azul"; //Definimos os valores
            c.Nome = "Gol"; //Definimos os valores
            c.Ano = 2018; //Definimos os valores

            p.DadosDoCarro(c);

            Console.ReadKey();
        }
    }
}
