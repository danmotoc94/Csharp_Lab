namespace App2;

public class OrderDetails
{
    private int orderId;
    private int productId;
    private int quantity;

    public OrderDetails(int orderId, int productId, int quantity) {
        this.orderId = orderId;
        this.productId = productId;
        this.quantity = quantity;
    }

    public int OrderId
    {
        get => orderId;
        set => orderId = value;
    }

    public int ProductId
    {
        get => productId;
        set => productId = value;
    }

    public int Quantity
    {
        get => quantity;
        set => quantity = value;
    }
}