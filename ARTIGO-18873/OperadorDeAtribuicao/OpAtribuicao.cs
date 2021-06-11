using System;

namespace ARTIGO_18873.OperadorDeAtribuicao
{
    public class OpAtribuicao
    {
        public static void ExibOpAtribuicao()
        {
            System.Console.WriteLine("");
            System.Console.Write("Digite um valor númerico : ");
            var num = System.Console.ReadLine();

            System.Console.WriteLine("");
            bool vNum = true;

            System.Console.WriteLine("*** Exibição ambos em tela, atribuindo valor ao booleano ***");
            System.Console.Write($"variável 'num' recebeu o número: [{num}] \n");
            System.Console.WriteLine($"Declaro variável 'num' como boolean: [{vNum}] \n");
        }
    }
}