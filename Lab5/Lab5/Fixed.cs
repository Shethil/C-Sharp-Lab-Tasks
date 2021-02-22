using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 
{
    class Fixed : Account 
    {
        int tenureYear = 10 ;
        int balance;
        public void Withdraw(int amount)
        {
            if (tenureYear >= 10)
            {
                this.balance= Balance ;
                Balance = Balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else 
            {
                Console.WriteLine("Withdraw money");
            }
        }
    }
}
