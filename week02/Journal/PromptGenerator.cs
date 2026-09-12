
public class PromptGenerator
{
    private List<string> _prompts = new List<string>();
    public PromptGenerator()
        {
            _prompts.Add("Who was the most interesting person I interacted with today?"); 
            _prompts.Add("What was the best part of my day?"); 
            _prompts.Add("How did I see the hand of the Lord in my life today?"); 
            _prompts.Add("What was the strongest emotion I felt today?"); 
            _prompts.Add("If I had one thing I could do over today, what would it be?"); 
            _prompts.Add("What did I accomplish today that I am proud of?"); 
            _prompts.Add("What mistake did I make today, and what can I learn from it?"); 
            _prompts.Add("If I could give advice to my future self, what would I say?");
            _prompts.Add("What is one thing I noticed today that I normally don't pay attention to?"); 

        }
       public string GetRandomPrompt()
            {
                Random random = new Random();
                int index = random.Next(_prompts.Count);
                return _prompts[index];

            }
}