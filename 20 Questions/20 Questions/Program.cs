namespace _20_Questions
{
    internal class Program
    {
        static Tree tree;
        static void Main(string[] args)
        {
            startNewGame();
            Console.WriteLine("\nStarting the Game");
            tree.query();
            while(playAgain())
            {
                Console.WriteLine();
                tree.query();
            }
        }

        //When the game starts we need to create a binary tree to hold the computer's knowledge. A new game needs one question and two objects and is executed in the startNewGame() method
        static void startNewGame()
        {
            Console.WriteLine("No previous knowledge found!");
            Console.WriteLine("Initializing a new game.\n");
            Console.WriteLine("Enter a question about an object: ");
            string question = Console.ReadLine();
            Console.Write("Enter a guess if the response is Yes: ");
            string yesGuess = Console.ReadLine();
            Console.Write("Enter a guess if the response is No: ");
            string noGuess = Console.ReadLine();
            tree = new Tree(question, yesGuess, noGuess);
        }

        static bool playAgain()
        {
            Console.Write("\nPlay Another Game?");
            char inputCharacter = Console.ReadLine().ElementAt(0);
            inputCharacter = Char.ToLower(inputCharacter); //could implement this back in the TreeNode.cs
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                Console.WriteLine("Incorrect input please enter again: ");
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            if (inputCharacter == 'y')
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
