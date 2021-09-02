using System;
using Consult.Domain.Entities;

namespace Consult.Domain.Repositories
{
    public interface IConsultRepository
    {
        void Create(Consulting consulting);
        void Update(Consulting consulting);

        Consulting GetById(Guid id, string user);


        //Queries
        IEnumerable<Consulting> GetAll(string user);
        IEnumerable<Consulting> GetAllDone(string user);
        IEnumerable<Consulting> GetAllUndone(string user);
        IEnumerable<Consulting> GetAllByDate(string user, DateTime date, bool done);

    }

}