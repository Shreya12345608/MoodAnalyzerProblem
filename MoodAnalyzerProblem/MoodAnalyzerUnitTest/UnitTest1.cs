using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerUnitTest
{
    public class MoodAnalyzerUnitTestCase
    {
        [Test]
        //given mood shoud return sad
        public void GivenMood_ShouldReturn_Sad()
        {
            //expected string will be sad
            string expected = "Sad";
            //create a object of cass moodanalyzer with i am sad
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Sad");
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
        [Test]
        //given mood shoud return happy
        public void GivenMood_ShouldReturn_Happy()
        {
            //expected string will be happy
            string expected = "Happy";
            //create a object of cass moodanalyzer with i am happy
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Happy");
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }

        [Test]
        // Given Null Mood Should Return Happy
        public void GivenNullMoodShouldReturnHappy()
        {
            try
            {
                //expected string will be happy
                string expected = "Happy";
                //create a object of cass moodanalyzer with Null value
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
                //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual(MoodAnalyzerCustomException.ExceptionsType.NULL_MESSAGE, e.type);
            }
        }
        [Test]
        // [DataRow(" ")]
        public void GivenEmptyMood_ShouldThrow_MoodAnalysisEmptyTypeException()
        {
            try
            {
                //expected string will be happy
                string expected = "Happy";
                string message = "";
                //create a object of cass moodanalyzer with message value
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Message should not be Empty", e.Message);
            }
        }
        [Test]
        // [DataRow(null)]
        public void GivenNullMood_ShouldThrow_MoodAnalysisEmptyTypeException()
        {
            try
            {
                //expected string will be happy
                string expected = "Happy";
                string message = null;
                //create a object of cass moodanalyzer with message value
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {                                                                                                                                                                                        
                Assert.AreEqual("Message should not be Null", e.Message);
            }
        }
        [Test]
        public void GivenMooadAnalyzerClassName_WhenAnalyze_ShouldReturnObject()
        {
            object obj = new MoodAnalyzer(null);
            object actual = MoodAnalyzerReflection.CreateMoodAnalysis("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            //obj.Equals(actual);
            Assert.AreEqual(obj.GetType().Equals(actual.GetType()), true);
        }

    }
}