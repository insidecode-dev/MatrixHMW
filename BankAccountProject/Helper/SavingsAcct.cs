using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountProject.Helper
{
    public class SavingsAcct:ParentOfAcct
    {
        private readonly decimal commission=0;
        private static decimal commissionCount=0;
        public SavingsAcct(string name, string surname, decimal _commission, decimal initBalance)
        {
            AccountOwner= name+" "+surname;
            commission = _commission;
            Balance= initBalance;
        }
        public void ApplyInterest()
        {            
            Balance= Balance + Balance * commission;            
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance>=amount)
            {
                if (commissionCount >= 3)
                {
                    Balance -= amount + 2.0m;
                    return;
                }
                Balance -= amount;
                commissionCount++;
            }
            else if (Balance < amount)
            {
                Console.WriteLine("there is not enough money for operating this transaction");
                return;
            }
        }
    }
}
