using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPlane.Domain.Entities;
namespace AirPlane.Domain.Concrete
{
  public  class EFDbContext:DbContext
    {
        public DbSet<Aircraft> AirCrafts { get; set; }
        public DbSet<Airline> AirLines { get; set; }
        public DbSet<Student> Students { get; set; }

        public EFDbContext()
        {
            var t = this.Database.Connection.DataSource;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         /*   modelBuilder.Entity<Aircraft>()
                .HasRequired(p => p.FullImage)
                .WithRequiredPrincipal(p => p.Aircraft);*/
          //  modelBuilder.Entity<Aircraft>().ToTable
                
            /*modelBuilder.Entity<Aircraft>()
                .Map(m =>
                {
                    m.Properties(p => new { p.AircraftID, p.Name, p.Type });
                    m.ToTable("AirPlane", "Planes");
                })
                 .Map(m =>
                 {
                     m.Properties(p => new { p.AircraftID, p.ImageURl, p.ThumbnailBits, p.Category });
                     m.ToTable("AirPlaneDetailes", "Planes");
                 });*/
        }

        public System.Data.Entity.DbSet<AirPlane.Domain.Entities.PhotoFullImage> PhotoFullImages { get; set; }

        public System.Data.Entity.DbSet<AirPlane.Domain.Entities.StudentAddress> StudentAddresses { get; set; }
    }
}
