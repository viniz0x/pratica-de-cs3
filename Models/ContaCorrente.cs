using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs3.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoIncial) {
            NumeroConta = numeroConta;
            saldo = saldoIncial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor) {
            if(saldo >= valor) {
                saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso. Saldo atual: {saldo}");
            } else {
                Console.WriteLine($"Saldo insuficiente! Saldo atual: {saldo}");
            }
        }
    }
}