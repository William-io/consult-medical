using System;
using Consult.Domain.Entities;
using Consult.Domain.Repositories;

namespace Consult.Domain.Tests.Repositories
{
    public class FakeConsultRepository : IConsultRepository
    {
        public void Create(Consulting consulting) { }

        public Consulting GetById(Guid id, string user)
        {
            return new Consulting("Consulta Pediatrica", "williamgsilva", DateTime.Now);
        }

        public void Update(Consulting consulting) { }
    }

}