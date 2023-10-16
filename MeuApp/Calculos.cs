using System;
using static System.Console;

namespace Equacoes
{
    public class Heren
    {
        public double A, B, C;
        public double SomaHeren()
        {
            double p = (A + B + C) / 2;
            Console.WriteLine("Calculo achar o p: ");
            Console.WriteLine("p = (A+B+C) / 2");
            Console.WriteLine("p = ({0} + {1} + {2}) / 2", A, B, C);
            Console.WriteLine("p = {0} / 2", A + B + C);
            Console.WriteLine("p = {0}", p);
            Console.WriteLine(" ");
            Console.WriteLine("Calculo da formula Heren: ");
            Console.WriteLine("v {0} * ({1} - {2}) * ({3} - {4}) * ({5} - {6})", p, p, A, p, B, p, C);
            Console.WriteLine("v {0} * {1} * {2} * {3}", p, p - A, p - B, p - C);
            Console.WriteLine("v {0} * {1}", p * (p - A), (p - B) * (p - C));
            Console.WriteLine("v {0}", p * (p - A) * (p - B) * (p - C));
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
    public class Bhaskara
    {
        public double A, B, C;
        public string SomaBhaskara()
        {
            double Delta = B * B - 4 * A * C;
            Console.WriteLine("d = {0} * {1} - 4 * {2} * {3}", B, B, A, C);
            Console.WriteLine("d = {0} - 4 * {1}", B * B, A * C);
            if (-4 * (A * C) < 0)
                Console.WriteLine("d = {0}{1}", B * B, -4 * (A * C));
            else
            {
                Console.WriteLine("d = {0} + {1}", B * B, -4 * (A * C));
            }
            Console.WriteLine("d = {0}", B * B - 4 * A * C);
            Console.WriteLine(" ");
            if(Delta < 0) return string.Format("Como o valor de delta é negativo, logo não existem raizes reais.");
            if (Delta == 0) return string.Format("Como é {0} este é o resultado não há como calcular", Delta);
            Console.WriteLine("Calculo de Bhaskara: ");
            Console.WriteLine("x = -b +- raiz de delta / 2 * a");
            Console.WriteLine("x = {0} + v{1} / 2 * A", -B, Delta, A);
            Console.WriteLine(" ");

            Console.WriteLine("x1 = {0} + {1} / 2 * {2}", -B, Math.Sqrt(Delta), A);
            Console.WriteLine("x1 = {0} / {1}", -B + Math.Sqrt(Delta), 2 * A);
            Console.WriteLine("x1 = {0}", (-B + Math.Sqrt(Delta)) / (2 * A));
            Console.WriteLine(" ");
            Console.WriteLine("x2 = {0} - {1} / 2 * {2}", -B, Math.Sqrt(Delta), A);
            Console.WriteLine("x2 = {0} / {1}", -B - Math.Sqrt(Delta), 2 * A);
            Console.WriteLine("x2 = {0}", (-B - Math.Sqrt(Delta)) / (2 * A));
            double x1, x2;
            x1 = (-B + Math.Sqrt(Delta)) / (2 * A);
            x2 = (-B - Math.Sqrt(Delta)) / (2 * A);

            string result = string.Format($"As raizes da equação {A}*2 {B}x {C} = 0 são {x1} e {x2}");
            return result;
        }
    }
}

