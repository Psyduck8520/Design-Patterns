using DesingPatterns.FactoryPattern;
using DesingPatterns.Models;
using DesingPatterns.RepositoryPattern;
using DesingPatterns.Singleton;
using DesingPatterns.UnitOfWorkPattern;
using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contex = new DesignPatternsContext())
            {
              
               var unitOfWork = new UnitOfWork(contex);
               var beers = unitOfWork.Beers;
               var beer = new Beer { Name = "Fuller", Style = "Porter" };
                beers.Add(beer);
                
               var brands = unitOfWork.Brand;
               var brand = new Brand { Name = "Fuller's Brewery" };
                brands.Add(brand);
                unitOfWork.Save(); // aki mandamos todo a guardar de una sola
                 // de esta manera se mejora el rendimiento de nuestro sistema.

            }  
        }
        
    }
}
