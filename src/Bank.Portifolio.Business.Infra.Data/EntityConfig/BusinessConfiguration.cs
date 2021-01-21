using System.Data.Entity.ModelConfiguration;

namespace Bank.Portifolio.Business.Infra.Data.EntityConfig
{
    public class BusinessConfiguration : EntityTypeConfiguration<Bank.Portifolio.Bussines.Domain.Entities.Business>
    {
        public BusinessConfiguration()
        {
            HasKey(c => c.IdBusiness);

            Property(c => c.IdCategory);

            Property(c => c.IdClient);

            Property(c => c.IdPortifolio);

            Property(c => c.TypeBusiness);

            Property(c => c.ValueBusiness);

            Property(c => c.DateRegister).IsRequired();

            Property(c => c.DateUpdate);


            HasRequired(p => p.Category).WithMany().HasForeignKey(p => p.IdCategory);
            HasRequired(p => p.Client).WithMany().HasForeignKey(p => p.IdClient);
            HasRequired(p => p.Portifolio).WithMany().HasForeignKey(p => p.IdPortifolio);
        }
    }
}
