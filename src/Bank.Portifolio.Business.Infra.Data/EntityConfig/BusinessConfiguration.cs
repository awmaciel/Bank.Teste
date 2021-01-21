using System.Data.Entity.ModelConfiguration;

namespace Bank.Portifolio.Business.Infra.Data.EntityConfig
{
    public class BusinessConfiguration : EntityTypeConfiguration<Bank.Portifolio.Bussines.Domain.Entities.Business>
    {
        public BusinessConfiguration()
        {
            HasKey(c => c.IdBusiness);

            Property(c => c.IdCategory).IsRequired();

            Property(c => c.IdClient).IsRequired();

            Property(c => c.IdPortifolio).IsRequired();

            Property(c => c.TypeBusiness).IsRequired();

            Property(c => c.DateRegister).IsRequired();

            Property(c => c.DateUpdate);


            HasRequired(p => p.CategoryBusiness).WithMany().HasForeignKey(p => p.IdCategory);
            HasRequired(p => p.ClientBusiness).WithMany().HasForeignKey(p => p.IdClient);
            HasRequired(p => p.PortifolioBusiness).WithMany().HasForeignKey(p => p.IdPortifolio);
        }
    }
}
