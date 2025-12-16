using Microsoft.EntityFrameworkCore;

namespace ProjectNumber1.Models
{
    public class ProContext:DbContext
    {
        public DbSet<Employee> Employee { get;set; }
        public DbSet<Departement> Departement { get; set; }


        public ProContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Assuit_DotNet_Q3;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
