using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Animal
    {
        //this is an example of abstraction due to the fact that there can be any number
        //of animals with a different amount of legs, different name, and different species
        public int numberofLegs;
        public string species;
        public string Name;

        public void SetNumberofLegs(int legs)
        {
            numberofLegs = legs;
        }
        public void SetSpecies(string Species)
        {
            if (String.IsNullOrWhiteSpace(Species))
            {
                species = "animal";
            }
            species = Species;
        }
        public int GetNumberOfLegs()
        {
            return numberofLegs;
        }
        public string GetSpecies()
        {
            return species;
        }
        public void SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                Name = "Bob";
            }
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        

    }
}
