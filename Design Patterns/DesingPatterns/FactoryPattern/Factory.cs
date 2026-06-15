namespace DesingPatterns.FactoryPattern;

//Creador
public abstract class SaleFactory
{
    public  abstract  ISale GetSale();
}

// Concret Creator
public class StoreSaleFactory : SaleFactory
{
    private decimal _extra;
    
    public StoreSaleFactory(decimal extra)
    {
        _extra = extra;
    }
    public override ISale GetSale()
    {
        // Implementamos la creacion 
        return new StoreSale(_extra);
    }
}

public class InternetSaleFactory : SaleFactory
{
    private decimal _discount;
    
    public InternetSaleFactory(decimal discount)
    {
        _discount = discount;
    }
    public override ISale GetSale()
    {
        // Implementamos la creacion 
        return new InternetSale(_discount);
    }
}




//Concret product  venta por internet
public class InternetSale : ISale
{
    private decimal _discount;
    public InternetSale(decimal discount)
    {
        _discount = discount;
    }

    public void Sell(decimal total)
    {
        Console.WriteLine($"La venta en INTERNET tiene un total de :  {total - _discount}");
    }
}

// Concret Product
public class StoreSale : ISale
{
    private decimal _extra;

    public StoreSale(decimal extra)
    {
        
        _extra  = extra;
    }
    public void Sell(decimal total)
    {
        Console.WriteLine($"La venta en TIENDA tiene un total de :  {total  + _extra}");
    }
}

// Product 
public interface ISale
{
     public void Sell(decimal total);
}
