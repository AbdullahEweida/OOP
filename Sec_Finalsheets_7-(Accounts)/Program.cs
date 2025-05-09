using ClassesAccounts;

Cur_Account CA = new Cur_Account();
CA.Name = "Mohamed Abdualrhman";
CA.Balance = 841;
CA.Deposit(50.5m);
CA.Withdraw(4551);
CA.MinBalance = 50;
CA.ServiceCharge = 100;
CA.DisplayBalance();

Sav_Accounts SA = new Sav_Accounts();
SA.Name = "Amr Mahmoud El-Deeb";
SA.Balance = 4516;
SA.Interest = 2.5m;
SA.Deposit(50);
SA.Withdraw(100);
SA.DisplayBalance();