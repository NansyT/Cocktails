using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace Cocktails
{
    class IngredientEntityConfiguration : EntityTypeConfiguration<Ingredient>
    {
        public IngredientEntityConfiguration()
        {
            this.Property(p => p.IngredientID).IsRequired();
            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.Amount).IsRequired();
        }
    }
}
