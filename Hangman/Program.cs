namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman game...\n A name of a random European city has been rendomly chosen for you to guess\n");

            const int MAXIMUM_NUMBER_OF_FAULTS = 5;

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

            // Create a charachter list to contain the guess from the user
            List<char> Guessedword = new List<char>();
            
            // Fill the charachter list with '_'
            foreach (char Character in listOfWordsToGuess[randomWordIndexFromList])
            {
                Guessedword.Add('_');
            }

            while (MAXIMUM_NUMBER_OF_FAULTS != 0)
            {
                Console.Write("Please input the charachter to guess");

            }




        }
    }
}
