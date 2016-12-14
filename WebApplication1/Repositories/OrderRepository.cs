using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    public class OrderRepository:IRepository<Order>
    {
        private ApplicationDbContext _applicationDbContext;

        public OrderRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Order> GetAll()
        {
            List<Order> cars = _applicationDbContext.Orders.ToList();
            return cars.ToList();
        }

        public Order GetById(int? id)
        {
            return _applicationDbContext.Orders.Find(id);
        }

        public void Create(Order item)
        {
            _applicationDbContext.Orders.Add(item);
        }

        public void Update(Order item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Orders.Find(id) != null)
            {
                _applicationDbContext.Orders.Remove(_applicationDbContext.Orders.Find(id));
            }
        }
    }
}