﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServicePattern
{
    public interface IService<T> : IDisposable where T:class
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> where);
        T GetById(long id);
        T GetById(string id);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null,
            Expression<Func<T, bool>> orderBy = null);
        void Commit();
      
    }
}
