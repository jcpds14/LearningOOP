using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class CheckingAccountTest : Account
    {
        public override void Credit(decimal value)
        {
            balance += value;
        }

    }
}