using System;

namespace GuessTheNumber
{
    class Program
    {
        private static int GetGuess()
        {
            int guess = 0;
            try
            {  
            guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {  
            Console.WriteLine("You did not enter a valid guess.");
            guess = GetGuess();
            }
            return guess;
        }
        
    }
}
