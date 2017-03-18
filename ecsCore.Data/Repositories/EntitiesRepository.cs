using System;
using System.Collections.Generic;
using System.Text;
using ecsCore.Domain.POCO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ecsCore.Data.Repositories
{
    public class EntitiesRepository : IRepository<Entity>
    {
        public void Insert(Entity item)
        {
            throw new NotImplementedException();
        }

        public Entity SelectById(string key)
        {
            throw new NotImplementedException();
        }

        public List<Entity> SelectAll()
        {
            List<Entity> myEntity;
            try
            {
                using (var ctx = new DataContext())
                {
                    myEntity = ctx.Entities
                        .Include(i => i.Names)
                        .Include(i => i.Phones)
                        .Include(i => i.Addresses)
                        .Include(i => i.Emails)
                        .Include(i => i.SocialMedia)
                        .ToList();
                    return myEntity;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity item)
        {
            throw new NotImplementedException();
        }
    }
}

/*
 *     public static IQueryable<T> Include<T>(this IQueryable<T> query, params string[] navProperties)
        where T : class
    {
        foreach (var navProperty in navProperties)
            query = query.Include(navProperty);

        return query;
    }

            And use it like this even in a generic implementation:

            string[] includedNavigationProperties = new string[] { "NavProp1.SubNavProp", "NavProp2" };

            var query = context.Set<T>()
            .Include(includedNavigationProperties);
 * */
