using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // DbContext, DbSet, DbContextOptions ve ModelBuilder için şart
using Core.Entities; // Project vb. Entity sınıflarınız hangi projede/namespace'te ise onu ekleyin


namespace DataAccess.Context
{
    public class PortfolioContext : DbContext
    {
        // Program.cs'deki options yapılandırmasını kurucu metoda alıyoruz
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {
        }

        // Tablo haline gelmesini istediğiniz veri modelleriniz (DbSet)
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Gerekirse Fluent API ile özel tablo/alan konfigürasyonlarını burada yapabilirsiniz:
            // modelBuilder.Entity<Biography>().Property(b => b.Content).IsRequired();
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
{
    var entries = ChangeTracker.Entries();

    foreach (var entry in entries)
    {
        // Eğer eklenen veya güncellenen sınıfta CreatedAt/UpdatedAt property'si varsa otomatik doldurur
        if (entry.State == EntityState.Added)
        {
            var createdProp = entry.Entity.GetType().GetProperty("CreatedAt");
            if (createdProp != null)
                createdProp.SetValue(entry.Entity, DateTime.UtcNow);
        }
        else if (entry.State == EntityState.Modified)
        {
            var updatedProp = entry.Entity.GetType().GetProperty("UpdatedAt");
            if (updatedProp != null)
                updatedProp.SetValue(entry.Entity, DateTime.UtcNow);
        }
    }

    return base.SaveChangesAsync(cancellationToken);
}
    }
}