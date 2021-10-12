using System;

namespace MoodAnalyserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to Mood Analyser Program****");
            //Console.Write("Enter a Message to test Mood: ");
            string mood = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(mood);
            string message = moodAnalyser.AnalyseMood();
            Console.WriteLine(message);
        }
    }
}
