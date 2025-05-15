using BankAccount;

Account account = new Account("Amar Mahros", 12348748, 15250.99m);
account.Withdraw(-50);
account.Withdraw(150.99m);
account.Deposit(20);
account.DisplayAccount(); 