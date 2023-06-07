using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp.ModuloSubtracao
{
    public class Subtracao
    {
        public string subtrair(int primeiroValor, int segundoValor)
        {
            int resultado = primeiroValor - segundoValor;

            return $"O valor da subtração entre {primeiroValor} menos {primeiroValor} é : {resultado}";
        }
    }
}
