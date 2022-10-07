using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class Student : Person // Conceito de Herança. Inheritance Concept
    {
        public double Grade { get; set; }

        public override void ToIntroduce()
        {
            Console.WriteLine($"Olá meu nome é {Name}, sou aluno e tenho {Age} anos. Sou um aluno nota {Grade}");
        }
    }
}