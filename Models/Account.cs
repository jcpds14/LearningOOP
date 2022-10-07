using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public abstract class Account //Abstract não pode ser instanciada diretamente, serve apenas como modelo para ser herdado. Só serve para ser herdado
    {
        protected decimal balance;//permite ser alterado pela própria classe e pelas classes filhas
        public abstract void Credit(decimal value);//Não tem implementação por ser abstrato

        public void ShowBalance()
        {
            Console.WriteLine($"O seu saldo é: {balance.ToString("C2")}");
        }
    }
}