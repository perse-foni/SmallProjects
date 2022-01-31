using System;


namespace Animal
{
    internal class Cat : Animal
    {
        public string color { get; set;}
        public Cat(bool pet, bool tail, string color) : base(pet,tail)
        {
            this.color = color;
        }
        public void animalSound()
        {
            Console.WriteLine("The Cat Makes A Sound!");
        }
        public void sleep()
        {
            Console.WriteLine("The Cat Is Sleeping");
        }
        public void eat()
        {
            Console.WriteLine("The Cat Is Eating");
        }
    }
}
