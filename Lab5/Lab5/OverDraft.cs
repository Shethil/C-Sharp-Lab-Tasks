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


        public OverDraft(string accName, string accid, int balance)
        {
            this.AccName = accName;
            this.Accid = accid;
            this.Balance = balance;
        }
        new public void Withdraw(int amount)
        {
            this.Balance = Balance + limit;

            if (amount > Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else
            {
                Console.WriteLine("Under limit");
            }
        }
        new public void showInfo()
        {
            base.showInfo();
        }
    } 
}
