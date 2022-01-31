using System;

namespace Animal
{
    internal class Animal : IAnimal
    {
        public bool pet { get; set; }
        public bool tail {get; set;}

        public Animal(bool pet,bool tail)
        {
            this.pet = pet;
            this.tail = tail;
        }

        public  void animalSound()
        {
            Console.WriteLine("The Animal Makes A Sound!");
        }
        public void sleep()
        {
            Console.WriteLine("The Animal Is Sleeping");
        }
        public void eat()
        {
            Console.WriteLine("The Animal Is Eating");
        }
    }
}
