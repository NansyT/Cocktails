using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Ingredient
    {
        private int ingredientID;

        public int IngredientID
        {
            get { return ingredientID; }
            private set { ingredientID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private string amount;

        public string Amount
        {
            get { return amount; }
            private set { amount = value; }
        }
        
        public Ingredient(int ingredientID, string name, string amount)
        {
            IngredientID = ingredientID;
            Name = name;
            Amount = amount;
        }
        public Ingredient(string name, string amount)
        {
            Name = name;
            Amount = amount;
        }
        public Ingredient() { }
    }
}
