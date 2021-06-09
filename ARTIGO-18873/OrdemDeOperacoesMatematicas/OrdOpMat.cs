namespace ARTIGO_18873.OrdemDeOperacoesMatematicas
{
    public class OrdOpMat
    {
        public static void ExibOrdOpMat()
        {
            int a = 5, b = 10, c = 15;

            System.Console.WriteLine("");
            System.Console.Write($"A operação de multiplicação será executada primeiro: [{a + b * c}]");

            System.Console.WriteLine("");
            System.Console.Write($"A operação de soma será executada primeiro porque está entre parênteses: [{(a + b) * c}]");
        }
    }
}