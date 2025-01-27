namespace BankSystem;

public class XBank : IBankAccount
{
    public int AccountNumber { get; set; }
    public string? AccountHolder { get; set;}
    public decimal Balance { get; set; }
    public XBank()
    {

    }
    public XBank(int number, string holder, decimal balance)
    {
        AccountNumber = number;
        AccountHolder = holder;
        Balance = balance;
    }
    public void Deposit(int amount)
    {
        Balance += amount;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Account Number = {AccountNumber}");
        Console.WriteLine($"Account Holder = {AccountHolder}");
        Console.WriteLine($"Balance = {Balance}");        
    }

    public void Withdraw(int amount)
    {
        Balance -= amount;
    }
}
