using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerUnittest
{
    [TestClass]
    public class UnitTest1
    {
        //create a instance for algorithum class
        private readonly MoodAnalyzer.MoodAnalyzer Program;

        private readonly MoodAnalyzer.RefactorConstructor refactor;

        // constructor of class our class

        public UnitTest1()
        {
            Program = new MoodAnalyzer.MoodAnalyzer();
            refactor = new MoodAnalyzer.RefactorConstructor();
        }

        [TestMethod]

        // Test case 1
        public void TestMethod1()
        {
            //Arrange
            string input = "I am in sad mood";
            //Act
            var result = Program.AnalyzeMood(input);

            //Assert

            Assert.AreEqual("sad Mood", result);

        }


        //Test case 2
        public void TestMethod2()
        {
            //Arrange
            string input = "I am in any mood";
            //Act
            var result = Program.AnalyzeMood(input);

            //Assert

            Assert.AreEqual("Happy Mood", result);


        }

        //Test case1 for Refactor constructor
        public void TestMethod3_RefactorConstructor()
        {
            // Arrange 
            string input = " I am in sad Mood";

            RefactorConstructor refector = new RefactorConstructor(input);

            //Act

            var result = refactor.AnalyzeMood();

            //Assert
            Assert.AreEqual("sad mood", result);

        }

        //Test case2 for refactor constructor
        public void TestMethod4_RefactorConstructor()
        {
            // Arrange 
            string input = " I am in happy Mood";

            RefactorConstructor refector = new RefactorConstructor(input);

            //Act

            var result = refactor.AnalyzeMood();

            //Assert
            Assert.AreEqual("happy mood", result);

        }

        public void TestMethod_NullMood()
        {

            string expected = "Happy Mood";
            string input = null;

            NullMoodAnalyzer mood = new NullMoodAnalyzer(input);

            var result = mood.AnalyzerMood();

            Assert.AreEqual(expected, result);
        }
    }
}