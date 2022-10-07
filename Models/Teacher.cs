using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class Teacher : Person // Conceito de Herança. Inheritance Concept
    {
        public decimal Wage { get; set; }

        public override void ToIntroduce()
        {
            Console.WriteLine($"Olá meu nome é {Name}, sou professor e tenho {Age} anos com o salário de {Wage}");
        }
    }
}