using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomEXception;

namespace TestProjectCustomException

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_EmptyMood_Should_Throw_MoodAnalysisException_indicating_EmptyMood()
        {
            try
            {

                string message = "";
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string output = mood.AnalyzerMood();


            }
            catch (CustomException ex)
            {

                Assert.AreEqual("Mood should not be empty", ex.Message);
            }




        }
        public void Given_EmptyMood_Should_Throw_MoodAnalysisException_indicating_NullMood()
        {
            try
            {

                string message = null;
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string output = mood.AnalyzerMood();


            }
            catch (CustomException ex)
            {

                Assert.AreEqual("Mood should not be null", ex.Message);
            }




        }

        // test case for uc4
        //object are same or not
        //MoodAnalyzerFactory
        public void GivenMoodAnalyzerclassname_should_return_MoodAnalyzer_object()
        {
            // we have to check weather the object of mood analyzer class
            // or object that is returned by moodanalyzerfactory class is same or not.


            //create a null msg varible so that constructor of class mood analyzer can be initated
            string msg = null;

            object expected = new MoodAnalyzer(msg);

            // use mood analyzer factory to create object

            object obj = (MoodAnalyzer)MoodAnalyzerFactory.CreateMoodAnalyser("CustomEXception.MoodAnalyzer", "MoodAnalyzer");

            //check by equals to method weather both are same or not.

            expected.Equals(obj);

            //equals check weather the value of object is same or not
            // to pass this test case we have to do type casting
        }

        // uc4_testcase if class is different than exception is thrown or not
        public void GivenMoodAnalyzerclassname_should_return_Exception_ifclassname_isnot_proper()
        {
            // we have to check weather the object of mood analyzer class
            // or object that is returned by moodanalyzerfactory class is same or not.


            //create a null msg varible so that constructor of class mood analyzer can be initated
            string msg = null;

            object expected = new MoodAnalyzer(msg);

            // use mood analyzer factory to create object

            // to pass this test case we provide other class name to it where we are expecting constructor for
            //moodanalyzer in this case an exception has been thrown from moodanalyzer factory
            // of no such class

            var result = MoodAnalyzerFactory.CreateMoodAnalyser("CustomEXception.Program", "MoodAnalyzer");

            //check by equals to method weather both are same or not.

            Assert.AreEqual("class not found", result);

            //equals check weather the value of object is same or not
            // to pass this test case we have to do type casting


            public void GivenMoodAnalyzerclassname_should_return_Exception_ifclassname_isnot_proper()
            {
                // we have to check weather the object of mood analyzer class
                // or object that is returned by moodanalyzerfactory class is same or not.


                //create a null msg varible so that constructor of class mood analyzer can be initated
                string msg = null;

                object expected = new MoodAnalyzer(msg);

                // use mood analyzer factory to create object

                // to pass this test case we provide constructor name of other class  to it where we are expecting
                // constructor for
                //moodanalyzer in this case an exception has been thrown from moodanalyzer factory
                // of no such class

                var result = MoodAnalyzerFactory.CreateMoodAnalyser("CustomEXception.MoodAnalyzer", "CustomException");

                //check by equals to method weather both are same or not.

                Assert.AreEqual("Constructor is not found", result);

                //equals check weather the value of object is same or not
                // to pass this test case we have to do type casting.
            }




        }
    }
}