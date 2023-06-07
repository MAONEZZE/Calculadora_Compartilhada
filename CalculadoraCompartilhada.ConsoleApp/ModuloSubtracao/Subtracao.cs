using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp.ModuloSubtracao
{
    public class Subtracao
    {
        public string subtrair(decimal primeiroValor, decimal segundoValor)
        {
            decimal resultado = primeiroValor - segundoValor;

            return $"O valor da subtração entre {primeiroValor} menos {primeiroValor} é : {resultado}";
        }
    }
}
