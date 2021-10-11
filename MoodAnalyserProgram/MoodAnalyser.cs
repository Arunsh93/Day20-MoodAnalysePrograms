using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    class MoodAnalyser
    {
        public string AnalyseMood(string mood)
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
