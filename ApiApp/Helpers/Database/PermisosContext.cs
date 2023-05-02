using Microsoft.EntityFrameworkCore;
using ApiApp.Models;

namespace ApiApp.Helpers.Database
{
    public class PermisosContext : DbContext
    {
        public PermisosContext(DbContextOptions<PermisosContext> options) : base(options)
        {
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().ToTable("Permissions");
            modelBuilder.Entity<PermissionType>().ToTable("PermissionTypes");

            modelBuilder.Entity<PermissionType>().HasData(new PermissionType
            {
                ID = 1,
                Description = "Enfermedad"
            }, new PermissionType
            {
                ID = 2,
                Description = "Diligencias"
            }, new PermissionType
            {
                ID = 3,
                Description = "Otros"
            }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=permisos.db");
        }
    }
}