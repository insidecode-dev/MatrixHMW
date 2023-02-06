using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountProject.Helper
{
    public abstract class ParentOfAcct
    {
        public decimal Balance;
        public string AccountOwner;

        
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract void Withdraw(decimal a);
    }
}
