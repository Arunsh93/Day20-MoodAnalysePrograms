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
        public string AnalyseMood()
        {
            try
            {
                if (this.mood.Equals(string.Empty))
                {
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.EMPTY_MESSAGE, "Message Should not be Empty");
                }
                if (this.mood.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE, "Message Should not be Null");
            }
        }
    }
}
