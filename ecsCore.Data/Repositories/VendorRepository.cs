using System;
using System.Collections.Generic;
using System.Text;
using ecsCore.Domain.POCO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ecsCore.Data.Repositories
{
    public class VendorRepository : IRepository<Vendor>
    {
        private DataContext _context;

        public VendorRepository(DataContext ctx)
        {
            _context = ctx;
        }
        public void Delete(string Id, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public void Insert(Vendor item, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public List<Vendor> SelectAll(HttpBodyHeader request)
        {
            List<Vendor> myVendor;
            try
            {
                myVendor = _context.Vendors
                    .Include(i => i.Entity)
                    .Include(i => i.Entity.Names)
                    .Include(i => i.Entity.Phones)
                    .Include(i => i.Entity.Addresses)
                    .Include(i => i.Entity.Emails)
                    .Include(i => i.Entity.SocialMedia)
                    .ToList();
                return myVendor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Vendor SelectById(string key, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public void Update(Vendor item, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }
    }
}
