using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentario in-line(em linha)
            /*
             Comentario em in-block(em bloco)
            */

            //declaração da variavel operação. Ela será do tipo inteiro
            int operacao;

            //declaração das variaveis n1 e n2. Elas serão do tipo double
            double n1, n2;

            /*
            Para Limpar a tela de comando a cada execução utilizaremos Comando Console.Clear();
            obs.: Clear ->Limpar
             */
             Console.Clear();
             Console.WriteLine("Escolha umas das Operacoes abaixo");
             /* 
             Para a exibição das opções de operção, vamos usar o comando Console.WriteLine e, 
             Nele usaremos um comando quebra de linha \n(contra-barra n)(new line) assim, as opções ficarao uma abaixo da outra.
             */
             Console.WriteLine("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
             operacao = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite um numero:");
             n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite outro numero:");
             n2 = double.Parse(Console.ReadLine());
             
        }
    }
}
