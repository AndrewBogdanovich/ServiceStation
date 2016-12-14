using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    public class MarkRepository : IRepository<Mark>
    {
        private ApplicationDbContext _applicationDbContext;

        public MarkRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Mark> GetAll()
        {
            List<Mark> Marks = _applicationDbContext.Marks.ToList();
            return Marks.ToList();
        }

        public Mark GetById(int? id)
        {
            return _applicationDbContext.Marks.Find(id);
        }

        public void Create(Mark item)
        {
            _applicationDbContext.Marks.Add(item);
        }

        public void Update(Mark item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Marks.Find(id) != null)
            {
                _applicationDbContext.Marks.Remove(_applicationDbContext.Marks.Find(id));
            }
        }
    }
}