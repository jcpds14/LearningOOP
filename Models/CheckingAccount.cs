using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningOOP.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int accountNumber, decimal initialBalance)
        {
            balance = initialBalance;
            accountNumber = AccountNumber;
        }
        private decimal balance;// Encapsulamento. Encapsulation
        public int AccountNumber { get; set; }

        public void WithDrawn(decimal value)
        {
            if (value <= balance)
            {
                balance -= value;
                Console.WriteLine($"Saque de {value.ToString("C2")} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado acima do saldo disponível.");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine("Seu saldo disponível é: " + balance.ToString("C2"));
        }
    }
}