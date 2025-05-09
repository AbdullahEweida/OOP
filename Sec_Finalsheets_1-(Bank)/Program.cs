//*A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
//*Customers can be individuals or companies. 
//*All accounts have a customer, balance and interest rate (monthly based).
//*Deposit accounts allow depositing and withdrawing of money.
//*Loan and mortgage accounts allow only depositing.
//*All accounts can calculate their interest for a given period (in months).
//*In the general case, it is calculated as follows: number_of_months * interest_rate.
//*Loan accounts have no interest rate during the first 3 months if held by individuals and during the first 2 months if held by a company.
//*Deposit accounts have no interest rate if their balance is positive and less than 1000.
//*Mortgage accounts have ½ the interest rate during the first 12 months for companies and no interest rate during the first 6 months for individuals.
//*Your task is to write an object-oriented model of the bank system.
//*You must identify the classes, interfaces, base classes and abstract actions and implement the interest calculation functionality.

using Accounts;

Console.WriteLine("Enter your type: \n1-Company 2-individual \nchoose(1or2) : ");
short typeCust = short.Parse(Console.ReadLine());

Console.WriteLine("Enter your account type: \n1-Mortgage account   2-Deposit account   3-Loan account");
Console.Write("Choose (1or2or3): ");
short typeAccounts = short.Parse(Console.ReadLine());

Console.Write("Enter Balance : ");
decimal Balance = decimal.Parse(Console.ReadLine());

Console.Write("Enter number of months : ");
int number_of_months = int.Parse(Console.ReadLine());

Console.Write("Enter interest rate : ");
decimal interest_rate = decimal.Parse(Console.ReadLine());

switch (typeAccounts)
{
    case 1:
        MortgageAccount M = new MortgageAccount();
        M.customer = (Customers)typeCust;
        M.balance = Balance;
        Console.WriteLine("The interest rate : " + M.InterestRate(number_of_months, interest_rate));
        break;

    case 2:
        DepositAccount D = new DepositAccount();
        D.customer = (Customers)typeCust;
        D.balance = Balance;
        Console.WriteLine("The interest rate : " + D.InterestRate(number_of_months, interest_rate));
        break;

    case 3:
        LoanAccount L = new LoanAccount();
        L.customer = (Customers)typeCust;
        L.balance = Balance;
        Console.WriteLine("The interest rate : " + L.InterestRate(number_of_months, interest_rate));
        break;
}
