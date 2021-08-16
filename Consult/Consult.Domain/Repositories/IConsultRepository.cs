using System;
using Consult.Domain.Entities;

namespace Consult.Domain.Repositories
{
    public interface IConsultRepository
    {   
        void Create(Consulting consulting);
        void Update(Consulting consulting);

        Consulting GetById(Guid id, string user);        

    }
    
}