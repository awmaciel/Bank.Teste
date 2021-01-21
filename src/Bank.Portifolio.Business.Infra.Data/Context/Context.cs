using Bank.Portifolio.Business.Infra.Data.EntityConfig;
using Bank.Portifolio.Bussines.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Bank.Portifolio.Business.Infra.Data.Context
{
    public class Context : DbContext
    {
        public Context()
            :base("DefaultConnection")
        {
                
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Bank.Portifolio.Bussines.Domain.Entities.Portifolio> Portifolios { get; set; }
        public DbSet<Bank.Portifolio.Bussines.Domain.Entities.Business> Businesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new BusinessConfiguration());
            modelBuilder.Configurations.Add(new PortifolioConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateRegister") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateRegister").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateUpdate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
