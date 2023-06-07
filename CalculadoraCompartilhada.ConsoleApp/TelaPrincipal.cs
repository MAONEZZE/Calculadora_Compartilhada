using CalculadoraCompartilhada.ConsoleApp.ModuloDivisao;
using CalculadoraCompartilhada.ConsoleApp.ModuloMultiplicacao;
using CalculadoraCompartilhada.ConsoleApp.ModuloSoma;
using CalculadoraCompartilhada.ConsoleApp.ModuloSubtracao;
using System.Collections;


namespace CalculadoraCompartilhada.ConsoleApp
{
    public class TelaPrincipal
    {
        private ArrayList historico;
        decimal num1, num2;
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
            Console.Write("Opção Desejada: ");
            op = Console.ReadLine();

            if (op != "1" && op != "2" && op != "3" && op != "4" && op != "s" && op != "S")
            {
                Console.WriteLine("Digite uma opção válida");

            }
            else
            {
                Console.Clear();
                ColetorNumeros();
                Console.Clear();
                SelecaoModulos(op);
                Console.Clear();
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

        public void ColetorNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());
        }

        public void SelecaoModulos(string op)
        {
            switch (op)
            {
                case "1":
                    Soma soma = new Soma();
                    Console.WriteLine(soma.somar(num1, num2));
                    break;

                case "2":
                    Subtracao sub = new Subtracao();
                    Console.WriteLine(sub.subtrair(num1, num2));
                    break;
                case "3":
                    Divisao div = new Divisao();
                    Console.WriteLine(div.Dividir(num1, num2));
                    break;
                case "4":
                    Multiplicacao mult = new Multiplicacao();
                    Console.WriteLine(mult.multiplicar(num1, num2));
                    break;
            }
            Console.ReadLine();
        }
    }
}


