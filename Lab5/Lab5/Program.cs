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
            Account a1 = new Account("Shithil", "12345", 5000);
            a1.showInfo();
            Account b1 = new Account("Tamim", "12346", 1000);
            b1.showInfo();
            a1.Transfer(6000, a1, b1);
            b1.showInfo();
        }
    }
}
