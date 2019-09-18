using System;

namespace arrayDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Here is a manually generated array containing 25 even integers which will be iterated through a for loop");
            // Here are the integers in the array
            int[] numbers = { 0,2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46,48 };
            // The Foreach loop
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);
        }
    }
}
