using DesignPatters.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
{

    public class Repository<TEntity> : IRepostory<TEntity> where TEntity : class
    {
        private DesignPatternsContext _context;

        private DbSet<TEntity> _dbSet;

        public Repository(DesignPatternsContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>(); // Tenemos la inicializacion.
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            _dbSet.Remove(dataToDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(TEntity data)
        {
            _dbSet.Attach(data); // busca el elemento en el contexto y lo marca como modificado.
            _context.Entry(data).State = EntityState.Modified; // Cambia el estado del elemento a modificado.
        }
    }

}
