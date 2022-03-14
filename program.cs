using System;


namespace practiceAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of Random class
            Random random = new Random();
            // generates number from 1 to 10 and stores it in a variable named magicNumber
            int magicNumber = random.Next(1, 11);
            // creates line and prints text to screen 
            Console.WriteLine(" Welcome to the game\n Your task is simple\n guess a number from 1 to 10");
            // prints text to screen without creating a new line
            while (true) { 
                Console.Write("\n\n Input number : ");
                // creates a variable named guess and sets it to 0 by default
                int guess = 0;
                // cheeky error handling to stop dodgey blokes 
                bool isValid = int.TryParse(Console.ReadLine(), out guess);
                // makes sure input is within the required range
                if (guess <= 0 || guess > 10) { /* sets isValid to false */ isValid = false;}
                if (isValid)
                {
                    //runs game 

                    // checks if your guess is the magic number
                    if(guess == magicNumber)
                    {
                        // correct Guess sends positive reenforcement
                        Console.WriteLine(" Congratulations, you have won! \n we will return your family to you in 3-4 business days");
                        break;
                    } else { 
                        // failed guess; hurls abuse
                        Console.WriteLine(" Guess again"); 
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
