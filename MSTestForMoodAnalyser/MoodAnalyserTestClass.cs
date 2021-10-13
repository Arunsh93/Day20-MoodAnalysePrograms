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

        //TC-4.1
        [TestMethod]
        public void GivenMoodAnalyserObject()
        {
            string className = "MoodAnalyserProgram.MoodAnalyser";
            string constructorName = "MoodAnalyser";
            object Expected = new MoodAnalyser();
            object Actual = MoodAnalyserFactory.CreateMoodAnalyserDefaultConstructor(className, constructorName);
            Expected.Equals(Actual);
        }
        //TC-4.2
        [TestMethod]
        public void GivenMoodAnalyser_ReturnNoSuchClass()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyserProgram.MoodAnalyse1";
                string constructorName = "MoodAnalyser1";
                object Expected = new MoodAnalyser();

                //Action
                object Actual = MoodAnalyserFactory.CreateMoodAnalyserDefaultConstructor(className, constructorName);
            }
            catch(MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual("Class Not Found", ex.Message);
            }          
        }

        //TC-4.3
        [TestMethod]
        public void GivenMoodAnalyser_ReturnNoSuchConstructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyserProgram.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                object Expected = new MoodAnalyser();

                //Action
                object Actual = MoodAnalyserFactory.CreateMoodAnalyserDefaultConstructor(className, constructorName);
            }
            catch (MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }

        //TC-5.1
        [TestMethod]
        public void GivenMoodAnalyser_ReturnParameterizedConstroctor()
        {
            string className = "MoodAnalyserProgram.MoodAnalyser";
            string constructorName = "MoodAnalyser";
            object Expected = new MoodAnalyser("HAPPY");
            object Actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameter(className, constructorName, "Happy");
            Expected.Equals(Actual);
        }

        //TC-5.2
        [TestMethod]
        public void GivenMoodAnalyser_ReturnNoSuchClass_UsingParametrizedConstroctor()
        {
            string Expected = "Class Not Found";
            try
            {
                //Arrange
                string className = "MoodAnalyserProgram.MoodAnalyser1";
                string constructorName = "MoodAnalyser1";
                

                //Action
                object Actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameter(className, constructorName, Expected);
            }
            catch (MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual("Class Not Found", ex.Message);
            }
        }
        //TC-5.3
        [TestMethod]
        public void GivenMoodAnalyser_ReturnNoSuchMethod_UsingParametrizedConstroctor()
        {
            string Expected = "Constructor Not Found";
            try
            {
                //Arrange
                string className = "MoodAnalyserProgram.MoodAnalyser";
                string constructorName = "MoodAnalyser1";


                //Action
                object Actual = MoodAnalyserFactory.CreateMoodAnalyserUsingParameter(className, constructorName, Expected);
            }
            catch (MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }
        //TC-6.1
        [TestMethod]
        public void GivenMoodAnalyser_ForInvokeMethod()
        {

            //Arrange
            string Expected = "Happy";

            //Action
            object Actual = MoodAnalyserFactory.CreateMoodAnalyserForInvokeMethod(Expected, "AnalyseMood");

            //Assert
            Expected.Equals(Actual);           
        }
        //TC-6.2
        [TestMethod]
        public void GivenMoodAnalyser_ForInvokeMethod_ReturnNoSuchMethod()
        {
            string Expected = "No Such Method Found";
            try
            {
                //Arrange
                string methodName = "AnalyserMood";

                //Action
                object Actual = MoodAnalyserFactory.CreateMoodAnalyserForInvokeMethod("Sad", methodName);
            }
            catch(MoodAnalysisCustomException ex)
            {
                //Assert
                Assert.AreEqual(Expected, ex.Message);
            }
        }
    }
}
