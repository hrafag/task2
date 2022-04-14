using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Afag", "Faik", "Ulviyye", "Kamran", "Fuad" };
            Console.WriteLine(names[3]);
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length>5)
                {
                    Console.WriteLine(names[i]);
                }


            }

        }
    }
}
