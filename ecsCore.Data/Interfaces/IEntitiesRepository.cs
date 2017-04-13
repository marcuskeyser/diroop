using System;
using System.Collections.Generic;
using System.Text;
using ecsCore.Domain.POCO;

namespace ecsCore.Data
{
    public interface IRepository<T>
    {
        void Insert(T item, HttpBodyHeader request);
        List<T> SelectAll(HttpBodyHeader request);
        T SelectById(string key, HttpBodyHeader request);
        void Delete(string Id, HttpBodyHeader request);
        void Update(T item, HttpBodyHeader request);
    }
}
