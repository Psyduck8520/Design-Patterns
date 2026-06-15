using System;
using DesingPatterns.FactoryPattern;
using DesingPatterns.Singleton;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
             SaleFactory storeSaleFactory = new StoreSaleFactory(10);
             SaleFactory internetSaleFactory = new InternetSaleFactory(5); 
             //hacemos uso de las fabricas 
             
             ISale sale1  =  storeSaleFactory.GetSale();
             sale1.Sell(100); // La venta en tienda tiene un total de : 110
             
             ISale sale2  =  internetSaleFactory.GetSale();
             sale2.Sell(100); // La venta en INTERNET tiene un total de 95  
        }
    }
};

