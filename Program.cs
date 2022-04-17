namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");
            MoodAnalzser moodAnalzser = new MoodAnalzser();
            Console.WriteLine("\nEnter Your Current Mood : ");
            string mood = Console.ReadLine();
            mood = moodAnalzser.AnalyseMood(mood);
            Console.WriteLine(mood);
        }
    }
}