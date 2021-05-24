using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class account
    {
        public static string AcctNbr { get; private set; }
        public decimal Balance { get; private set; }
        public string RoutingNumber { get; private set; }
        public string Description { get; set; }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Amount must be greater than 0 ");
                return false;
            }
            Balance = Balance + amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if(amount <= 0 )
            {
                Console.WriteLine($"Amount must be greater than 0 ");
                return false;
            }                
            if(amount > Balance)
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }
            Balance = Balance - amount;
            return true; 
        }
        public bool Transfer(decimal amount, account toAccount)
        {
            var success = this.Withdraw(amount);
            if(success == true)
            {
            toAccount.Deposit(amount);
                return true;                
            }
            return false;
            
        }
    }
}
