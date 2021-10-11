using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestForMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        public void GetMoodReturnMessage()
        {
            MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser("Iam in Happy Mood");

            //Arrange
            string sadMood = "Iam in Sad Mood";
            string happyMood = "Iam in Happy Mood";
            string expectedOutput = "HAPPY";
            string actualOuput;

            //Action
            actualOuput = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expectedOutput, actualOuput);
        }
    }
}
