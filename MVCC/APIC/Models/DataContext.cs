using System.Data.Entity;

namespace APIC.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIC.Models.Client> Clients { get; set; }
    }
}