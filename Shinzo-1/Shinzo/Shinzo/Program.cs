using System.Media;

namespace Shinzo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> Questions = new Dictionary<string, string>();

            // Adding elements
            Questions.Add("What science fiction show did Jean Luc Picard cast in?", "Star trek");
            Questions.Add("What science fiction show did Darth Vader cast in?", "Star wars");
            Questions.Add("what show is the Doctor from?", "Doctor Who");
            Console.WriteLine("Welcome to the Questoin game");
            Console.WriteLine("Please answer the following questions");

            int score = 0;


            foreach (var ele in Questions)
            {

                Console.WriteLine($"Question: {ele.Key}");
                string UserInput = Console.ReadLine();

                if (UserInput == ele.Value)
                {
                    SoundPlayer ss = new SoundPlayer(@"C:\Users\whitb\OneDrive\Desktop\Csharp\Shinzo\Shinzo\Audio\correct-choice-43861.wav");
                    ss.Play();
                    Console.WriteLine("///////////////////////////");
                    Console.WriteLine($"Correct Answer: {ele.Value}");
                    Console.WriteLine($"Your Answer: {UserInput}");
                    Console.WriteLine("///////////////////////////");
                    score++;
                }
                else
                {
                    SoundPlayer ss = new SoundPlayer(@"C:\Users\whitb\OneDrive\Desktop\Csharp\Shinzo\Shinzo\Audio\wrong-47985.wav");
                    ss.Play();
                    Console.WriteLine("///////////////////////////");
                    Console.WriteLine($"Correct Answer: {ele.Value}");
                    Console.WriteLine($"Your Answer: {UserInput}");
                    Console.WriteLine("///////////////////////////");
                }
            }
            Console.WriteLine($"Your score: {score}");
        }
    }
}
