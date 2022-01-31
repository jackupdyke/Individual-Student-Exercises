namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base( accountHolderName,  accountNumber,  balance)
        {

        }

        
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
                
            if(Balance <= -100.00M)
            {
                return Balance;
            }
            else if(Balance < 0 && Balance >= -100.00M)
            {
                base.Withdraw(amountToWithdraw + 10);
                
                return Balance;

            }
            else
            {
                base.Withdraw(amountToWithdraw);

                return Balance;
            }

            
            




        }

    }
}
