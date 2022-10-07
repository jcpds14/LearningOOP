using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class Student : Person // Conceito de Herança. Inheritance Concept
    {
        public Student()//Passa o construtor sem valor para ser instanciado
        { }
        public Student(string name) : base(name)
        { }
        public double Grade { get; set; }

        public override void ToIntroduce()// Override serve para realizar o polimorfismo
        {
            Console.WriteLine($"Olá meu nome é {Name}, sou aluno e tenho {Age} anos. Sou um aluno nota {Grade}");
        }
    }
}