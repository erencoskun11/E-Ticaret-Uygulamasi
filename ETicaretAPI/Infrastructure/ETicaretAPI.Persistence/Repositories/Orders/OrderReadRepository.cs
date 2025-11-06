using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories.Orders
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETicaretAPIDbContext context) : base(context) 
        {
            
        }
        DbSet<Order> IRepository<Order>.Table => throw new NotImplementedException();

        public Task<Order> GetSingleAsync(Expression<Func<Order, bool>> method)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetWhere(Expression<Func<Order, bool>> method)
        {
            throw new NotImplementedException();
        }

        IQueryable<Order> IReadRepository<Order>.GetAll(bool tracking = true)
        {
            throw new NotImplementedException();
        }

        Task<Order> IReadRepository<Order>.GetByIdAsync(string id, bool tracking = true)
        {
            throw new NotImplementedException();
        }
    }
}
