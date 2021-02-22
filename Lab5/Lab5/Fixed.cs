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
       

        public Fixed(string accName, string accid, int balance)
        {
            this.AccName = accName;
            this.Accid = accid;
            this.Balance = balance;
        }

        new public void Withdraw(int amount)
        {
            if (tenureYear >= 10)
            {
                this.Balance= Balance ;
                Balance = Balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else 
            {
                Console.WriteLine("Withdraw money");
            }
        }
        new public void showInfo()
        {
            base.showInfo();
        }
    } 
}
