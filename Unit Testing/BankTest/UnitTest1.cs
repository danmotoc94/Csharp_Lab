using App;

namespace BankTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Debit_WithValidAmount() {
        var bank = new Bank("Andrew", 300);
        bank.Debit(100);
        Assert.That(bank.Balance, Is.EqualTo(200));
    }
    
    [Test]
    public void Debit_WhenAmountIsLessThanZero() {
        var bank = new Bank("Andrew", 300);
        Assert.Throws<NegativeAmountException>(() => bank.Debit(-200));
    }
    
    [Test]
    public void Debit_WhenAmountIsMoreThanBalance() {
        var bank = new Bank("Andrew", 300);
        Assert.Throws<InsufficientBalanceException>(() => bank.Debit(500));
    }
    
    [Test]
    public void Credit_WithValidAmount() {
        var bank = new Bank("Andrew", 300);
        bank.Credit(100);
        Assert.That(bank.Balance, Is.EqualTo(400));
    }
    
    [Test]
    public void Credit_WhenAmountIsLessThanZero() {
        var bank = new Bank("Andrew", 300);
        Assert.Throws<NegativeAmountException>(() => bank.Credit(-200));
    }
}