using System;

class Program
{
    static void Main(string[] args)
    {
        string answer2 = " ";
        do
        {
            Console.WriteLine("What is the magic number? Try to guess it (__)");
        //string answer = Console.ReadLine();
        //int randomNum = int.Parse(answer);
        Random random = new Random();
        int randomNum = random.Next(1,101);
        
        int guessedNum = 0;
        int guesses = 0;
        while (guessedNum != randomNum)
        {
        Console.Write("What is your guess? ");
        string answer1 = Console.ReadLine();
        guessedNum = int.Parse(answer1);
        guesses++;

        if (guessedNum > randomNum)
        {
            Console.WriteLine("Lower");
        }
        else if (guessedNum < randomNum)
        {
            Console.WriteLine("Higher");
        }
        else 
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You guessed it at your {guesses} guess.");
            Console.WriteLine("");
            Console.Write("Do you want to continue? ");
            answer2 = Console.ReadLine();
        }
        }
        }
        while (answer2 == "yes");
        
        
    }
}