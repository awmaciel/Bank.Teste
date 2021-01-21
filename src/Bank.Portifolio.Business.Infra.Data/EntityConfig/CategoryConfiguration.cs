using Bank.Portifolio.Bussines.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Bank.Portifolio.Business.Infra.Data.EntityConfig
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            HasKey(c => c.IdCategory);

            Property(c => c.NameCategory).IsRequired().HasMaxLength(150);

            Property(c => c.DateRegister).IsRequired();

            Property(c => c.DateUpdate);
        }
    }
}
