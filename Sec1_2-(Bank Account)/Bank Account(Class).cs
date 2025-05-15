namespace BankAccount;

public class Account
{
    private string Name { get; set; }
    private ulong AccountNumber { get; set; }
    private decimal Balance { get; set; }
    public Account(string Name, ulong AccountNumber, decimal Balance)
    {
        this.Name = Name;
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
    }
    public void Deposit(decimal Money) => Console.WriteLine((Money > 0) ? ($"The Balance : {Balance += Money}") : "Error in the deposit");
    public void Withdraw(decimal Money) => Console.WriteLine((Money > 0) ? ($"The Balance : {Balance -= Money}") : "Error in the withdraw");
    public void DisplayAccount()
    {
        Console.WriteLine("The Account Info");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"ID : {AccountNumber}");
        Console.WriteLine($"Balance : {Balance}");
    }
    
}
