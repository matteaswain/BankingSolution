using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings2 : IBanking
    {
        private account account = new account(); // creating an instance of a class 
                                                 // Composition //
        public decimal InterestRate { get; private set; } = 0.12m;
        public bool Deposit(decimal amount)
        {
            return account.Deposit(amount);
//       class/deposite method from Acct class/var amount             
        }
         public bool Withdraw(decimal amount)
        {
            return account.Withdraw(amount);
        }
          
        public bool Transfer(decimal amount,account toAccount)
        {
            return account.Transfer(amount, toAccount);
        }

        public Savings2() // constructor to defin and instance // not needed if Line 9 is done 
        {
            account = new account();
        }
        public virtual decimal CalculateInterestByMonths(int NumberofMonths)
        {
            return account.Balance * (InterestRate / 12.0m) * NumberofMonths;
        }
        public void PayInterest(int NumberofMonths)
        {
            var interest = CalculateInterestByMonths(NumberofMonths);
            Deposit(interest);
        }

        public decimal GetBalance()
        {
            return account.Balance;
        }

        public string GetAccountNumber()
        {
            return account.AcctNbr;
        }
    }
}
