using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProgram;
using System;

namespace MSTestForMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        //string expectedOutput = "HAPPY";

        //TC 3.1: Given Null Mood
        [TestMethod]
        public void GiventNullMoodReturnMessage()
        {
            //UC2
            try
            {
                string message = null;
                MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser(message);
                //Arrange
                string actualOuput;

                //Action
                actualOuput = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual("Message Should not be Null", ex.Message);
            }
        }

        //TC 3.1:Given Empty Mood 
        [TestMethod]
        public void GivenEmptyMoodReturnMessage()
        {
            //UC2
            try
            {
                string message = "";
                MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser(message);

                //Arrange
                string actualOuput;

                //Action
                actualOuput = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual("Message Should not be Empty", ex.Message);
            }
        }
    }
}
