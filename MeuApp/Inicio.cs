using System;

namespace Main
{
    class Inicio
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("----------------------");
            Console.WriteLine("-  CALCULADORA AUTO  -");
            Console.WriteLine("----------------------");
            Console.WriteLine("[1] Formula de Heren");
            Console.WriteLine("[2] Formula de Bhaskara");

            sbyte Selecionar = sbyte.Parse(Console.ReadLine());

            switch (Selecionar)
            {
                case 1:
                {
                    Equacoes.Heren X = new Equacoes.Heren();
                    Console.WriteLine("Digite o valor de A: ");
                    X.A = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B: ");
                    X.B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de C: ");
                    X.C = double.Parse(Console.ReadLine());

                    double AreaX = X.SomaHeren();
                    Console.WriteLine("Valor da area: {0:F2}", AreaX);

                    break;
                }
                case 2:
                {
                    Equacoes.Bhaskara X = new Equacoes.Bhaskara();
                    Console.WriteLine("Digite o valor de A: ");
                    X.A = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B: ");
                    X.B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de C: ");
                    X.C = double.Parse(Console.ReadLine());

                    string Result = X.SomaBhaskara();
                    Console.WriteLine(Result);
                    break;
                }
                default:
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("[1] Fazer outro calculo");
            Console.WriteLine("[2] Sair");
            Selecionar = sbyte.Parse(Console.ReadLine());
            switch (Selecionar)
            {
                case 1:
                {
                    Console.Clear();
                    goto inicio;
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Voce saiu do programa.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Voce saiu do programa.");
                    break;
                }
            }
        }
    }

}