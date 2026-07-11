using DesingPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.RepositoryPattern
{
    internal class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _context;
        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }
        public void Add(Beer data)
        {
            _context.Beers.Add(data);        
        }

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _ = _context.Beers.Remove(beer);
        }
        public IEnumerable<Beer> GetAllBeers() => _context.Beers.ToList();


        public  Beer Get(int id)  => _context.Beers.Find(id) ?? throw new ArgumentException($"Beer with id {id} not found.");

        public void Update(Beer data)
        {
             _context.Entry(data).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges(); //  si no se hace el save no hay cambios en la base de datos, solo se hace en memoria
        }
    }
}
