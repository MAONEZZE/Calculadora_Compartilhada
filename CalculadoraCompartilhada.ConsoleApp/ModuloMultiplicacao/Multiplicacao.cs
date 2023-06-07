using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp.ModuloMultiplicacao
{
    public class Multiplicacao
    {
        public string multiplicar(decimal primeiroValor, decimal segundoValor)
        {
            decimal resultado = primeiroValor * segundoValor;

            return $"O valor de multiplicação entre {primeiroValor} e {primeiroValor} é : {resultado}";
        }
    }
}
