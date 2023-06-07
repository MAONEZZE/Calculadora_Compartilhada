using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp.ModuloDivisao
{
    public class Divisao
    {
        public string Dividir(int primeiroValor, int segundoValor)
        {
            int resultado = primeiroValor / segundoValor;

            return $"O valor de divisão de {primeiroValor} por {primeiroValor} é : {resultado}";
        }
    }
}
