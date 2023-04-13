using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca.entides
{
    internal class SalvingsAcount : Account
    {
        public double InterestRate { get; set; }   
        public SalvingsAcount() { }
        public SalvingsAcount(int number, string holder, double balance,
        double interestRate) : base (number, holder, balance)
        { 
            InterestRate = interestRate;
        }

        public override void WithDraw(double valor)
        {
            base.WithDraw(valor);
            Balance -= +2.50;
        }
        public void UpdateBalace()
        {
            Balance += Balance * InterestRate;
        }

    }
}
