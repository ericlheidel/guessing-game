// See https://aka.ms/new-console-template for more information



string greeting = @"
Welcome to the
Guessing Game!!!
";

void App()
{
    Console.Clear();
    Random random = new Random();
    int secretNumber = random.Next(1, 101);
    Console.WriteLine($"THIS IS THE SECRET NUMBER FOR TESTING PURPOSES...{secretNumber}");

    Console.WriteLine(@"
Please select a difficulty level

1. Easy (8 Guess)
2. Medium (6 Guesses)
3. Hard (4 Guesses)
4. CHEATER MODE!!!");

    int guesses = 0;
    int response = int.Parse(Console.ReadLine().Trim());
    if (response == 1)
    {
        guesses = 8;
    }
    else if (response == 2)
    {
        guesses = 6;
    }
    else if (response == 3)
    {
        guesses = 4;
    }
    else if (response == 4)
    {
        guesses = 1;
    }
    else
    {
        App();
    }


    Console.WriteLine($"{greeting}");

    int guessTry = 1;

    Console.WriteLine($"Please try and guess the secret number: (You have {guesses} guesses, this is guess #{guessTry})\n");

    bool isCorrect = false;
    int guessedNumber;

    do
    {
        try
        {
            guessedNumber = int.Parse(Console.ReadLine().Trim());
            if (response != 4)
            {
                guesses--;
                guessTry++;
            }
            if (guessedNumber == secretNumber)
            {
                Console.WriteLine("\nCongratulations, you guessed the number!!\n");
                isCorrect = true;
            }
            else
            {
                if (guessedNumber > secretNumber)
                {
                    Console.WriteLine("\nYOUR GUESS IS TOO HIGH!!!!!");
                }
                if (guessedNumber < secretNumber)
                {
                    Console.WriteLine("\nYOUR GUESS IS TOO LOW!!!!!");
                }
                Console.WriteLine($"GUESS TRY =============== {guessTry}");
                Console.WriteLine($"GUESSES LEFT =============== {guesses}");
                if (guesses == 0)
                {
                    Console.WriteLine("\nIncorrect guess!\n");
                    Console.WriteLine("\nYou are out of guesses. Goodbye!\n");
                }
                else
                {
                    Console.WriteLine($"\nIncorrect guess! Guess again...(This is guess #{guessTry})\n");
                }
                Console.WriteLine($"{guesses} guesses left...\n");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nPlease type only integers!\n");
        }
    } while (isCorrect == false && guesses > 0);
}

App();
