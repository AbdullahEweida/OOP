namespace Accounts;
//*All accounts have a customer, balance and interest rate (monthly based).
interface InterestRate
{
    public decimal InterestRate(int number_of_months, decimal interestRate);
}
public enum Customers
{
    isCompany = 1, isIndividuals = 2
}
public class BankAccounts : InterestRate
{
    public Customers customer { get; set; }
    public decimal balance { get; set; }
    public virtual decimal InterestRate(int numberOfMonths, decimal interestRate)
    {
        return numberOfMonths * interestRate;
    }
}
//*Deposit accounts allow depositing and withdrawing of money.
public class DepositAccount : BankAccounts
{
    public void Deposit(decimal _deposit)
    {
        balance += _deposit;
    }
    public void Withdraw(decimal _deposit)
    {
        balance -= _deposit;
    }
    public override decimal InterestRate(int numberOfMonths, decimal interestRate)
    {
        return (balance > 0 && balance < 1000) ? 0 : numberOfMonths * interestRate;
    }
}
//Loan accounts have no interest rate during the first 3 months if held by individuals and during the first 2 months if held by a company.
public class LoanAccount : BankAccounts
{
    public void Deposit(decimal _deposit)
    {
        balance += _deposit;
    }
    public override decimal InterestRate(int numberOfMonths, decimal interestRate)
    {
        return (customer == Customers.isIndividuals)
            ? Math.Max(0, numberOfMonths - 3) * interestRate
            : (customer == Customers.isCompany)
            ? Math.Max(0, numberOfMonths - 2) * interestRate
            : 0;
    }
}
public class MortgageAccount : BankAccounts
{
    public void Deposit(decimal _deposit)
    {
        balance += _deposit;
    }
    public override decimal InterestRate(int numberOfMonths, decimal interestRate)
    {
        return (numberOfMonths > 12 && customer == Customers.isCompany) ? .5m * (numberOfMonths * interestRate) :
        (numberOfMonths > 6 && customer == Customers.isIndividuals) ? (numberOfMonths * interestRate) : 0;
    }
}