using System;

public class Product
{
	public Product()
	{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int productID, string name, double price)
    {
        ProductID = productID;
        Name = name;
        Price = price;
    }
}
}
