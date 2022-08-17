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
        public Zoo ParentZooo { get; private set; }
        public int SqureFeet { get; private set; }
    }
}
