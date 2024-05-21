// See https://aka.ms/new-console-template for more information



string greeting = @"
Welcome to the
Guessing Game!!!
";

void App()
{
    // int secretNumber = 42;

    Console.Clear();
    Random random = new Random();
    int secretNumber = random.Next(1, 101);
    Console.WriteLine($"THIS IS THE SECRET NUMBER FOR TESTING PURPOSES...{secretNumber}");


    Console.WriteLine($"{greeting}");

    Console.WriteLine("Please try and guess the secret number: (You have 4 guesses, this is guess #1)\n");
    bool isCorrect = false;
    int guessedNumber;

    int guesses = 4;
    int guessTry = 1;

    do
    {
        try
        {
            // record the input of the guess number
            guessedNumber = int.Parse(Console.ReadLine().Trim());

            // if correct guess --> display success message
            if (guessedNumber == secretNumber)
            {
                Console.WriteLine("\nCongratulations, you guessed the number!!\n");
                isCorrect = true;
            }
            // if not correct guess...
            else
            {
                // check to see if guess is higher
                if (guessedNumber > secretNumber)
                {
                    Console.WriteLine("\nYOUR GUESS IS TOO HIGH!!!!!");
                }
                //check to see if guess is lower
                if (guessedNumber < secretNumber)
                {
                    Console.WriteLine("\nYOUR GUESS IS TOO LOW!!!!!");
                }
                // increase the guess Try's by 1
                guessTry = guessTry + 1;

                // if the 4 guesses have been used (guesses would now be 5)...
                //gg display "incorrect message and jump down to next green comment...
                if (guessTry == 5)
                {
                    Console.WriteLine("\nIncorrect guess!\n");
                }
                else
                // if incorrect guess AND Try's left (!= 5) then display incorrect// message and 
                // what Guess Try the user is currently on
                {
                    Console.WriteLine($"\nIncorrect guess! Guess again...(This is guess #{guessTry})\n");
                }
                //gg display that 0 guesses are left
                guesses = guesses - 1;
                Console.WriteLine($"{guesses} guesses left...\n");

                //gg if 0 guesses are left, display goodbye message and end app
                if (guesses == 0)
                {
                    Console.WriteLine("\nYou are out of guesses. Goodbye!\n");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nPlease type only integers!\n");
        }
    } while (isCorrect == false && guesses > 0);
}

App();