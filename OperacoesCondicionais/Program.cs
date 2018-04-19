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

             if(operacao==1)
             {
                 Console.WriteLine("O resultado da soma é:" +(n1+n2));
             }
             else if(operacao==2){
                 Console.WriteLine("O resultado da subtracao é:" +(n1-n2));
             }
             else if(operacao==3){
                 Console.WriteLine("O resultado da multiplicação é:"+(n1*n2));
             }
             else if(operacao==4){
                 Console.WriteLine("O resultado da divisao é:"+(n1/n2));
             }
             else{
                 Console.WriteLine("Operação Invalida!");
             }
             
        }
    }
}
