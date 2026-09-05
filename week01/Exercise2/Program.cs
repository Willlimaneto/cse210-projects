using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        string sign;
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        

    
         Console.WriteLine($"Your grade letter is {letter}{sign}");
        
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed, all of your effort was worth it.");
        }
        else
        {
           Console.WriteLine("Sorry to inform that you have not passed, but don't be sad you may failed this time but if you continue pushing harder you are going to make it!");  
        }
    }
}