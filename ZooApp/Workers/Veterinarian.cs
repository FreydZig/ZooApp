using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public class Veterinarian : IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        string AnimalExperiences { get; set; }

        void AddAnimalExperience(Animal animal)
        {

        }

        bool HasAnimalExperience(Animal animal)
        {

            return false;
        }

        bool HeelAnimal(Animal animal)
        {

            return false;
        }
    }
