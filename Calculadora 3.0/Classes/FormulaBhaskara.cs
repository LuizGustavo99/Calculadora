using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_3._0
{
    class FormulaBhaskara
    {
        public static float Bhaskara(float a, float b, float c)
        {
            float delta;
            float resultado;

            delta = (float)(Math.Pow(b, 2.0f) - (4.0 * a * c));

            resultado = (float)((-b + Math.Sqrt(delta)) / (2.0 * a));

            return resultado;
        }
    }
}
