using Consult.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Consult.Domain.Infra.Settings
{
    public class ConsultSettings : IEntityTypeConfiguration<Consulting>
    {
        public void Configure(EntityTypeBuilder<Consulting> builder)
        {

            builder.ToTable("Consulting");
            builder.Property(x => x.Id); //Primary Key 
            builder.Property(x => x.Description).HasMaxLength(255).HasColumnType("varchar(160)");
            builder.Property(x => x.User).HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Done).HasColumnType("bit");
            builder.Property(x => x.Date);
            builder.HasIndex(b => b.User);

        }
    }

}