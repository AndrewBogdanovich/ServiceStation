using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    public class DetailRepository:IRepository<Detail>
    {
        private ApplicationDbContext _applicationDbContext;

        public DetailRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Detail> GetAll()
        {
            List<Detail> Details = _applicationDbContext.Details.ToList();
            return Details.ToList();
        }

        public Detail GetById(int? id)
        {
            return _applicationDbContext.Details.Find(id);
        }

        public void Create(Detail item)
        {
            _applicationDbContext.Details.Add(item);
        }

        public void Update(Detail item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Details.Find(id) != null)
            {
                _applicationDbContext.Details.Remove(_applicationDbContext.Details.Find(id));
            }
        }
    }
}