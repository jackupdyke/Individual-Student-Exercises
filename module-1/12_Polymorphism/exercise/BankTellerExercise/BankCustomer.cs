using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal totalAccount = 0.00M;
                foreach(IAccountable item in accountList)
                {
                   
                    if (item.Balance < 25000)
                    {
                        totalAccount += item.Balance;
                        
                    }
                    
                }

                foreach (IAccountable item in accountList)
                {

                    if (item.Balance >= 25000)
                    {
                        return true;

                    }

                }
                if (totalAccount >= 25000)
                {
                    return true;
                }
                
                else
                {
                    return false;
                }
            }
        }
        public decimal Balance { get; }

        List<IAccountable> accountList = new List<IAccountable>();


        public virtual void AddAccount(IAccountable newAccount)
        {
            accountList.Add(newAccount);
        }

        public virtual IAccountable[] GetAccounts()
        {
            return accountList.ToArray();
        }

        

        
            

    }
}
