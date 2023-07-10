using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classes_externos
{
    class Endereco
    {
        protected string MeuEndereco()
        {
            return "MG - Patrocínio" + NumeroCasa();
        }
        private string NumeroCasa()
        {
            return "784A FR";
        }
    }
}
