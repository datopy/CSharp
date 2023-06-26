using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal partial class BankAccount
    {
        private readonly string _accountNumber;
        private string AccountHolderName { get; set; }
        public Currency Balance;

        public BankAccount(string accNumber, string holderName, string currCode, int amount = 0)
        {
            _accountNumber = accNumber;  
            AccountHolderName = holderName;
            this.Balance.CurrencyCode = currCode;
            this.Balance.Amount = amount;
        }
        public string AccountNumber
        {
            get { return _accountNumber; }
        }
        public void Deposit(int amount)
        {
            int oldBalance = this.Balance.Amount;
            Console.WriteLine($"Old Balance: { this.Balance.Amount}");
            this.Balance.Amount += amount;
            Console.WriteLine($"New Balance: { this.Balance.Amount}");
        }
        public void Withdraw(int amount)
        {
            int oldBalance = this.Balance.Amount;
            Console.WriteLine($"Old Balance: { this.Balance.Amount}");
            if (amount > oldBalance)
            {
                Console.WriteLine("Not enough money on balance");
            }
            else if (amount == 0)
            {
                Console.WriteLine($"Min withdraw should be more than 1{this.Balance.CurrencyCode}");
            }
            else
            {
                this.Balance.Amount -= amount;
                Console.WriteLine($"New Balance: { this.Balance.Amount}");
            }
        }
        public void BalanceCheck()
        {
            Console.WriteLine($"Current Balance: {this.Balance.Amount} {this.Balance.CurrencyCode}");
        }

    }

    internal partial class BankAccount
    {
        public void TransferFunds(BankAccount target, Currency amount)
        {
            Console.WriteLine($"Old Amount on Source: {this.Balance.Amount}");
            Balance.Amount -= amount.Amount;
            target.Balance.Amount += amount.Amount;
            Console.WriteLine($"New Amount on Target: {target.Balance.Amount}");
        }
    }

    public struct Currency
    {
        public string CurrencyCode { get; set; }
        public int Amount { get; set; }

        public Currency(string cuurCode, int amount)
        {
            this.CurrencyCode = cuurCode;
            this.Amount = amount;
        }

    }

}

//Withdraw(Currency amount) - ანგარიშიდან თანხის გატანა;
//BalanceCheck - მიმდინარე ბალანსის შემოწმება, დააბრუნებს მიმდინარე ბალანსს;