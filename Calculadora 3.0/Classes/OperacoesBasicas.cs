using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_3._0
{
    class OperacoesBasicas
    {

        public static float Soma(float num1, float num2)
        {
            float resultado = num1 + num2;

            return resultado;
        }

        public static float Subtracao(float a, float b)
        {
            float resultado = a - b;

            return resultado;
        }

        public static float Multiplicacao(float a, float b)
        {
            float resultado = a * b;

            return resultado;
        }

        public static float Divisao(float a, float b)
        {
            float resultado = a / b;

            return resultado;
        }

    }
}
