using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public abstract class Animal
    {
        public abstract int RequiredSpaceSqFt { get; }
        public abstract string FavoriteFood { get; }
        List<FeedTime> FeedTimes { get; }
        List<int> FeedSchedule { get; }
        int ID { get; set; }

        public abstract bool IsFriendlyWith(Animal animal);        

        void Feed(Food food, ZooKeeper zooKeeper)
        {

        }

        bool IsStick()
        {
            return false;
        }

        void AddFeedSchedule(List<int> hours)
        {

        }

        void Heal(Medicine medicine)
        {

        }

    }
}
