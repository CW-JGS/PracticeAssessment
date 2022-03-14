using System;


namespace practiceAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of Random class
            int totalDelta = 0;
            int[] guessDelta = new int[5];
            Random random = new Random();
            // generates number from 1 to 10 and stores it in a variable named magicNumber
            int magicNumber = random.Next(1, 101);
            // creates line and prints text to screen 
            Console.WriteLine(" Welcome to the game\n Your task is simple\n guess a number from 1 to 100\n you have 5 guesses so guess carefully");
            // prints text to screen without creating a new line
            int triesLeft = 5;
            int counter = 0;
            while (true) {
                if (triesLeft == 0) {
                    Console.WriteLine(" Game Over! :(");
                    Console.WriteLine("\n\n total delta : {0}, \n the number was {1}", totalDelta, magicNumber);
                    foreach (int delta in guessDelta) {
                        Console.Write(" {0},", delta);
                    }
                    break; 
                }
                Console.Write("\n\n Input number : ");
                // creates a variable named guess and sets it to 0 by default
                int guess = 0;
                // cheeky error handling to stop dodgey blokes 
                bool isValid = int.TryParse(Console.ReadLine(), out guess);
                // makes sure input is within the required range
                if (guess <= 0 || guess > 100) { /* sets isValid to false */ isValid = false;}
                if (isValid)
                {
                    //runs game 

                    // checks if your guess is the magic number
                    if(guess == magicNumber)
                    {
                        // correct Guess sends positive reenforcement
                        Console.WriteLine(" Congratulations, you have won! \n we will return your family to you in 3-4 business days");
                        Console.WriteLine("\n\n total delta : {0}", totalDelta);
                        foreach (int delta in guessDelta)
                        {
                            Console.Write(" {0},", delta);
                        }

                        break;
                    } else {
                        // failed guess;
                        triesLeft -= 1;
                        if (magicNumber < guess/* Determines whether number is larger or smaller than guess */)
                        {
                            totalDelta = totalDelta + (guess - magicNumber);
                            Console.WriteLine(" the number is less than {0}. you have {1} tries left", guess, triesLeft);
                            guessDelta[counter] = guess - magicNumber;
                        }
                        else
                        {
                            totalDelta = totalDelta + (magicNumber - guess);
                            Console.WriteLine(" the number is greater than {0}. you have {1} tries left", guess, triesLeft);
                            guessDelta[counter] = magicNumber - guess;
                        }
                        counter += 1;
                    }   
                } else
                {
                    // if their input was input it will ask them to try again
                    Console.WriteLine(" invalid input guess again");

                }
                
            

            } 
        }
        
    }
}
