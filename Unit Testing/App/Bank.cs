namespace App;

public class Bank
{
    private string customerName;
    private double balance;

    public Bank(string customerName, double balance) {
        this.customerName = customerName;
        this.balance = balance;
    }

    public string CustomerName
    {
        get => customerName;
        set => customerName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Balance
    {
        get => balance;
        set => balance = value;
    }

    public void Debit(double amount) {
        if (amount <= 0)
            throw new NegativeAmountException("Amount can't be < 0");

        if (amount > balance)
            throw new InsufficientBalanceException("You cannot debit more than your balance!");
        balance -= amount;
    }

    public void Credit(double amount) {
        if (amount <= 0)
            throw new NegativeAmountException("Amount can't be < 0");
        balance += amount;
    }
}