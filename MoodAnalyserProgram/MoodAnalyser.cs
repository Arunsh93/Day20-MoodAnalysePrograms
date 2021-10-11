using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    public class MoodAnalyser
    {
        private string mood;
        public MoodAnalyser(string mood)
        {
            this.mood = mood;
        }
        public MoodAnalyser()
        {

        }
        public string AnalyseMood()
        {
            if (mood.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
