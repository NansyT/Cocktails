using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class DrinkManager
    {
        private DatabaseManager dbManager = new DatabaseManager();
        public void CreateDrink(string name, List<Ingredient> ingredients)
        {
            dbManager.CreateDrink(name, ingredients);
        }
        public void ModifyDrink(int drinkID, string name, List<Ingredient> ingredients)
        {
            dbManager.ModifyDrink(drinkID, name, ingredients);
        }
        public void DeleteDrink(int drinkID)
        {
            dbManager.DeleteDrink(drinkID);
        }
        public List<Drink> GetDrinks()
        {
            return dbManager.GetDrinks();
        }
        public List<Drink> SearchDrinks(string search)
        {
            return dbManager.SearchDrinks(search);
        }
        public Drink GetDrink(int drinkID)
        {
            return dbManager.GetDrink(drinkID);
        }
    }
}
