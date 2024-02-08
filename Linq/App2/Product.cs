namespace App2;

public class Product
{
    private int productId;
    private string name;
    private decimal unitPrice;
    private string category;

    public Product(int productId, string name, decimal unitPrice, string category)
    {
        this.productId = productId;
        this.name = name;
        this.unitPrice = unitPrice;
        this.category = category;
    }

    public int ProductId
    {
        get => productId;
        set => productId = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public decimal UnitPrice
    {
        get => unitPrice;
        set => unitPrice = value;
    }

    public string Category
    {
        get => category;
        set => category = value ?? throw new ArgumentNullException(nameof(value));
    }
}