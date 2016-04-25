using System;

namespace Carlister.Common.Data
{
    public interface IDataSource<T> : IDisposable
    {
        T Add(T obj);
        int SaveChanges();
    }
}
