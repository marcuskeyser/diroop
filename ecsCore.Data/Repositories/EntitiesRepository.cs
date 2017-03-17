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
                        .Include("Names")
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
