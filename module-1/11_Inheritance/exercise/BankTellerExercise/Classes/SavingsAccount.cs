namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
            if(amountToWithdraw > Balance || amountToWithdraw + 2 > Balance)
            {
                return Balance;
            }
            
            

            else if (Balance < 152.00M)
            {
                base.Withdraw(amountToWithdraw + 2.00M);
                return Balance;
            }
            
            
            
            

            
            return base.Withdraw(amountToWithdraw);
        }
    }
}
