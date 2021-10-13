using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProgram
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyserDefaultConstructor(string className, string constructorName)
        {
            string Pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, Pattern);

            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
            }
        }

        //For Parameterised Constructor
        public static object CreateMoodAnalyserUsingParameter(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
                }
            }
            else
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
        //For Invoke Method
        public static object CreateMoodAnalyserForInvokeMethod(string message, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameter(type.Name, "MoodAnalyser", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_METHOD, "No Such Method Found");
            }
        }
    }
}
