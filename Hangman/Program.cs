namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman game...\n A name of a random European city has been rendomly chosen for you to guess\n");

            const int MAXIMUM_NUMBER_OF_FAULTS = 5;
            int maximumNumberOfFaults = MAXIMUM_NUMBER_OF_FAULTS;

            // Define the líst of all words
            List<string> listOfWordsToGuess = new List<string>();
            listOfWordsToGuess.Add("Copenhagen");
            listOfWordsToGuess.Add("Salzburg");
            listOfWordsToGuess.Add("Budapest");
            listOfWordsToGuess.Add("Thessaloniki");
            listOfWordsToGuess.Add("Barcelona");

            // Create a random index for the word to be guessed from the list
            Random rnd = new Random();
            int randomWordIndexFromList = rnd.Next(0, listOfWordsToGuess.Count -1);

            // Create a charachter list to store the right guesses from the user
            List<char> Guessword = new List<char>();

            List<char> randomlySelectedWord = listOfWordsToGuess[randomWordIndexFromList].ToList<char>();

            // Fill the charachter list with '_'
            foreach (char Character in randomlySelectedWord)
            {
                Guessword.Add('_');
            }

            char guessedChar;

            while (maximumNumberOfFaults != 0)
            {
                Console.WriteLine($"\nYou have {maximumNumberOfFaults} attempts left");
                Console.WriteLine("\nYour current guess: " + string.Concat(Guessword));
                Console.Write("\nPlease input the charachter to guess. Make sure the first Guess is a capital letter: ");
                guessedChar = Console.ReadKey().KeyChar;

                if (!char.IsAsciiLetter(guessedChar))
                {
                    Console.WriteLine("\nplease enter a valid charachter (only Ascii letters)\n");
                    continue;
                }
                if (!randomlySelectedWord.Contains(guessedChar))
                {
                    maximumNumberOfFaults--;
                    
                }
                for (int i = 0; i < randomlySelectedWord.Count; i++)
                {
                    if(guessedChar == randomlySelectedWord[i])
                    {
                        Guessword[i] = guessedChar;
                    }
                }

            }




        }
    }
}
