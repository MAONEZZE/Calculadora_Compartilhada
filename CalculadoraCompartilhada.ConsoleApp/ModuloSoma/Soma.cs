using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompartilhada.ConsoleApp.ModuloSoma
{
    public class Soma
    {

       public string somar(decimal primeiroValor, decimal segundoValor)
       {
            decimal resultado = primeiroValor + segundoValor;

            return $"O valor de soma entre {primeiroValor} mais {primeiroValor} é : {resultado}";
       }
    }
}
