using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountProject.Helper
{
    public class CheckingAcct:ParentOfAcct
    {
        
        public CheckingAcct(string name, string surname, decimal initBalance)
        {
            AccountOwner = name + " " + surname;
            Balance= initBalance;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance>=amount)
            {                
                Balance -= (amount);
            }
            else if (Balance < amount)
            {
                Balance -= amount + 35.0m;
                
            }
        }
    }
}
