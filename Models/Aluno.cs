using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_de_cs3.Models
{
    public class Aluno : Pessoa //Herança sendo aplicado
    {
        public Aluno() {
            
        }
        public Aluno(string nome) : base(nome) {

        }
        public int Nota { get; set; }
        public override void Apresentar() // Polimorfismo sendo aplicado
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade}, e sou um aluno nota {Nota}");
        }
    }
}