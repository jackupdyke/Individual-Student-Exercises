using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Cat : FarmAnimal
    {
        public Cat() : base("Cat", "meow")
        {

        }

        public override string Eat()
        {
        return "Eating cat food...";
        }



    }
}
