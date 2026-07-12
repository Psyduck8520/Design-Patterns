using DesingPatterns.Models;
using DesingPatterns.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {
        public IRepostory<Beer> Beers { get; }
        
        public IRepostory<Brand> Brand { get; }

        public void Save();
    }

}
