using System;
using static System.Console;
using System.Globalization;

namespace Equacoes
{
    public class Heren
    {
        public double A, B, C;
        public double SomaHeren()
        {
            double p = (A + B + C) / 2;
            WriteLine("Calculo achar o p: ");
            WriteLine("p = (A+B+C) / 2");
            WriteLine("p = ({0} + {1} + {2}) / 2", A, B, C);
            WriteLine("p = {0} / 2", A + B + C);
            WriteLine("p = {0}", p);
            WriteLine(" ");
            WriteLine("Calculo da formula Heren: ");
            WriteLine("v {0} * ({1} - {2}) * ({3} - {4}) * ({5} - {6})", p, p, A, p, B, p, C);
            WriteLine("v {0} * {1} * {2} * {3}", p, p - A, p - B, p - C);
            WriteLine("v {0} * {1}", p * (p - A), (p - B) * (p - C));
            WriteLine("v {0}", p * (p - A) * (p - B) * (p - C));
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
    public class Bhaskara
    {
        public double A, B, C;
        public string SomaBhaskara()
        {
            if(A == 0)
            {
                // Equação Linear
                if (B != 0)
                {
                    double x = -C / B;
                    return string.Format($"Solução da equação linear: x = {x}");
                }
                else
                {
                    return string.Format("Equação indeterminada ou impossível.");
                }
            }

            double Delta = B * B - 4 * A * C;
            WriteLine("d = {0} * {1} - 4 * {2} * {3}", B, B, A, C);
            WriteLine("d = {0} - 4 * {1}", B * B, A * C);
            if (-4 * (A * C) < 0)
                WriteLine("d = {0}{1}", B * B, -4 * (A * C));
            else
            {
                WriteLine("d = {0} + {1}", B * B, -4 * (A * C));
            }
            WriteLine("d = {0}", B * B - 4 * A * C);
            WriteLine();
            if(Delta < 0) return string.Format("Como o valor de delta é negativo, logo não existem raizes reais.");
            if (Delta == 0) return string.Format("Como é {0} este é o resultado não há como calcular", Delta);
            WriteLine("Calculo de Bhaskara: ");
            WriteLine("x = -b +- raiz de delta / 2 * a");
            WriteLine("x = {0} + v{1} / 2 * A", -B, Delta, A);
            WriteLine();

            WriteLine("x1 = {0} + {1} / 2 * {2}", -B, Math.Sqrt(Delta), A);
            WriteLine("x1 = {0} / {1}", -B + Math.Sqrt(Delta), 2 * A);
            WriteLine("x1 = {0}", (-B + Math.Sqrt(Delta)) / (2 * A));
            WriteLine();
            WriteLine("x2 = {0} - {1} / 2 * {2}", -B, Math.Sqrt(Delta), A);
            WriteLine("x2 = {0} / {1}", -B - Math.Sqrt(Delta), 2 * A);
            WriteLine("x2 = {0}", (-B - Math.Sqrt(Delta)) / (2 * A));
            string x1 = Fracao(-B, Math.Sqrt(Delta), (2 * A));
            string x2 = Fracao(-B, -Math.Sqrt(Delta), (2 * A));

            return string.Format($"As raízes da equação {A}x^2 + {B}x + {C} = 0 são x1 = {x1} e x2 = {x2}");
        }
        static string Fracao(double numerador1, double numerador2, double denominador)
        {
            double R = (numerador1 + numerador2) / denominador;

            if ((numerador1 + numerador2) % denominador == 0)
            {
                return R.ToString();
            }
            else
            {
                int ValorMDC = MDC((int)(numerador1 + numerador2), (int)denominador);
                return $"{(int)(numerador1 + numerador2) / ValorMDC}/{(int)denominador / ValorMDC}";
            }
        }

        private static int MDC(int a, int b)
        {
            if (b == 0)
                return a;
            return MDC(b, a % b);
        }



    }


}



