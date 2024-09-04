using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StarWarsControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCharacter();
            MyShip();
            Console.ReadKey();
        }

        static void MyCharacter()
        {
            Console.WriteLine("Enter the name of a Star Wars character: ");
            string character = Console.ReadLine();

            if (string.IsNullOrEmpty(character))
            {
                Console.WriteLine("Character name cannot be empty.");
            }
            else if (character == "Luke Skywalker" || character == "Yoda")
            {
                Console.WriteLine($"{character} is a Jedi.");
            }
            else if (character == "Darth Vader" || character == "Emperor Palpatine")
            {
                Console.WriteLine($"{character} is a Sith.");
            }
            else if (character == "Han Solo" || character == "Lei Organa")
            {
                Console.WriteLine($"{character} is a Rebel.");
            }
            else
            {
                Console.WriteLine($"{character} is neither a Jedi nor a Sith.");
            }
        }
        static void MyShip()
        {
            Console.WriteLine("\nEnter the name of a Star Wars ship:");
            string ship = Console.ReadLine();

            switch (ship)
            {
                case "Millennium Falcon":
                case "Slave I":
                    Console.WriteLine("This is Han Solo's ship.");
                    break;
                case "X-Wing":
                case "Y-Wing":
                    Console.WriteLine("This is a Rebel Starfighter");
                    break;
                case "TIE Fighter":
                case "TIE Bomber":
                    Console.WriteLine("This is an Imperial Starfighter");
                    break;
                default:
                    Console.WriteLine("This is an unknown ship.");
                    break;
            }
  
        }
        
    }
}
