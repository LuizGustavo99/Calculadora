using System;

namespace Calculadora_3._0
{
    class FormulaHeron
    {
        public static double Heron(double A, double B, double C)
        {

            double p = (A + B + C) / 2.0;

            double Resultado = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return Resultado;

        }
    }
}
