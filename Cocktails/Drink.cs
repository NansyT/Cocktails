using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Drink
    {
        private int drinkID;

        public int DrinkID
        {
            get { return drinkID; }
            private set { drinkID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private List<Ingredient> ingredients;

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            private set { ingredients = value; }
        }

        public Drink(int drinkID, string name, List<Ingredient> ingredients)
        {
            DrinkID = drinkID;
            Name = name;
            Ingredients = ingredients;
        }

        public Drink(string name, List<Ingredient> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
        public Drink() { }
    }
}
