using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs3.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}