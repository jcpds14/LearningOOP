using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ToIntroduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, and I have {Age} years old!");
        }
    }
}