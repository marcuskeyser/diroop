using System;
using System.Collections.Generic;
using System.Text;
using ecsCore.Domain.POCO;

namespace ecsCore.Data
{
    public interface IRepository<T>
    {
        void Insert(T item);
        List<T> SelectAll();
        T SelectById(string key);
        void Delete(string Id);
        void Update(T item);
    }
}
