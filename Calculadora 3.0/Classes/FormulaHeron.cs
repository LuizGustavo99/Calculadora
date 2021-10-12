using System;

namespace Calculadora_3._0
{
    class FormulaHeron
    {
        public double A;
        public double B;
        public double C;

        public double Resultado;

        public double Heron(double A, double B, double C)
        {

            double p = (A + B + C) / 2.0;

            Resultado = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return Resultado;

        }
    }
}
