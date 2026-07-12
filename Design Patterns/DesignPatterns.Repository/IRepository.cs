using DesignPatters.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
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
