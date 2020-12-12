using ConsoleApp.Conta.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp.Conta.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string name, double balance, double withDrawLimit)
        {
            Number = number;
            Name = name;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
