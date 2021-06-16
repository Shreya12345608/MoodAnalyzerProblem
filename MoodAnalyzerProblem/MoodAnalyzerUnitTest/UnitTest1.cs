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

    }
}
