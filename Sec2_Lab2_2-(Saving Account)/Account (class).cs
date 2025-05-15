namespace Account;

public class SavingAccount
{
    private static decimal annualIntrest = .5m;
    private decimal SavingBalance { get; set; }
    public SavingAccount(decimal SavingBalance)
    {
        this.SavingBalance = SavingBalance;
    }
    public void MonthlyIntrest()
    {
        SavingBalance += (SavingBalance * annualIntrest) / 12;
    }
    public static void ModifyInterest(decimal newInterest)
    {
        annualIntrest = newInterest;
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"the Balance is : {SavingBalance :F2}");
    }
}
