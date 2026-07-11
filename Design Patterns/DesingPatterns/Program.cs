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
                var beerRepository = new BeerRepository(contex);
                var beer   = new Beer();
                beer.Name = "Corona";
                beer.Style = "Pilsner";
                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var b in beerRepository.GetAllBeers())
                {
                    Console.WriteLine($"Beer: {b.Name}, Style: {b.Style}");
                }
            }  
        }
        
    }
}
