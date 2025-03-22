namespace HFDomain;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}


public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}


public class ShoppingCart
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}

public class ShoppingCartItems
{
    public int Id { get; set; }
    public int ShoppingCartId { get; set; }
    public ShoppingCart ShoppingCart { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int Discount { get; set; }
}
