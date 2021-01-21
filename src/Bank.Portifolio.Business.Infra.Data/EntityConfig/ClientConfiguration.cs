using Bank.Portifolio.Bussines.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Bank.Portifolio.Business.Infra.Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.IdClient);

            Property(c => c.NameClient).IsRequired().HasMaxLength(150);

            Property(c => c.SectorClient).IsRequired().HasMaxLength(50);

            Property(c => c.PhoneClient).IsRequired().HasMaxLength(20);

            Property(c => c.CellClient).IsRequired().HasMaxLength(20);

            Property(c => c.DateRegister).IsRequired();

            Property(c => c.DateUpdate);
        }
    }
}
