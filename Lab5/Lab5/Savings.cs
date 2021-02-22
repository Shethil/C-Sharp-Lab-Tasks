using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Savings : Account
    {
        

        public Savings(string accName, string accid, int balance)
        {
            this.AccName = accName;
            this.Accid = accid;
            this.Balance = balance;
        }


        int balance =430 ;
        new public void  Withdraw(int amount)
        {
            if (amount < 430)
            {
                balance = balance - amount;
                Console.WriteLine(amount + " Money withdrow");
            }
            else 
            {
                Console.WriteLine("Not sufficient Balance");
            }
        }
       
        new public void showInfo(){
            base.showInfo();
        }
    }
}
