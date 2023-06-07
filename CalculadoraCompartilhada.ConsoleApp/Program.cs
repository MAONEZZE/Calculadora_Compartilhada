using System.Collections;

namespace CalculadoraCompartilhada.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(new ArrayList());
            string op;

            do {

                op = telaPrincipal.Menu();

            }while (op != "S" && op != "s") ;
            
        }
    }
}