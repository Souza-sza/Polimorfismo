using System.Globalization;
using System.Collections.Generic;
using heranca.entides;
namespace heranca
{
    class program
    {
        static void Main(string[] args)
        {
           Account cc1 = new Account(3015, "mario", 500.0);
            SalvingsAcount cc2 = new SalvingsAcount(3315, "joana", 500.0, 0.2);
            cc2.WithDraw(10.0);
            cc1.WithDraw(10.0);
            Console.WriteLine(cc2.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(cc1.Balance);

        }
    }
}