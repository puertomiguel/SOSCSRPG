using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            // Declare the items needed to complete the quest, and the quest reward items
            List<ItemQuanitity> itemsToComplete = new List<ItemQuanitity>();
            List<ItemQuanitity> rewardItems = new List<ItemQuanitity>();

            itemsToComplete.Add(new ItemQuanitity(9001, 5));
            rewardItems.Add(new ItemQuanitity(1002, 1));

            // Create quest
            _quests.Add(new Quest(1, "Clear the herb garden",
                                  "Defeat the snakes in the Herbalist's garden",
                                  itemsToComplete, 25, 10, rewardItems));
        }
        
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
