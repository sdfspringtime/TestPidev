﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
        void Dispose();
        IRepositoryBase<T> getRepository<T>() where T: class;
    }
}
