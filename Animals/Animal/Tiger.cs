using System;


namespace Animal 
{
    internal class Tiger : Animal
    {
        public int age {get; set;}

        public Tiger(bool pet, bool tail,int age) : base(pet, tail)
        {
           
            this.age = age;
        }

        public void animalSound()
        {
            Console.WriteLine("The Tiger Makes A Sound!");
        }
        public void sleep()
        {
            Console.WriteLine("The Tiger Is Sleeping");
        }
        public void eat()
        {
            Console.WriteLine("The Tiger Is Eating");
        }
    }
}
