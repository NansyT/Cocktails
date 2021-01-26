using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class CocktailsContext : DbContext
    {
        public CocktailsContext() : base()
        {
            Database.SetInitializer(new CocktailDBInitializer());

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IngredientEntityConfiguration());
            modelBuilder.Configurations.Add(new DrinkEntityConfiguration());


            modelBuilder.Types().Configure(t => t.MapToStoredProcedures());
            
        }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
