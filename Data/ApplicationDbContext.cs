using Microsoft.EntityFrameworkCore;
using VarPlugApi.Model;

namespace VarPlugApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<VarPlugApi.Model.Faculty>? Faculty { get; set; }
        public DbSet<VarPlugApi.Model.University>? universities { get; set; }

        public DbSet<VarPlugApi.Model.Province>? province { get; set; }

        public DbSet<VarPlugApi.Model.Career>? career { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CareerUniverities>()
                .HasKey(cu => new { cu.CareerId, cu.UniversityId });

            modelBuilder.Entity<CareerUniverities>()
                .HasOne(cu => cu.Career)
                .WithMany(c => c.CareerUniversities)
                .HasForeignKey(cu => cu.CareerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CareerUniverities>()
                .HasOne(cu => cu.University)
                .WithMany(u => u.careerUniverities)
                .HasForeignKey(cu => cu.UniversityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Faculty>()
                .HasOne(f => f.university)
                .WithMany(u => u.OfferedFaculties)
                .HasForeignKey(f => f.UniversityId)
                .OnDelete(DeleteBehavior.Restrict);

            // Define the many-to-many relationship between Faculty and Career using an explicit join entity
            modelBuilder.Entity<Faculty>()
       .HasMany(f => f.Careers)
       .WithMany(c => c.faculties)
       .UsingEntity<CareerFaculty>(
           j => j
               .HasOne(cf => cf.Career)
               .WithMany(c => c.careerFaculties)
               .HasForeignKey(cf => cf.CareerId),
           j => j
               .HasOne(cf => cf.Faculty)
               .WithMany(f => f.careerFaculties)
               .HasForeignKey(cf => cf.FacultyId)
               );
        }
    }
}
