using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestForMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        public void GetHappyMoodReturnMessage()
        {
            MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser("Iam in Happy Mood");

            //Arrange
            string expectedOutput = "HAPPY";
            string actualOuput;

            //Action
            actualOuput = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expectedOutput, actualOuput);
        }

        [TestMethod]
        public void GetSadMoodReturnMessage()
        {
            MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser("Iam in Sad Mood");

            //Arrange
            string expectedOutput = "SAD";
            string actualOuput;

            //Action
            actualOuput = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expectedOutput, actualOuput);
        }
    }
}
