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
        }

        // uc4_if method is not found than should thrown exception of metthod not found from custom class
        public void GivenMoodAnalyzerclassname_should_return_Exception_ifclassname_isnot_properusing_exception()
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
        // testcase uc5
        // in this case what we have to do is that test class returns a object 
        // and in our test case we expilicitly creates a object of class
        // further we matchs them weather both are same or not using equals.
        // we have to do typecasting here should that the test case should have passed.

        public void GiveMoodAnalyzerclassname_should_return_aMoodAnalyzerObject_using_parametrised_constructor()
        {
            // craete an object of Mood_AnalyzerClass explicitly
            // by passing happy string
            object expected = new MoodAnalyzer("happy");

            //calling for objct to our class

            object real = (MoodAnalyzer)MoodAnalyzerparameterconstructor.ParameterConstructor("CustomEXception.MoodAnalyzerparameterconstructor", "MoodAnalyzer", "happy");
            expected.Equals(real);
        }

        // test case 5.2
        // throw custom exception of class not found using parameter constructor
       public void  GiveMoodAnalyzerclassname_should_return_exception_ifClassNameisnotProper_using_parametrised_constructor()
        {
            //Arrange
            //create msg 
            string msg = "sad";

            string output =(string)MoodAnalyzerparameterconstructor.ParameterConstructor("CustomEXception.Program", "MoodAnalyzer", "happy");

            // Assert are equal or not

            Assert.AreEqual("class not found", output);




        }
        // test case 5.3
        // throw custom exception of method not found using parameter constructor

        public void GiveMoodAnalyzerclassname_should_return_exception_ifConstructornameisnot_Proper_using_parametrised_constructor()
        {
            //Arrange
            //create msg 
            string msg = "sad";

            //passing wrong constructor to pass the test case

            string output = (string)MoodAnalyzerparameterconstructor.ParameterConstructor("CustomEXception.MoodAnalyzer","CustomException", "happy");

            // Assert are equal or not

            Assert.AreEqual("class not found", output);




        }

        //Test case for Uc6
        //using reflection to pass happy msg and 
        // return happy mood if proper

        public void GivenHappyShouldReturnHappy()
        {
            string expected = "happy Mood";

            object mood = MoodAnalyzerReflactor.InvokeAnalyseMood("happy", "CustomEXception.MoodAnalyzer.AnalyzerMood");

            Assert.AreEqual(expected, mood);


        }

        //test case Uc6.2
        // Happy msg with improper method should return a MoodAnalysis Exception

        public void GivenHappy_Msg_With_unproper_Methodname_should_return_Exception()
        {

            //what to do
            // create a string msg varible for parameter of InvokeAlanyzemood method.
            // than compare the exception
            string msg = "happy";

            object mood=(string)MoodAnalyzerReflactor.InvokeAnalyseMood("happy", "CustomEXception.Program.AnalyzerMood");

            Assert.AreEqual("Method not found", mood);
        }
        // test case for Uc7
        //what we have to do we will set the field values using reflection
        //and invoke using reflection
        //and than Assert happy mood.

        public void Set_Happy_Message_With_Reflactor_returns_happyMood()
        {
            // Fields are nothing but varibles that is decleared inside a class or struct
            // so by passing set field what basically we are doing is that we set the value for varible message
            string result = ChangeMoodDynacially.SetField("happy", "message");

            // checking the result is same as our assumption or not 
            Assert.AreEqual("happy Moood", result);

        }

        // test case for Uc7 
        // what we have to do 
        // when set field is improper it should return a exception no_such_field

        public void Set_Improper_field__With_Reflactor_returns_fieldException()
        {
            // Fields are nothing but varibles names that is decleared inside a class or struct
            // so by passing set field what basically we are doing is that we set the value for varible message
            // we pass that field which is not in existance
            string result = ChangeMoodDynacially.SetField("happy", "program");

            // checking the result is same as our assumption or not 
            Assert.AreEqual("field  not found", result);

        }

        // test case for Uc7
        //what we have to do
        // we have to check what happens if we pass null to message

        public void Set_nullmsg__With_Reflactor_returns_nullexception()
        {
            // Fields are nothing but varibles names that is decleared inside a class or struct
            // so by passing set field what basically we are doing is that we set the value for varible message
            // we pass that field which is not in existance
            string result = ChangeMoodDynacially.SetField(null, "program");

            // checking the result is same as our assumption or not 
            Assert.AreEqual("Mood should not be null", result);

        }

    }
    }
