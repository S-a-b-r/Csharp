using ConsoleApp12.animals;
using System;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new Animal("Andrey", "male", 18,"veg");
            var bird1 = new Bird("andrey", "male", 18, "veg", 1, "S", true, "Sinichka");
            bird1.fly();
            Console.WriteLine(bird1.name);
            Console.ReadLine();
        }
    }
}
