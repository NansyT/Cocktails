using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class DatabaseManager
    {

        public void CreateDrink(string name, List<Ingredient> ingredients)
        {
            using (var ctx = new CocktailsContext())
            {
                ctx.Database.CreateIfNotExists();
                Drink drink = new Drink(name, ingredients);
                ctx.Drinks.Add(drink);
                ctx.SaveChanges();
            }
        }
        public void ModifyDrink(int drinkID, string name, List<Ingredient> ingredients)
        {
            using (var ctx = new CocktailsContext())
            {
                ctx.Database.CreateIfNotExists();
                Drink temp = new Drink(drinkID, name, ingredients);
                ctx.Drinks.SqlQuery("Drink_Update", temp);
            }
        }
        public void DeleteDrink(int drinkID)
        {
            using (var ctx = new CocktailsContext())
            {
                ctx.Database.CreateIfNotExists();
                Drink drink = ctx.Drinks.Find(drinkID);

                ctx.Drinks.Remove(drink);
                ctx.SaveChanges();
            }
        }
        public List<Drink> GetDrinks()
        {
            using (var ctx = new CocktailsContext())
            {
                ctx.Database.CreateIfNotExists();
                var temp = ctx.Drinks.Where(p => p.DrinkID >= 0);
                List<Drink> drinks = new List<Drink>();
                foreach (var item in temp)
                {
                    drinks.Add(item);
                }
                return drinks;
            }
        }
        public List<Drink> SearchDrinks(string search)
        {
            using (var ctx = new CocktailsContext())
            {
                ctx.Database.CreateIfNotExists();
                var temp = ctx.Drinks.Where(p => p.Name.Contains(search));
                List<Drink> drinks = new List<Drink>();
                foreach (var item in temp)
                {
                    drinks.Add(item);
                }
                return drinks;
            }
        }
        public Drink GetDrink(int drinkID)
        {
            using (var ctx = new CocktailsContext())
            {
                ctx.Database.CreateIfNotExists();

                return new Drink("Temp", new List<Ingredient>() { new Ingredient("dd", "dd") });
            }
        }
    }
}
