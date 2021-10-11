using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestForMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        public void GetMoodReturnMessage()
        {
            MoodAnalyserProgram.MoodAnalyser moodAnalyser = new MoodAnalyserProgram.MoodAnalyser();

            //Arrange
            string sadMood = "Iam in Sad Mood";
            string happyMood = "Iam in Happy Mood";
            string expectedOutput = "HAPPY";
            string actualOuput;

            //Action
            actualOuput = moodAnalyser.AnalyseMood(happyMood);

            //Assert
            Assert.AreEqual(expectedOutput, actualOuput);
        }
    }
}
