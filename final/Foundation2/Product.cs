class Products
{
    private string pname;
    private string productId;
    private int price;
    private int quantity;

    public Products(string names, string productIds, int pricePer, int quantitys)
    {
        pname = names;
        productId = productIds;
        price = pricePer;
        quantity = quantitys;
    }

    public void SetID(string id)
    {
        productId = id;
    }
    public string GetID()
    {
        return productId;
    }
    public void Setprice(int p)
    {
        price = p;
    }
    public int Getprice()
    {
        return price;
    }
    public void Setquantity(int q)
    {
        quantity = q;
    }

    public string Getpname()
    {
        return pname;
    }
    public void Setpname(string y)
    {
        pname = y;
    }

     public int GetTotalCost()
    {
        return price * quantity;
    }
}