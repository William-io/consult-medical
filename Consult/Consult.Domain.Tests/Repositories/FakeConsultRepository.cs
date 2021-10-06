using System;
using System.Collections.Generic;
using Consult.Domain.Entities;
using Consult.Domain.Repositories;

namespace Consult.Domain.Tests.Repositories
{
    public class FakeConsultRepository : IConsultRepository
    {
        public void Create(Consulting consulting) { }

        public IEnumerable<Consulting> GetAll(string user)
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
            return new Consulting("Consulta Pediatrica", "williamgsilva", DateTime.Now);
        }

        public IEnumerable<Consulting> GetByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public void Update(Consulting consulting) { }
    }

}