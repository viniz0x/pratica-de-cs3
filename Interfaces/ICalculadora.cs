using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs3.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int number1, int number2);
        int Subtrair(int number1, int number2);
        int Multiplicar(int number1, int number2);
        int Dividir(int number1, int number2);

    }
}