using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs3.Models
{
    public abstract class Conta //Não é possivel implementar diretamentar
    {
        protected decimal saldo; //Protegido com anterações externar com ecessão das classes filhas

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo() {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}