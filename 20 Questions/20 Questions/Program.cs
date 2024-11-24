using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _20_Questions
{
    internal class Program
    {
        static Tree  tree = new Tree();


        static void Main(string[] args)
        {
            //hard code start of tree(?)
            //call tree.query()(?)
            startNewGame();
            
            while (playAgain())
            {
                Console.WriteLine();
                tree.query();
            }
        }

        //When the game starts we need to create a binary tree to hold the computer's knowledge. A new game needs one question and two objects and is executed in the startNewGame() method
        static void startNewGame()
        {
            Console.WriteLine("\nStarting the Game");
            Console.WriteLine("Welcome to 20 questions Countries!");
            Console.WriteLine("Initializing a new game.\n");
            Console.WriteLine("Think about a country and we'll try to guess it: ");
            tree.query();
            while (playAgain())
            {
                Console.WriteLine();
                tree.query();
            }
        }

        static bool playAgain()
        {
            Console.Write("\nPlay Another Game?");
            char inputCharacter = Console.ReadLine().ElementAt(0);
            inputCharacter = Char.ToLower(inputCharacter);
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                Console.WriteLine("Incorrect input please enter again: ");
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            if (inputCharacter == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
