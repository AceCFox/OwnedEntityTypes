namespace OwnedEntityTypes.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        { 
        }

        public DbSet<Cat> Cats { get; set; }
    }
}
