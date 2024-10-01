using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pratica_de_cs3.Interfaces;

namespace pratica_de_cs3.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Multiplicar(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Somar(int number1, int number2) {
            return number1 + number2;
        }

        public int Somar(int number1, int number2, int number3) {
            return number1 + number2 + number3;
        }

        public int Subtrair(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}