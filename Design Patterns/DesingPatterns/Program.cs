using DesingPatterns.FactoryPattern;
using DesingPatterns.Models;
using DesingPatterns.RepositoryPattern;
using DesingPatterns.Singleton;
using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contex = new DesignPatternsContext())
            {
              
                var beerRepository = new Repository<Beer>(contex);
                var beer =   new Beer()
                {
                    Name =  "Fuller",
                    Style = "Strong Ale"
                } ;
                beerRepository.Add(beer); // Add the beer to the repository
                beerRepository.Save();

                foreach (var b in beerRepository.Get())
                {
                    Console.WriteLine($"Beer: {b.Name}, Style: {b.Style}");
                }
                // Vamos hacer para agregar brand
                var brandRepository = new Repository<Brand>(contex);  
                var brand = new Brand()
                {
                    Name = "Fuller's Brewery"
                };
                brandRepository.Add(brand); // Add the brand to the repository
                brandRepository.Save();
                foreach (var b in brandRepository.Get())
                {
                    Console.WriteLine($"{b.Name}");
                }
            }  
        }
        
    }
}
