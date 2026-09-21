namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman game...\nA name of a random European city has been rendomly chosen for you to guess\n");

            const int MAXIMUM_NUMBER_OF_FAULTS = 5;
            int maximumNumberOfFaults = MAXIMUM_NUMBER_OF_FAULTS;

            // Define the líst of all words
            List<string> listOfWordsToGuess = new List<string>();
            listOfWordsToGuess.Add("copenhagen");
            listOfWordsToGuess.Add("salzburg");
            listOfWordsToGuess.Add("budapest");
            listOfWordsToGuess.Add("thessaloniki");
            listOfWordsToGuess.Add("barcelona");

            // Create a random index for the word to be guessed from the list
            Random rnd = new Random();
            int randomWordIndexFromList = rnd.Next(0, listOfWordsToGuess.Count -1);

            // Create a charachter list to store the right guesses from the user
            List<char> Guessword = new List<char>();

            // Store the randomly selected word in a separate variable for readability
            List<char> randomlySelectedWord = listOfWordsToGuess[randomWordIndexFromList].ToList<char>();

            // Fill the charachter list with '_'
            foreach (char Character in randomlySelectedWord)
            {
                Guessword.Add('_');
            }

            char guessedChar;

            List<char> storedUserInput = new List<char>();

            while (maximumNumberOfFaults != 0)
            {
                Console.WriteLine($"\nYou have {maximumNumberOfFaults} attempts left");
                Console.WriteLine("Your last guesses : " + string.Concat(storedUserInput));
                Console.WriteLine("\nYour current guess: " + string.Concat(Guessword));
                Console.Write("\nPlease input the charachter to guess. There is no capital letters. The guessing squence is not relevant: ");
                guessedChar = Console.ReadKey().KeyChar;

                if (!char.IsAsciiLetter(guessedChar))
                {
                    Console.WriteLine("\nplease enter a valid charachter (only Ascii letters)\n");
                    continue;
                }
                if (Guessword.Contains(guessedChar) || storedUserInput.Contains(guessedChar))
                {
                    Console.WriteLine("\nYou already guessed this charachter please enter another one\n");
                    continue;
                }
                storedUserInput.Add(guessedChar);
                if (!randomlySelectedWord.Contains(guessedChar))
                {
                    maximumNumberOfFaults--;
                    Thread.Sleep(500);
                    Console.Clear();
                    continue;
                }
                for (int i = 0; i < randomlySelectedWord.Count; i++)
                {
                    if(guessedChar == randomlySelectedWord[i])
                    {
                        Guessword[i] = guessedChar;
                        Console.Clear();
                    }
                }
                if (Guessword.SequenceEqual(randomlySelectedWord))
                {
                    Console.WriteLine("\n You won\n");
                    return;
                }

                Console.Clear();

            }
            Console.Clear ();
            Console.WriteLine("\n\nYou lost");



        }
    }
}
