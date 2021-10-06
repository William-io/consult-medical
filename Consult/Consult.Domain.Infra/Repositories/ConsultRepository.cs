using Consult.Domain.Entities;
using Consult.Domain.Infra.Context;
using Consult.Domain.Queries;
using Consult.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consult.Domain.Infra.Repositories
{
    public class ConsultRepository : IConsultRepository
    {
        private readonly ConsultContext _context;

        public ConsultRepository(ConsultContext context)
        {
            _context = context;
        }

        public void Create(Consulting consulting)
        {
            _context.Consultings.Add(consulting);
            _context.SaveChanges();
        }

        public IEnumerable<Consulting> GetAll(string user)
        {
            return _context.Consultings
            .AsNoTracking()
            .Where(ConsultQueries.GetAll(user))
            .OrderBy(x => x.Date);
        }

        public IEnumerable<Consulting> GetAllDone(string user)
        {
            return _context.Consultings
            .AsNoTracking()
            .Where(ConsultQueries.GetAllDone(user))
            .OrderBy(x => x.Date);
        }

        public IEnumerable<Consulting> GetAllUndone(string user)
        {
            return _context.Consultings
            .AsNoTracking()
            .Where(ConsultQueries.GetAllUndone(user))
            .OrderBy(x => x.Date);
        }

        public Consulting GetById(Guid id, string user)
        {
            return _context
            .Consultings
            .FirstOrDefault(x => x.Id == id && x.User == user);
        }

        public IEnumerable<Consulting> GetByPeriod(string user, DateTime date, bool done)
        {
            return _context.Consultings
            .AsNoTracking()
            .Where(ConsultQueries.GetByPeriod(user, date, done))
            .OrderBy(x => x.Date);
        }

        public void Update(Consulting consulting)
        {
            _context.Entry(consulting).State = EntityState.Modified;
        }
    }

}