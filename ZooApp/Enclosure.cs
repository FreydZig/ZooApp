using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public class Enclosure
    {
        public string Name { get; private set; }
        public List<Animal> Animals { get; private set; }
        public Zoo ParentZoo { get; private set; }
        public int SqureFeet { get; set; }

        public Enclosure(string name, List<Animal> animals, Zoo parentZoo, int squreFeet)
        {
            Name = name;
            Animals = animals;
            ParentZoo = parentZoo;
            SqureFeet = squreFeet;
        }
    }
}
