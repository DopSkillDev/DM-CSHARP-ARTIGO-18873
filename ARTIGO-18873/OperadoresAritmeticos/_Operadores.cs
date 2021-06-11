namespace ARTIGO_18873.OperadoresAritmeticos
{
    public class _Operadores
    {
        public static void ExibTdOperadores()
        {
            System.Console.WriteLine(
                "Operação de soma: " +
                Adicao.ExibAdicao(5) +
                "\nOperação de subtração: " +
                Subtracao.ExibSubtr(10) +
                "\nOperação de multiplicação: " +
                Multiplicacao.ExibMultiplic(15) +
                "\nOperação de divisão: " +
                Divisao.ExibDivisao(20) +
                "\nOperação de módulo (resto de divisão): " +
                Modulo.ExibModulo(25)
            );
        }
    }
}