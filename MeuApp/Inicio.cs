using System;
using System.Diagnostics;
using static System.Console;

namespace Main
{
    class Inicio
    {
        static void Main(string[] args)
        {
            string Stop = "S";
            while (Stop == "S")
            {
                Clear();
                WriteLine("----------------------");
                WriteLine("-  CALCULADORA AUTO  -");
                WriteLine("----------------------");
                WriteLine("[1] Formula de Heren");
                WriteLine("[2] Formula de Bhaskara");

                sbyte Selecionar = sbyte.Parse(ReadLine());

                switch (Selecionar)
                {
                    case 1:
                    {
                        Clear();
                        WriteLine("--Calculando Heren--");
                        Equacoes.Heren X = new Equacoes.Heren();
                        WriteLine("Digite o valor de A: ");
                        X.A = double.Parse(ReadLine());
                        WriteLine("Digite o valor de B: ");
                        X.B = double.Parse(ReadLine());
                        WriteLine("Digite o valor de C: ");
                        X.C = double.Parse(ReadLine());

                        double AreaX = X.SomaHeren();
                        WriteLine("Valor da area: {0:F2}", AreaX);

                        break;
                    }
                    case 2:
                    {
                        Clear();
                        WriteLine("--Calculando Bhaskara--");
                        Equacoes.Bhaskara X = new Equacoes.Bhaskara();
                        WriteLine("Digite o valor de A: ");
                        X.A = double.Parse(ReadLine());
                        WriteLine("Digite o valor de B: ");
                        X.B = double.Parse(ReadLine());
                        WriteLine("Digite o valor de C: ");
                        X.C = double.Parse(ReadLine());

                        string Result = X.SomaBhaskara();
                        WriteLine(Result);
                        break;
                    }
                    
                    default:
                        break;
                }
                WriteLine();
                WriteLine("Voce deseja continuar? [S/N]");
                Stop = ReadLine();

            }
        }
    }

}