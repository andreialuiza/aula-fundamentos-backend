using System;

namespace Calculator // Note: nome do projeto criado.
{
    internal class Program  //internal: tipos ou membros internal podem ser acessados no código que faz parte da mesma compilação.
    {
        static void Main(string[] args)
        {

            Menu ();
              
        }
        static void Menu ()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("______________________________");
            Console.WriteLine("Selecione uma das opções:");

            short resultado = short.Parse(Console.ReadLine()); 

            switch(resultado){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;                


            }


        }
        static void Soma ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Divisao ()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
            
        }
        static void Multiplicacao () 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Write("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}

            // Obs:
            // a função console fica disponível a partir do momento que o using System é importado.
            // a função Write exibe algo na tela e a função WriteLine escreve algo e pula uma linha.
            // a função Read é ler um item e ReadLine é ler uma linha (ele sempre retorna uma string).
            // o Parse é utilizado para conversão da string para algum outro tipo neste caso o float (número real).
            // o $ inserido dentro da função é para que haja a interpolação da string, ou seja, pela a variável em formato string e exibe o valor numeral.
            // void não retorna nada.
            // a função ReadKey é para não fechar o programa.
            // não é possível realizar a conversão de sting para float diretamente pelo Console.ReadLine. No exemplo citado acima foi usado a função Parse para realizar tal conversão.
            // short é o valor mais curto que se pode ter.
            // switch é uma estrutura de repetição.
            // default é para quando algo digitado não estiver dentro das opções solicitadas retorne a Main principal.
            // Para sair do programa é necessário chamar a função System.Environment.Exit e o Existe existe um parâmento e colocamos o 0 para dizer que a saída foi executada com sucesso.
