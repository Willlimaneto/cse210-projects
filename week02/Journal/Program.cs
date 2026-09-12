using System;

class Program
{
    // Exceeding requirements:
    // 1. Added input validation using int.TryParse() so the program does not
    //    crash if the user types a non-numeric value (e.g. "abc") instead of a menu number.
    // 2. Added a default case in the switch statement to handle numbers that
    //    are not valid menu options (e.g. typing 9), so the user gets a clear
    //    "Invalid choice" message instead of the program silently doing nothing.

    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            bool isValid = int.TryParse(Console.ReadLine(), out choice);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    Entry entry = new Entry();
                    string entryText = Console.ReadLine();
                    entry._entryText = entryText;
                    entry._promptText = promptText;
                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("What is the filename to load from? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case 4:
                    Console.Write("What is the filename to save to? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
        while (choice != 5);
    }
}