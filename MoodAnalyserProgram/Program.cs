using System;

namespace MoodAnalyserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to Mood Analyser Program****");
            Console.Write("Enter a Message to test Mood: ");
            string mood = Console.ReadLine();
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string message = moodAnalyser.AnalyseMood();
            Console.WriteLine(message);
        }
    }
}
