using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Models.Entities;

namespace Webapplication1.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        private ApplicationDbContext _applicationDbContext;

        public CarRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Car> GetAll()
        {
            List<Car> cars = _applicationDbContext.Cars.ToList();
            return cars.ToList();
        }

        public Car GetById(int? id)
        {
            return _applicationDbContext.Cars.Find(id);
        }

        public void Create(Car item)
        {
            _applicationDbContext.Cars.Add(item);
        }

        public void Update(Car item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Cars.Find(id) != null)
            {
                _applicationDbContext.Cars.Remove(_applicationDbContext.Cars.Find(id));
            }
        }
    }
}