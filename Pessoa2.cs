using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace classes_externos
{
    class Pessoa : Endereco
    {
        public string Nome()
        {
            return string.Format("Meu nome é Thaynara, e meu salário é: {0} e eu moro em: {1}", Salario(2500), MeuEndereco());
        }

        private double Salario(double s)
        {
            return s * 1.5;
        }
            public void DadosDoCarro(Carro carro)
            {
                Console.WriteLine(carro.Nome);
                Console.WriteLine(carro.Cor);
                Console.WriteLine(carro.Ano);
            }
        }
    }

