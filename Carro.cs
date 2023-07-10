using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classes_externos
{
    class Carro
    {
        private string nome;
        private int ano;
        private string cor;

        public string Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
