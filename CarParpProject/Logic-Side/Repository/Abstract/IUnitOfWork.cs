using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Side.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
