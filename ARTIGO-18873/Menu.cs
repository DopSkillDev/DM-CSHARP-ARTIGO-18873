using System;
using ARTIGO_18873.OperadorDeAtribuicao;
using ARTIGO_18873.OrdemDeOperacoesMatematicas;
using ARTIGO_18873.OperadoresAritmeticos;

namespace ARTIGO_18873
{
    public class Menu
    {
        public static void MenuItens()
        {
            Console.WriteLine("- 1 - Operador de Atribuição -");
            Console.WriteLine("- 2 - Operadores Aritméticos  -");
            Console.WriteLine("- 3 - Ordem de Operações matemáticas -");
            Console.WriteLine("- 4 - Operadores Aritméticos de Atribuição Reduzida -");
            Console.WriteLine("- 5 - Operadores incrementais e decrementais -");
            Console.WriteLine("- 6 - Operadores Relacionais  -");
            Console.WriteLine("- 7 - Operadores Lógicos  -");
            Console.WriteLine("- 8 - Operadores Ternários -");
            Console.WriteLine("- 0 - Fechar Artigo -");
            Console.WriteLine("----------------------------------------------------------------------");

            MenuOpcao();
        }

        static void MenuOpcao()
        {
            Console.Write($"Digite a opção desejada : ");
            var opcao = Console.ReadLine();
            System.Console.WriteLine($"*** Opção digitada: {opcao} ***\n");

            switch (opcao)
            {
                case "1":
                    OpAtribuicao.ExibOpAtribuicao();
                    break;
                case "2":
                    _Operadores.ExibTdOperadores();
                    break;
                case "3":
                    OrdOpMat.ExibOrdOpMat();
                    break;
                case "4":
                    break;
                case "0":
                    System.Environment.Exit(0);
                    break;
            }
                Console.WriteLine("\n----------------------------------------------------------------------");

            MenuItens();
            Console.ReadKey();
        }
    }
}