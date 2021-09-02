using Consult.Domain.Entities;
using Consult.Domain.Infra.Context;
using Consult.Domain.Queries;
using Consult.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

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
            return _context.Consultings.AsNoTracking().Where(ConsultQueries.GetAll(user)).OrderBy(x => x.Date);
        }

        public IEnumerable<Consulting> GetAllByDate(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consulting> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consulting> GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }

        public Consulting GetById(Guid id, string user)
        {
            throw new NotImplementedException();
        }

        public void Update(Consulting consulting)
        {
            _context.Entry(consulting).State = EntityState.Modified;
        }
    }

}