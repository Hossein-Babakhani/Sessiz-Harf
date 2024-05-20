using System;

namespace Sessiz_Harf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir dize veya kelime öbeği girin : ");
            string input = Console.ReadLine(); 
            bool hasTwoConsecutiveSilentCharacters = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                char currentChar = char.ToLower(input[i]);
                char nextChar = char.ToLower(input[i + 1]);

                if ("bcdfghjklmnpqrstvwxyz".Contains(currentChar) && "bcdfghjklmnpqrstvwxyz".Contains(nextChar))
                {
                    hasTwoConsecutiveSilentCharacters = true;
                    break;
                }
            }

            Console.WriteLine(hasTwoConsecutiveSilentCharacters);
            Console.ReadKey();
        }
        
    }
}
