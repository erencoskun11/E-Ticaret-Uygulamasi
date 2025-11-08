using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories.Customers
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context) 
        {

        }
        
            
        
        DbSet<Customer> IRepository<Customer>.Table => throw new NotImplementedException();

        public Task<bool> AddAsync(Customer model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeAsync(List<Customer> model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customer model)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRange(List<Customer> model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
