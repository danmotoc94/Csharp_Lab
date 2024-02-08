namespace App2;

public class Customer
{
    private int customerId;
    private string customerName;
    private string country;
    private string city;
    private string phone;

    public Customer(int customerId, string customerName, string country, string city, string phone) {
        this.customerId = customerId;
        this.customerName = customerName;
        this.country = country;
        this.city = city;
        this.phone = phone;
    }

    public int CustomerId
    {
        get => customerId;
        set => customerId = value;
    }

    public string CustomerName
    {
        get => customerName;
        set => customerName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Country
    {
        get => country;
        set => country = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string City
    {
        get => city;
        set => city = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Phone
    {
        get => phone;
        set => phone = value ?? throw new ArgumentNullException(nameof(value));
    }
}