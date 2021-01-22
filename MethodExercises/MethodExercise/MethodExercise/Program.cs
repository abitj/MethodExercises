using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your bull name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your bull color?");
             var color = Console.ReadLine();

             Console.WriteLine("How old is your bull?");
             var bullAge = Console.ReadLine();

             Console.WriteLine("Where does your bull sleep?");
             var sleepPlace = Console.ReadLine();
            

            Console.WriteLine($"My bull name is {name} and it 's {color}. It turns {bullAge} in January. My bull sleeps in {sleepPlace}");

        }
    }
}
