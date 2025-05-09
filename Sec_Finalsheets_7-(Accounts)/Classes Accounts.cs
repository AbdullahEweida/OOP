namespace ClassesAccounts
{

    public abstract class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public void Deposit(decimal money)
        {
            Balance += money;
        }
        public void Withdraw(decimal money)
        {
            if (Balance >= money)
            {
                Balance -= money;
            }
        }
        public virtual void DisplayBalance()
        {
            Console.WriteLine($"The Name : {Name}");
            Console.WriteLine($"The Balance : {Balance}");
        }
    }
    public class Cur_Account : Account
    {
        public decimal MinBalance { get; set; }
        public decimal ServiceCharge { get; set; }
        protected void ComputeMinBalance()
        {
            if (Balance < MinBalance) { Balance -= ServiceCharge; }
        }
        public override void DisplayBalance()
        {
            ComputeMinBalance();
            base.DisplayBalance();
        }
    }
    public class Sav_Accounts : Account
    {
        public decimal Interest { get; set; }
        protected void ComputeInterest()
        {
            Balance += (Balance * Interest / 100);
        }
        public override void DisplayBalance()
        {
            ComputeInterest();
            base.DisplayBalance();
        }
    }
}