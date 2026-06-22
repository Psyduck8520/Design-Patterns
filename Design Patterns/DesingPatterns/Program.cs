using System;
using DesingPatterns.DependecyIjectionPattern;
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
             
             //Inyeccion de dependecias
             // en los frameworks  tenemos un contendor, pero con el main
             
             var  beer  = new  Beer("Pinkantus", "Erdinger"); // la clase que depende del objeto 
             // reposabilidad de saber , es uno de los principios de la inversion de la dependencia  no se debe depender de implementaciones si no de abstracciones
             //si no recibe las cosas ya hechaas
             var  drinkWithBeer = new DrinkWithBeer(100, 50, beer); // aki mandamos en la instancia el objeto.
                drinkWithBeer.Build(); // Drink with Pikantus , water: 100 and sugar: 50
        }
    }
};

