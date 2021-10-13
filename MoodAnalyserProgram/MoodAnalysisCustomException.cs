using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    public class MoodAnalysisCustomException : Exception
    {
        public enum ExceptionType 
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELDS,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE,
        }      
        public ExceptionType type;

        public MoodAnalysisCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
