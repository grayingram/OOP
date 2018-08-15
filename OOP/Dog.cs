using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //example of inheritance with the dog inheriting from animal
    class Dog : Animal
    {
        //This is an example of polymophism in that either method can be called
        //but one will assign a name to the dog and the other will not
        public Dog()
        {
            SetSpecies("Mammal");
        }
        public Dog(string name)
        {
            SetSpecies("Mammal");
            SetName(name);
        }
        public new void SetNumberofLegs(int legs)
        {
            if (legs > 5)
            {
                numberofLegs = 4;
            }
            numberofLegs = legs;
        }
        //this is an example of encapsulation in that the getmessage is encapsulated from outside use
        public string Bark()
        {
            return getMessage();
        }
        private string getMessage()
        {
            string name = GetName();
            int legs = GetNumberOfLegs();
            string species = GetSpecies();
            return "My name is " + name + " I have " + legs + " many legs and I am " + species + "!";
        }
    }
}
