using System;
using System.Collections.Generic;
using System.Security.Principal;


namespace heranca.entides
{
    internal class BusinessAccount: Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanlimite) 
            : base(number, holder, balance)
        {
               LoanLimit = loanlimite;
        }
        public void Loan(double amount)
        {
            if(amount < LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
