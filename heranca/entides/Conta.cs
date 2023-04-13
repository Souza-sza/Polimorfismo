using System;
using System.Collections.Generic;


namespace heranca.entides
{
    internal class Account
    {
     public int Number { get; set; }
       public string Holder { get; set; }
       public double Balance { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void WithDraw (double valor)
        {
            Balance -= valor + 5.0;
        }
        public void Deposit(double valor)
        {
            Balance += valor ;
        }
    }
}
