using System.Collections.Generic;
using System.Linq;

namespace Engine.Models
{
    public class Recipe
    {
        public int ID { get; }
        public string Name { get; }
        public List<ItemQuanitity> Ingredients { get; } = new List<ItemQuanitity>();
        public List<ItemQuanitity> OutputItems { get; } = new List<ItemQuanitity>();

        public Recipe(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public void AddIngredient(int itemID, int quantity)
        {
            if (!Ingredients.Any(x => x.ItemID == itemID))
            {
                Ingredients.Add(new ItemQuanitity(itemID, quantity));
            }
        }

        public void AddOutputItem(int itemID, int quantity)
        {
            if (!OutputItems.Any(x => x.ItemID == itemID))
            {
                OutputItems.Add(new ItemQuanitity(itemID, quantity));
            }
        }
    }
}