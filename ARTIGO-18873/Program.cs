using System;
using System.Globalization;
namespace ARTIGO_18873
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime sd = DateTime.Now;
            string br = sd.ToString(new CultureInfo("pt-br"));

            Console.WriteLine($"\t\t Data: {br} \n-----------------------------------------------------------------");
            Console.WriteLine("- Boas Vindas ao Artigo 18873, da Plataforma DEVMEDIA OOP com CSharp -");
            Console.WriteLine("-----------------------------------------------------------------");

            Menu.MenuItens();
        }
    }
}
