using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program : Account
    {
        
        static void Main(string[] args)
        { 
            Account a1 = new Account("Shithil", "001", 5000);
            a1.showInfo();
            Account b1 = new Account("Tamim", "002", 1000);
            b1.showInfo();

            a1.Transfer(4000, a1, b1);
            b1.showInfo();
            Console.WriteLine();

            Savings s1 = new Savings ("Tonoy", "003", 3000);
            s1.showInfo();
            s1.Withdraw(2800);
            Console.WriteLine();

            SprcialCurrent sp1 = new SprcialCurrent("Sakib", "004", 500);
            sp1.showInfo();
            sp1.Withdraw(490);
            Console.WriteLine();  

             OverDraft od1 = new OverDraft("Monir", "005", 100000);
             od1.showInfo();
             od1.Withdraw(300000);
             Console.WriteLine(); 

            Fixed f1 = new Fixed("Sabbir", "005", 100000);
            f1.showInfo();
            Console.WriteLine();

        }
    }
}
