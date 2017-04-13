﻿using System;
using System.Collections.Generic;
using System.Text;
using ecsCore.Domain.POCO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ecsCore.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private DataContext _context;

        public CustomerRepository(DataContext ctx)
        {
            _context = ctx;
        }
        public void Delete(string Id, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer item, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public List<Customer> SelectAll(HttpBodyHeader request)
        {
            List<Customer> myCustomer;
            try
            {
                myCustomer = _context.Customers
                    .Include(i=>i.Entity)
                    .Include(i => i.Entity.Names)
                    .Include(i => i.Entity.Phones)
                    .Include(i => i.Entity.Addresses)
                    .Include(i => i.Entity.Emails)
                    .Include(i => i.Entity.SocialMedia)
                    .ToList();
                return myCustomer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Customer SelectById(string key, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity item, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item, HttpBodyHeader request)
        {
            throw new NotImplementedException();
        }
    }
}