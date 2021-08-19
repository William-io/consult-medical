using Consult.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consult.Domain.Infra.Context
{
    public class ConsultContext : DbContext
    {
        public ConsultContext(DbContextOptions<ConsultContext> options) : base(options) { }

        public DbSet<Consulting> Consultings { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ConsultContext).Assembly);
        }
    }
}
