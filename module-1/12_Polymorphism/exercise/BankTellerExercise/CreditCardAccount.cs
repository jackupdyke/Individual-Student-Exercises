using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {

        public CreditCardAccount (string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; } = 0.00M;
        public decimal Balance { get; set; } 
        
        

        public virtual decimal Pay(decimal amountToPay)
        {
            Debt -= amountToPay;
            Balance = -Debt;
            return Debt;
        }

        public virtual decimal Charge(decimal amountToCharge)
        {
            Debt += amountToCharge;
            Balance = -Debt;
            return Debt;
        }

    }
}
