using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List <int> numbers = new List <int>();

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }   
        int sum = 0;
        int largest = 0; 
        foreach (int item in numbers)
            {
                sum += item;
                
                if (item > largest)
            {
                largest = item;
            }
            }  
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The sum is: {sum}"); 
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");  
    }

}