using System.Collections.Generic;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }

        public List<ItemQuanitity> ItemsToComplete { get; }

        public int RewardExperiencePoints { get; }
        public int RewardGold { get; }
        public List<ItemQuanitity> RewardItems { get; }

        public Quest(int id, string name, string description, List<ItemQuanitity> itemsToComplete,
                     int rewardExperiencePoints, int rewardGold, List<ItemQuanitity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
