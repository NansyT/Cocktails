using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkManager manager = new DrinkManager();
            string name, answer = "ja";
            List<Ingredient> ingredients;
            List<Drink> drinks;
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("Velkommen, hvad vil du?\n" +
                    "1. Lav en drink\n" +
                    "2. Ændre en drink\n" +
                    "3. Slette en drink\n" +
                    "4. Se alle drinks\n" +
                    "5. Søg efter en drink\n" +
                    "6. Afslut program");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Hvad vil du kalde din drink? Fx. Total Lækker Drink");
                        name = Console.ReadLine();
                        ingredients = new List<Ingredient>();
                        while (answer == "ja" || answer == "Ja")
                        {
                            Console.Clear();
                            Console.WriteLine("Tilføj ingrediens:");
                            Console.WriteLine("Ingrediensens navn. Fx Vodka");
                            string ingName = Console.ReadLine();
                            Console.WriteLine("Hvor meget/mange vil du tilføje? Fx. 250 ml");
                            string ingAmount = Console.ReadLine();
                            ingredients.Add(new Ingredient(ingName, ingAmount));
                            Console.WriteLine("Vil du tilføje flere ingredienser? ja/nej");
                            answer = Console.ReadLine();
                        }
                        manager.CreateDrink(name, ingredients);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Arbejder");
                        answer = "ja";
                        while (answer == "ja" || answer == "Ja")
                        {
                            drinks = manager.GetDrinks();
                            foreach (var item in drinks)
                            {
                                Console.WriteLine(item.DrinkID + ". " + item.Name);
                            }
                            

                            Console.WriteLine("Hvilken drink vil du ændre? Skriv tallet der er udfor drinken og tryk enter");
                            int drinkToMod = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Drink temp = manager.GetDrink(drinkToMod);
                            Console.WriteLine("Vil du ændre navnet? ja/nej");
                            answer = Console.ReadLine();
                            if (answer == "ja" || answer == "Ja")
                            {
                                Console.WriteLine("Intast det nye navn");
                                name = Console.ReadLine();
                            }
                            else
                            {
                                name = temp.Name;
                            }
                            Console.WriteLine("Vil du ændre ingredienser? ja/nej");
                            answer = Console.ReadLine();
                            if (answer == "ja" || answer == "Ja")
                            {
                                ingredients = temp.Ingredients;
                                Console.WriteLine("Vil du slette nogle ingredienser? ja/nej");
                                answer = Console.ReadLine();
                                while (answer == "ja" || answer == "Ja")
                                {
                                    int tempNumb = 0;
                                    foreach (var item in ingredients)
                                    {
                                        Console.WriteLine(tempNumb + ". " + item.Name);
                                        tempNumb++;
                                    }
                                    Console.Clear();
                                    Console.WriteLine("Skriv tallet udfor den ingrediens du vil slette");
                                    int ingToDel = int.Parse(Console.ReadLine());
                                    ingredients.RemoveAt(ingToDel);
                                    Console.WriteLine("Vil du slette flere ingredienser? ja/nej");
                                    answer = Console.ReadLine();
                                }

                                Console.WriteLine("Vil du tilføje ingredienser? ja/nej");
                                answer = Console.ReadLine();

                                while (answer == "ja" || answer == "Ja")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Tilføj ingrediens:");
                                    Console.WriteLine("Ingrediensens navn. Fx Vodka");
                                    string ingName = Console.ReadLine();
                                    Console.WriteLine("Hvor meget/mange vil du tilføje? Fx. 250 ml");
                                    string ingAmount = Console.ReadLine();
                                    ingredients.Add(new Ingredient(ingName, ingAmount));
                                    Console.WriteLine("Vil du tilføje flere ingredienser? ja/nej");
                                    answer = Console.ReadLine();
                                }
                            }
                            else
                            {
                                ingredients = temp.Ingredients;
                            }
                            manager.ModifyDrink(temp.DrinkID, name, ingredients);
                            Console.WriteLine("Vil du ændre flere drinks? ja/nej");
                            answer = Console.ReadLine();
                        }

                        break;
                    case 3:
                        Console.Clear();
                        answer = "ja";
                        while (answer == "ja" || answer == "Ja")
                        {
                            drinks = manager.GetDrinks();
                            foreach (var item in drinks)
                            {
                                Console.WriteLine(item.DrinkID + ". " + item.Name);
                            }
                            
                            Console.WriteLine("Hvilken drink vil du slette? Skriv tallet der er udfor drinken og tryk enter");
                            int drinkToDel = int.Parse(Console.ReadLine());
                            manager.DeleteDrink(drinkToDel);
                            Console.WriteLine("Vil du ændre flere drinks? ja/nej");
                            answer = Console.ReadLine();
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Arbejder...");
                        drinks = manager.GetDrinks();
                        foreach (var item in drinks)
                        {
                            Console.WriteLine(item.Name);
                        }
                        Console.WriteLine("Tryk på enter for at fortsætte");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Arbejder...");
                        Console.WriteLine("Søg på drinkens navn.");
                        string search = Console.ReadLine();
                        drinks = manager.SearchDrinks(search);
                        foreach (var item in drinks)
                        {
                            Console.WriteLine(item.Name);
                        }
                        Console.WriteLine("Tryk på enter for at fortsætte");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Tak for nu! Tryk enter for at lukke ned.");
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
