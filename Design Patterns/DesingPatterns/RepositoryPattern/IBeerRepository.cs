using System;
using System.Collections.Generic;
using DesingPatterns.Models;
using System.Text;

namespace DesingPatterns.RepositoryPattern
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> GetAllBeers();
        Beer Get(int id);
        void Add(Beer data);
        void Delete(int id);
        void Update(Beer data);
        void Save();
    }
}
