using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class Teacher : Person // Conceito de Herança. Inheritance Concept. Se colocar sealed antes da class, nenhuma outra class poderá herdar desta class
    {
        public Teacher()//Passa o construtor sem valor para ser instanciado
        { }
        public Teacher(string name) : base(name)
        { }
        public decimal Wage { get; set; }

        public override void ToIntroduce()// Override serve para realizar o Polimorfismo
        {
            Console.WriteLine($"Olá meu nome é {Name}, sou professor e tenho {Age} anos com o salário de {Wage}");
        }
    }
}