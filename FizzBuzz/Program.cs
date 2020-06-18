using System;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {

                for (var idx = 1; idx <= 30; idx++) {
                if (idx % 3 == 0 && idx % 5 == 0)
                    Console.Write("FizzBuzz ");
                else if (idx % 3 == 0)
                    Console.Write("Fizz ");
                else if (idx % 5 == 0)
                    Console.Write("Buzz ");
                else Console.Write($"{idx}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //can be done w/ continue...could also create a game
        }
    }
}
