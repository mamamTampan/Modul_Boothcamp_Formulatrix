
enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

class Program
{
    static void Main()
    {
        int orderId = 123;
        OrderStatus status = GetOrderStatus(orderId);

        if (status == OrderStatus.Processing)
        {
            Console.WriteLine("This order is currently being processed.");
        }
        else if (status == OrderStatus.Delivered)
        {
            Console.WriteLine("This order has been delivered.");
        }
        else
        {
            Console.WriteLine("This order is in a different status.");
        }
    }

    static OrderStatus GetOrderStatus(int orderId)
    {
        if (orderId > 100)
        {
            return OrderStatus.Delivered;
        }
        else
        {
            return OrderStatus.Processing;
        }
    }
}
