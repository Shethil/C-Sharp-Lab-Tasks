using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Account
    {
        string accName;
        string accid;
        int balance;

        public Account(string accName, string accid, int balance)
        {
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accid = value; }
            get { return accid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

 
        public void Deposit(int amount)
        {
            balance = balance + amount;
            {
                Console.WriteLine(amount+" Money Added");
            }
        
            }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            {
                Console.WriteLine(amount+" Money withdrow");
            }
        }

        public void showInfo()
        {
            Console.WriteLine("Name is :" + AccName);
            Console.WriteLine("ACCount ID is :" + Accid);
            Console.WriteLine("Balance is :" + balance);
        }



        }
    }

