using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mood obj = new Mood();
            string ExpectedResult = "Sad";

            //Act
            string ActualResult = obj.AnalyseMood("I am in sad Mood");

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}