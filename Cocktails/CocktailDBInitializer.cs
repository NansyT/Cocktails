using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class CocktailDBInitializer : DropCreateDatabaseAlways<CocktailsContext>
    {
        protected override void Seed(CocktailsContext context)
        {
            IList<Drink> defaultDrinks = new List<Drink>();
            defaultDrinks.Add(new Drink("Margarita", new List<Ingredient>() { new Ingredient("Lime Juice", "60 ml"), new Ingredient("Triple Sec", "30 ml"), new Ingredient("Tequila", "60 ml"), new Ingredient("Salt rim", "Nok"), new Ingredient("Crushed Ice", "En smule"), new Ingredient("Lime Segment", "1") }));
            defaultDrinks.Add(new Drink("Screwdriver", new List<Ingredient>() { new Ingredient("Orange Juice", "135 ml"), new Ingredient("Vodka", "45 ml") }));
            defaultDrinks.Add(new Drink("Martini", new List<Ingredient>() { new Ingredient("French Dry Vermouth", "25 ml"), new Ingredient("Gin", "45 ml"), new Ingredient("Olive", "1") }));

            context.Drinks.AddRange(defaultDrinks);
            foreach (var item in defaultDrinks)
            { 
                context.Ingredients.AddRange(item.Ingredients);
                
            }

            base.Seed(context);
        }
    }
}
