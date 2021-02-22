using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class SprcialCurrent : Account
    {
        public SprcialCurrent(string accName, string accid, int balance)
        {
            this.AccName = accName;
            this.Accid = accid;
            this.Balance = balance;
        }

        int openinBalance;
        new public void Withdraw(int amount)
        {
            this.openinBalance = Balance;

            if (amount < openinBalance*0.1)
            {
                Balance = Balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else
            {
                Console.WriteLine("Under 10% balance");
            }
        }
        new public void showInfo()
        {
            base.showInfo();
        }
       
    }
}
