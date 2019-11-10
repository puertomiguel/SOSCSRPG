using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ItemQuanitity> ItemsToComplete { get; set; }

        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuanitity> RewardItems { get; set; }

        public Quest(int id, string name, string description, List<ItemQuanitity> itemsToComplete,
                     int rewardExperiencePoints, int rewardGold, List<ItemQuanitity> rewardItems)
        {
            ID = id;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
