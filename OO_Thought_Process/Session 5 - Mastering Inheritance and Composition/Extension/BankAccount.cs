namespace Session_5.Extension;

/*
 * This example demonstrates Extension inheritance
 */

/**
 * The BankAccount base class is simple;
 * it has a current balance, and methods to deposit or withdraw an amount
 */
public class BankAccount
{
    public decimal Balance { get; protected set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount) throw new Exception("Not enough money in account");

        Balance -= amount;
    }
}

/**
 * The InvestmentBankAccount simply extends BankAccount
 * with additional operations.
 *
 * In this case it adds a investment yield rate, and
 * a method to invest the balance for a period of time.
 */
public class InvestmentBankAccount : BankAccount
{
    public decimal YieldRate { get; }

    public InvestmentBankAccount(decimal balance, decimal yieldRate) : base(balance)
    {
        YieldRate = yieldRate;
    }

    public void InvestFor(int time)
    {
        Balance += Balance * YieldRate * time;
    }
}