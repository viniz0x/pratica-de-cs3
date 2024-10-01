using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs3.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome){}
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Sou professor e tenho {Idade} de idade e recebo {Salario}");
        }
    }
}