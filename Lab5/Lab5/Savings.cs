using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Savings : Account
    {
        int balance =430 ;
        public void Withdraw(int amount)
        {
            if (amount > 430)
            {
                balance = balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else 
            {
                Console.WriteLine("Not sufficient Balance");
            }
        }

    }
}
