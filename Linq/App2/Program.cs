namespace App2;

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product> {
            new Product(1, "Product1", 15, "Food"),
            new Product(2, "Product2", 5, "Drink"),
            new Product(3, "Product3", 20, "Care"),
            new Product(4, "Product4", 8, "Other")
        };

        List<Customer> customers = new List<Customer> {
            new Customer(1, "Customer1", "Romania", "Bucharest", "0723 456 789"),
            new Customer(2, "Customer2", "UK", "London", "0712 345 678")
        };

        List<Order> orders = new List<Order> {
            new Order(1, new DateTime(2021, 1, 15), 1),
            new Order(2, new DateTime(2022, 3, 20), 2)
        };

        List<OrderDetails> orderDetails = new List<OrderDetails> {
            new OrderDetails(1, 1, 2),
            new OrderDetails(1, 3, 1),
            new OrderDetails(2, 2, 3)
        };
        
        var productsWithUnitPriceGreaterOrEqualThan10 = products.Where(p => p.UnitPrice >= 10);
        var allProductNames = string.Join(", ", products.Select(p => p.Name));
        var productNamesAndPrices = string.Join("\n", products
            .Where(p => p.UnitPrice >= 10)
            .Select(p => $"{p.Name}, Unit Price: {p.UnitPrice}"));
        var mostExpensiveProducts = products.OrderByDescending(p => p.UnitPrice).Take(2);
        var allButMostExpensiveProducts = products.OrderByDescending(p => p.UnitPrice).Skip(2);
        var customersWithOrders =
            from customer in customers
            join order in orders on customer.CustomerId equals order.CustomerId
            select new { Customer = customer, Order = order };
        var productsOrderedByCategoryAndPrice = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
        var productsGroupedByCategory = products.GroupBy(p => p.Category, (key, group) => new { Category = key, Products = group });
        var customersWithOrdersIn2021 =
            from customer in customers
            join order in orders.Where(o => o.OrderDate.Year == 2021) on customer.CustomerId equals order.CustomerId
            select customer;
        var firstCustomerWithPhoneNumber = customers.FirstOrDefault(c => c.Phone == "0723 456 789");
        var totalCustomersFromLondon = customers.Count(c => c.City == "London");
        var anyCustomerFromRomania = customers.Any(c => c.Country == "Romania");
        var totalOrdersFrom2021 = orders.Count(o => o.OrderDate.Year == 2021);
        
        Console.WriteLine("Products with Unit Price >= 10:");
        foreach (var product in productsWithUnitPriceGreaterOrEqualThan10)
            Console.WriteLine(product.Name + ", Unit Price: " + product.UnitPrice);

        Console.WriteLine("\nAll Product Names: " + allProductNames);

        Console.WriteLine("\nProduct Names and Prices (Unit Price >= 10):\n" + productNamesAndPrices);

        Console.WriteLine("\nMost 2 Expensive Products:");
        foreach (var product in mostExpensiveProducts)
            Console.WriteLine(product.Name + ", Unit Price: " + product.UnitPrice);

        Console.WriteLine("\nAll But Most Expensive 2 Products:");
        foreach (var product in allButMostExpensiveProducts)
            Console.WriteLine(product.Name + ", Unit Price: " + product.UnitPrice);

        Console.WriteLine("\nCustomers with their Orders:");
        foreach (var entry in customersWithOrders)
            Console.WriteLine("Customer: " + entry.Customer.CustomerName + ", OrderId: " + entry.Order.OrderId);

        Console.WriteLine("\nProducts Ordered by Category and Descending Unit Price:");
        foreach (var product in productsOrderedByCategoryAndPrice)
            Console.WriteLine("Category: " + product.Category + ", Product: " + product.Name + ", Unit Price: " + product.UnitPrice);
        

        Console.WriteLine("\nProducts Grouped by Category:");
        foreach (var group in productsGroupedByCategory)
        {
            Console.WriteLine("Category: " + group.Category);
            foreach (var product in group.Products)
                Console.WriteLine("  Product: " + product.Name + ", Unit Price: " + product.UnitPrice);
        }

        Console.WriteLine("\nCustomers with Orders in 2021:");
        foreach (var customer in customersWithOrdersIn2021)
            Console.WriteLine("Customer: " + customer.CustomerName);

        Console.WriteLine("\nFirst Customer with Phone Number '0723 456 789':");
        Console.WriteLine(firstCustomerWithPhoneNumber != null
            ? "Customer: " + firstCustomerWithPhoneNumber.CustomerName
            : "Customer not found");

        Console.WriteLine("\nTotal Customers from London: " + totalCustomersFromLondon);

        Console.WriteLine("\nAny Customer from Romania? " + anyCustomerFromRomania);

        Console.WriteLine("\nTotal Sum of Orders from 2021: " + totalOrdersFrom2021);
    }
}