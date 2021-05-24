using System;
using System.Collections.Generic;
using System.Text; 

namespace Banking
{
    class CertifacteofDeposit : IBanking
    {
        private account account = new account();

        public DateTime DepositeDate { get; private set; } = DateTime.Now;
        public DateTime WithdrawDate { get; set; }

      

        public bool Withdraw()
        {            
                if (DateTime.Now < WithdrawDate)
                {
                    Console.WriteLine($"Cannot withdrawl till {WithdrawDate}");
                    return false;
                }
            return account.Withdraw(account.Balance);
        }

        public decimal GetBalance()
        {
            return account.Balance;
        }

        public string GetAccountNumber()
        {
            return account.AcctNbr;
        }

        public CertifacteofDeposit(decimal Amount, int Months)
        {
            var success = account.Deposit(Amount);
            // check success to verify deposite worked

            var interestRate = 0.0m;
            switch (Months)
            {
                case 12: interestRate = 0.01m; break;
                case 24: interestRate = 0.02m; break;
                case 36: interestRate = 0.03m; break;
                case 48: interestRate = 0.04m; break;
                case 60: interestRate = 0.05m; break;
                default: break;
            }
            var interest = account.Balance * (interestRate / 12) * Months;
            success = account.Deposit(interest);
            WithdrawDate = DepositeDate.AddMonths(Months);
        }
    }
}
