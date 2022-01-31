using System;


namespace Animal
{
    internal class Dog : Animal
    {
        public string name {get; set;} 

        public Dog(bool pet, bool tail,string name) : base(pet,tail)
        {
            this.name = name;
        }

        public void animalSound()
        {
            Console.WriteLine("The Dog Makes A Sound!");
        }
        public void sleep()
        {
            Console.WriteLine("The Dog Is Sleeping");
        }
        public void eat()
        {
            Console.WriteLine("The Dog Is Eating");
        }
    }
}
