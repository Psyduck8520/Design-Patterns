using DesignPatters.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
{
    public interface IUnitOfWork
    {
        public IRepostory<Beer> Beers { get; }

        public IRepostory<Brand> Brand { get; }

        public void Save();
    }
}
