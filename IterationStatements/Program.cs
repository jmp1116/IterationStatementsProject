using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = new List<int>();

            
            int jmp = 0;


            do
            {
                jmp++;


                numbers.Add(jmp);
            } while (jmp < 100);
            



            while (jmp < 200)
            {
                jmp++;
                numbers.Add(jmp);
            }

            Console.WriteLine("Increase:");

            
            foreach (int number in numbers)

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

           
            for (int i = 199; i <= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
