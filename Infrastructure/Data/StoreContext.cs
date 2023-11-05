

using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data
{
    public class StoreContext : DbContext //Basically a session to the database
    {
            
        //Base(...) is just super in java
        public StoreContext(DbContextOptions<StoreContext> options) : base(options){
            
        }

        public DbSet<Product> Products { get; set; }
        

            
    }
}