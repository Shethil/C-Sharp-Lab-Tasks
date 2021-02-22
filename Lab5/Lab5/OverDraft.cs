using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class OverDraft : Account
    {
        int limit = 50000;
        int balance;
        public void Withdraw(int amount)
        {
            this.balance = Balance + limit;

            if (amount > balance)
            {
                Balance = Balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else
            {
                Console.WriteLine("Under limit");
            }
        }
    }
}
