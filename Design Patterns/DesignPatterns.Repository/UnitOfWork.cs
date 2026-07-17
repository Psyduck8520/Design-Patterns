using DesignPatters.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DesignPatternsContext _context;

        public IRepostory<Beer> _beers;  // aki tenemos los atributos
        public IRepostory<Brand> _brand;

        public IRepostory<Beer> Beers
        {
            get
            {
                return _beers == null ? _beers = new Repository<Beer>(_context) : // no existe crealo
                       _beers;// si existe devuelvelo
            }
        }

        public IRepostory<Brand> Brands
        {
            get
            {
                return _brand == null ? _brand = new Repository<Brand>(_context) : // no existe crealo
                       _brand;// si existe devuelvelo
            }
        }

        public UnitOfWork(DesignPatternsContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
