using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StoreBackend.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseMySql(
                "server=localhost;port=3306;database=store_system;user=root;password=root;",
                ServerVersion.AutoDetect(
                    "server=localhost;port=3306;database=store_system;user=root;password=root;"
                )
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}