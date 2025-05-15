using Account;

SavingAccount server1 = new SavingAccount(30000);
SavingAccount server2 = new SavingAccount(50000);
Console.WriteLine("Before Calculate Monthly Interset");
server1.DisplayBalance();
server2.DisplayBalance();

SavingAccount.ModifyInterest(.05m);
server1.MonthlyIntrest();
server2.MonthlyIntrest();

Console.WriteLine("After Calculate Monthly Interset");
server1.DisplayBalance();
server2.DisplayBalance();