using Microsoft.EntityFrameworkCore;


namespace MyLeasing.Web.Data.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>Options)
            :base(Options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Contract> contracts { get; set; }
        public DbSet<Lessee> lessees { get; set; }
        public DbSet<Property> properties { get; set; }
        public DbSet<PropertyImage> propertyImages { get; set; }
        public DbSet<PropertyType> propertyTypes { get; set; }
    }
}
