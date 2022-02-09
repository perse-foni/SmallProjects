using System;

namespace Animal
{
 class Program
    {
        static void Main()
        {
            
            Tiger myTiger = new Tiger(false, true, 15);
            Cat myCat = new Cat(true, true, "white");
            Dog myDog = new Dog(true, true, "Freddy");

            Console.WriteLine("Tiger is a pet: " + myTiger.pet);
            Console.WriteLine("Tiger has a tail: "+myTiger.tail);
            Console.WriteLine("Tiger is: " + myTiger.age + " years old");
            myTiger.animalSound();
            myTiger.eat();
            myTiger.sleep();
            Console.WriteLine("");
            Console.WriteLine("******************");
            Console.WriteLine("");

           
            Console.WriteLine("Cat is a pet: " + myCat.pet);
            Console.WriteLine("Cat has a tail: " + myCat.tail);
            Console.WriteLine("Cat has: " + myCat.color + " color");
            myCat.animalSound();
            myCat.eat();
            myCat.sleep();
            Console.WriteLine("");
            Console.WriteLine("******************");
            Console.WriteLine("");

            Console.WriteLine("Dog is a pet: " + myDog.pet);
            Console.WriteLine("Dog has a tail: " + myDog.tail);
            Console.WriteLine("Dog's name is: " + myDog.name);
            myDog.animalSound();
            myDog.eat();
            myDog.sleep();
            Console.WriteLine("");
            Console.WriteLine("******************");




        }
    }
}
