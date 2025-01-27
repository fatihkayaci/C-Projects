namespace BankSystem;

public interface IBankAccount
{
    public int AccountNumber { get; set; }
    public string? AccountHolder { get; set; }
    public decimal Balance { get; set; }
    public void Deposit(int amount);
    public void Withdraw(int amount);
    public void DisplayInfo();
}
