using System.Data.Entity.ModelConfiguration;

namespace Bank.Portifolio.Business.Infra.Data.EntityConfig
{
    public class PortifolioConfiguration : EntityTypeConfiguration<Bank.Portifolio.Bussines.Domain.Entities.Portifolio>
    {
        public PortifolioConfiguration()
        {
            HasKey(c => c.IdPortifolio);

            Property(c => c.NameProtifolio)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.DateRegister)
                .IsRequired();

            Property(c => c.DateUpdate);
        }
    }
}
