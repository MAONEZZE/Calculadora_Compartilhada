using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp.ModuloMultiplicacao
{
    public class Multiplicacao
    {
        public string multiplicar(int primeiroValor, int segundoValor)
        {
            decimal resultado = primeiroValor * segundoValor;

            return $"O valor de multiplicação entre {primeiroValor} e {primeiroValor} é : {resultado}";
        }
    }
}
