using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    namespace Banking
    {
        partial class BankAccount
        {
            public void Withdraw(double amount)
            {
                cbalance -= amount;
            }
        }
    }
}
   

