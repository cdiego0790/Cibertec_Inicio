using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;
using System.Data.Entity;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("name=webDeveloperConnectionString")
        {

        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
