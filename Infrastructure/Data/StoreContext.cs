

using System.Reflection;
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

        public DbSet<ProductBrand> ProductBrands {get; set;}

        public DbSet<ProductType> ProductTypes {get; set;}


        //Allowing our configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //i think the idea is that we can keep adding more entities here like "Products"
        

            
    }
}