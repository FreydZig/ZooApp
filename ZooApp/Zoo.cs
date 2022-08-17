using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public class Zoo
    {
        public List<Enclosure> Enclosures { get; private set; } = new List<Enclosure>();
        public List<IEmployee> Employees { get; private set; } = new List<IEmployee>();
        public string Location { get; private set; }

        void AddEnclosure(string name, int squreFeet)
        {
            
        }

        void FindAvailableEnclosure(Animal animal)
        {

        }

        void HireEmployee(IEmployee employee)
        {

        }

        void FeedAnimals(DateTime dateTime)
        {

        }

        void HealAnimals()
        {

        }

        void Animal(Animal animal)
        {

        }
    }
}
