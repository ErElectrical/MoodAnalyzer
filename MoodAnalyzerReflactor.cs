using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomEXception
{
    public class MoodAnalyzerReflactor
    {

        // what we have to do 
        // Invoke method using Reflection technique
        public static string InvokeAnalyseMood(string message,string methodname)
        {
            // store type of MoodAnalyzer class
            try
            {
                Type type = Type.GetType("CustomEXception.MoodAnalyzer");

                // create a object for moodanalyzer class 

                object moodanalyseobject = CustomEXception.MoodAnalyzerparameterconstructor.ParameterConstructor("CustomEXception.MoodAnalyzer", "MoodAnalyzer", "happy");

                // now catch the type of method name.
                //create a instance of methodinfo class and store the type of methodname 

                MethodInfo method = type.GetMethod(methodname);

                // now Invoke Moodanalyzer object from method

                object obj = method.Invoke(moodanalyseobject, null);

                // return the method object in string form

                return obj.ToString();

            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionTYpe.No_Such_Method, "Method not found ");
            }
            







        }
    }
}
