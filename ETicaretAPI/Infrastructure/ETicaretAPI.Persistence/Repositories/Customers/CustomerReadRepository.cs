using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories.Customers
{
    public class CustomerReadRepository : ReadRepository<Customer>,ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context) { }
        
            
        
        public DbSet<Domain.Entities.Customer> Table => throw new NotImplementedException();

        public IQueryable<Domain.Entities.Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Customer> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Customer> GetSingleAsync(Expression<Func<Domain.Entities.Customer, bool>> method)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Domain.Entities.Customer> GetWhere(Expression<Func<Domain.Entities.Customer, bool>> method)
        {
            throw new NotImplementedException();
        }
    }
}
