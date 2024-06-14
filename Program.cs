using System;

namespace Dcit318Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound(); // Output: Some generic sound
            dog.MakeSound(); // Output: Bark
            cat.MakeSound(); // Output: Meow
        }
    }
}
