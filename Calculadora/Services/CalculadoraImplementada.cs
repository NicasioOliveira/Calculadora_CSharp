using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementada
    {
        public int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        public int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
        
    }
}