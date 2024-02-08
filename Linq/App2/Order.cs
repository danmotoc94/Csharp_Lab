namespace App2;

public class Order
{
    private int orderId;
    private DateTime orderDate;
    private int customerId;

    public Order(int orderId, DateTime orderDate, int customerId) {
        this.orderId = orderId;
        this.orderDate = orderDate;
        this.customerId = customerId;
    }

    public int OrderId
    {
        get => orderId;
        set => orderId = value;
    }

    public DateTime OrderDate
    {
        get => orderDate;
        set => orderDate = value;
    }

    public int CustomerId
    {
        get => customerId;
        set => customerId = value;
    }
}