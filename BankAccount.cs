using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private string owner;
        private decimal balance;
        public string Owner
        {
            get => owner;
            set => owner = value;
        }

        public decimal Balance
        {
            get => balance;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не может быть отрицательным");
                balance = value;
            }
        }
        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            Balance += amount;
            Console.WriteLine($"{Owner}, баланс: {Balance}.");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств!");
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"{Owner}, баланс: {Balance}.");
        }
    }
}
