class Order 
{
    private List<Products> products;
    private Customer customer;

    public Order(Customer customers)
    {
        customer = customers;
        products = new List<Products>();
    }

    public void Setproducts(List<Products> i)
    {
        products = i;
    }
    public List<Products> Getproducts()
    {
        return products;
    }
    public void Setcustomer(Customer c)
    {
        Customer customer = c;
    }
    public string Getcustomername()
    {
        return customer.Getname();
    }

    public void AddProduct(Products product)
    {
        products.Add(product);
    }
    //Calculates the cost of the products and shipping and returns both
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        int shipping = 0;

        if (customer.LivesInUSA())
            shipping = 5;
        else 
            shipping = 35;
        return total + shipping;
    }
    //Determines the varaibles for the shipping and packing label.
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Getpname()} ({product.GetID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Getname()}\n{customer.Getadd()}";
    }

}