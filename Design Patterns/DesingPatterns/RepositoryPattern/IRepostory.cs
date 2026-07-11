using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DesingPatterns.RepositoryPattern
{
     public interface IRepostory<TEntity>
    {
        IEnumerable<TEntity> Get(); 
        TEntity Get(int id);
        void Add(TEntity data);
        void Delete(int id);
        void Update(TEntity data);
        void Save();
    }
}
