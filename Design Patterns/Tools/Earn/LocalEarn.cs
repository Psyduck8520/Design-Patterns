namespace Tools.Earn;
public class LocalEarn : IEarn
{
    private decimal _percetage;
    public LocalEarn(decimal percetage)
    {
        _percetage = percetage;
    }
    public decimal Earn(decimal amount) // la frexibilidad  que nos dan  es que podemos altenera esta funciona sin alteral  las demas.
    {
         return amount * _percetage; 
    }
}