using System;

namespace MethodExercise1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(Sum(15, 60));
            Console.WriteLine(Substract(10, 6));
            Console.WriteLine(Multiply(5, 60));
            Console.WriteLine(Divide(15, 3));
         
        }
        public static int Sum(int a, int b)
        {
            int answer = a + b;
            return answer;
        }

        public static int Substract(int a, int b)
        {
            int answer = a - b;
            return answer;
        }

        public static int Multiply(int a, int b)
        {
            int answer = a * b;
            return answer;
        }

        public static int Divide(int a, int b)
        {
            int answer = a / b;
            return answer;
        }
    }
}
