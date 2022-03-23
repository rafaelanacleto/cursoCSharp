using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1 = 0;
            int qtdPeca1 = 0;
            double vlrPeca1 = 0;
            int codPeca2 = 0;
            int qtdPeca2 = 0;
            double vlrPeca2 = 0;
            string specifier;
            CultureInfo culture;

            specifier = "F";
            culture = CultureInfo.CreateSpecificCulture("pt-BR");

            Console.WriteLine("Digite o código da peça 1: \n");
            codPeca1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Número da peça 1: \n");
            qtdPeca1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Valor da peça 1: \n");
            vlrPeca1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o código da peça 2: \n");
            codPeca2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Número da peça 2: \n");
            qtdPeca2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Valor da peça 2: \n");
            vlrPeca2 = Convert.ToDouble(Console.ReadLine());

            double total = (qtdPeca1 * vlrPeca1) + (qtdPeca2 * vlrPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ "+ total.ToString(specifier, culture) + " \n");


        }
    }
}
