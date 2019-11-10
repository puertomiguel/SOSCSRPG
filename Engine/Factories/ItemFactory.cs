using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItem;

        static ItemFactory()
        {
            _standardGameItem = new List<GameItem>();

            _standardGameItem.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItem.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItem.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }
    }
}
