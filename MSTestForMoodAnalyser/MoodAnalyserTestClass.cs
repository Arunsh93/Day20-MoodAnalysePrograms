using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestForMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        string expectedOutput = "HAPPY";
        [TestMethod]
        public void GetHappyMoodReturnMessage()
        {
            try
            { 
                MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser(null);
                //Arrange
                string actualOuput;

                //Action
                actualOuput = moodAnalyser.AnalyseMood();
            }
            catch(Exception ex)
            {
                //Assert
                Assert.AreEqual(expectedOutput, ex.Message);
            }
        }
    }
}
