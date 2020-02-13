using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WeightRecorder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<RecordedWeight> RecordedWeights { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
