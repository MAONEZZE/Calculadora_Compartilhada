using System.Collections;


namespace CalculadoraCompartilhada.ConsoleApp
{
    public class TelaPrincipal
    {
        private ArrayList historico;
        public TelaPrincipal(ArrayList historico)
        {
            this.historico = historico;
        }

        public string Menu()
        {
            string op;

            Console.WriteLine("Digite o número \nda \nOpção Desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("S - Sair");
            Console.Write("Opção Desejada:");
            op = Console.ReadLine();

            if (op != "1" && op != "2" && op != "3" && op != "4" && op != "s" && op != "S")
            {
                Console.WriteLine("Digite uma opção válida");

            }
            else
            {
                SelecaoModulos(op);
            }

            if (op == "s" || op == "S")
            {
                return op;
            }
            else
            {
                return null;
            }
        }
        public void SelecaoModulos(string op)
        {
            switch (op)
            {
                case "1":
                    Console.WriteLine("um");
                    break;
                case "2":
                    Console.WriteLine("dois");
                    break;
                case "3":
                    Console.WriteLine("tres");
                    break;
                case "4":
                    Console.WriteLine("quatro");
                    break;
            }
        }
    }
}


