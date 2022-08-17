using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.AnimalsClasses;

namespace ZooLab.Animals
{
    public class Snake : Reptile
    {
        public override int RequiredSpaceSqFt => throw new NotImplementedException();

        public override string FavoriteFood => throw new NotImplementedException();

        public override bool IsFriendlyWith(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
