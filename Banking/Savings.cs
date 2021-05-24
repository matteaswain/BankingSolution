using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings : account 
//  class ChildClass : ParentClass
    {
        public decimal InterestRate { get; private set; } = 0.12m; // property 

        public decimal CalculateInterestByMonths(int NumberofMonths)
        {
            return Balance * (InterestRate / 12.0m) * NumberofMonths;  
        }

        public void PayInterest(int NumberofMonths)
        {
            var interest = CalculateInterestByMonths(NumberofMonths);
            Deposit(interest);
        }

    }
}
