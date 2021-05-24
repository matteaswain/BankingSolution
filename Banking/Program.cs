using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {



            var cd1 = new CertifacteofDeposit(Amount: 1000, Months: 12);
            cd1.WithdrawDate = DateTime.Now.AddDays(2);
            var funds = cd1.Withdraw();

            var sav1 = new Savings();
            sav1.Deposit(1000);
            sav1.PayInterest(3);


            var acct1 = new account();
            acct1.Deposit(500);
            acct1.Withdraw(200);
            acct1.Withdraw(600);
            acct1.Deposit(-400);
            Console.WriteLine($"Balance is {acct1.Balance}");


            var acct2 = new account();
            acct1.Transfer(1000, acct2);
            Console.WriteLine($"Balance is {acct1.Balance}");
            Console.WriteLine($"Balance is {acct2.Balance}");
        }
    }
}