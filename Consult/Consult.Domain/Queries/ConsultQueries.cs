using System;
using System.Linq.Expressions;
using Consult.Domain.Entities;

namespace Consult.Domain.Queries
{
    public static class ConsultQueries
    {
        public static Expression<Func<Consulting, bool>> GetAll(string user)
        {
            return x => x.User == user;
        }

        public static Expression<Func<Consulting, bool>> GetAllDone(string user)
        {
            return x => x.User == user && x.Done == true;
        }

        public static Expression<Func<Consulting, bool>> GetAllUndone(string user)
        {
            return x => x.User == user && x.Done == false;
        }

        public static Expression<Func<Consulting, bool>> GetByPeriod(string user, DateTime date, bool done)
        {
            return x =>
                x.User == user &&
                x.Done == done &&
                x.Date.Date == date.Date;
        }



    }
}