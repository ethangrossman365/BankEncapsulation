using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }
        
            
        
    }
}
