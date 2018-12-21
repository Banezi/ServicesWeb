using EntitiesLayer;
using System;
using System.Collections.Generic;

namespace GameOfThroneConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BusinessLayer.ThronesTournamentManager manager = new BusinessLayer.ThronesTournamentManager();
            List<Character> charForts = manager.GetAllCharactersFort();

            foreach(Character c in charForts)
                Console.WriteLine(c.ToString());

            Console.ReadLine();
        }
    }
}
