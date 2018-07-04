namespace WebSiteAboutMe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContentModels : DbContext
    {
        public DbContentModels()
            : base("name=DbContentModels")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Entry> Entry { get; set; }
        public virtual DbSet<EntryType> EntryType { get; set; }
        public virtual DbSet<RoleAccess> RoleAccess { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Entry)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entry>()
                .HasMany(e => e.Entry1)
                .WithOptional(e => e.Entry2)
                .HasForeignKey(e => e.EntryID);

            modelBuilder.Entity<EntryType>()
                .HasMany(e => e.Entry)
                .WithRequired(e => e.EntryType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EntryType>()
                .HasMany(e => e.RoleAccess)
                .WithRequired(e => e.EntryType)
                .WillCascadeOnDelete(false);
        }
    }
}
