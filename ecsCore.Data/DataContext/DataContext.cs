using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ecsCore.Domain.POCO;
using ecsCore.System;

namespace ecsCore.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityAddress> EntityAddresses { get; set; }
        public DbSet<EntityCreditCard> EntityCreditCards { get; set; }
        public DbSet<EntityEmail> EntityEmails { get; set; }
        public DbSet<EntityName> EntityNames { get; set; }
        public DbSet<EntityPhone> EntityPhone { get; set; }
        public DbSet<EntityRelationship> EntityRelationships { get; set; }
        public DbSet<EntitySocialMedia> EntitySocialMedia { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<_Base>().Property(p => p.Guid).HasDefaultValue(Guid.NewGuid());
        //    modelBuilder.Entity<_Base>().Property(p => p.IsDeleted).HasDefaultValue(0);
        //    modelBuilder.Entity<_Base>().Property(p => p.CreateDate).HasDefaultValue(DateTime.Now);
        //    modelBuilder.Entity<_Base>().Property(p => p.LastEditDate).HasDefaultValue(DateTime.Now);
        //    modelBuilder.Entity<_Base>().Property(p => p.SystemOwnerID).HasDefaultValue(0);

        //    modelBuilder.Entity<_Meta>().Property(p => p.IsDefault).HasDefaultValue(0);
        //    modelBuilder.Entity<_Meta>().Property(p => p.IsDeleted).HasDefaultValue(0);
        //    modelBuilder.Entity<_Meta>().Property(p => p.IsLocked).HasDefaultValue(0);
        //    modelBuilder.Entity<_Meta>().Property(p => p.IsPrimary).HasDefaultValue(0);
        //    modelBuilder.Entity<_Meta>().Property(p => p.SortOrder).HasDefaultValue(0);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<SamuraiBattle>()
        //      .HasKey(s => new { s.BattleId, s.SamuraiId });

        //    foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        //    {
        //        modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModified");
        //        modelBuilder.Entity(entityType.Name).Ignore("IsDirty");
        //    }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = ecsCoreDB; Trusted_Connection = True; ",
              options => options.MaxBatchSize(30));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
             .Where(e => e.State == EntityState.Added ||
                         e.State == EntityState.Modified))
            {
                entry.Property("LastEditDate").CurrentValue = DateTime.Now;
                entry.Property("LastEditUserId").CurrentValue = System.Constants.USER_ID;
            }
            return base.SaveChanges();
        }
    }
}