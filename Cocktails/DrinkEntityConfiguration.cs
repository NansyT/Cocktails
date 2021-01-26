using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class DrinkEntityConfiguration : EntityTypeConfiguration<Drink>
    {
        public DrinkEntityConfiguration()
        {
            this.Property(p => p.DrinkID).IsRequired();
            this.Property(p => p.Name).IsRequired();
        }
    }
}
