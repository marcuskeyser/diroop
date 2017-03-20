using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;

namespace ecsCore.Data.Repositories
{
    public static class Utilities
    {
        public static Expression<Func<T, bool>> BuildLamdbaForFindByKey<T>(int value, string key = "Id")
        {
            var item = Expression.Parameter(typeof(T), "entity");
            var prop = Expression.Property(item, key);
            var val = Expression.Constant(value);
            var equal = Expression.Equal(prop, val);
            var lambda = Expression.Lambda<Func<T, bool>>(equal, item);
            return lambda;
        }
        //Expression.Lambda(equal,item)
    }
}
