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
    }
}
