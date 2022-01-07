using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CustomEXception
{
    public class MoodAnalyzerparameterconstructor
    {

        public static object ParameterConstructor(string classname,string Constructorname,string msg)
        {

            // our task is to create MoodAnalyzer object with parameter constructor.
            // and returns the object of that class
            // this operator is used to get the System.Type object for a type.
            // This operator takes the Type itself as an argument and returns the marked type of the argument. 

            // storing the type of MoodAnalyzer.
            // as mood anaalyzer is a class than the value it have is a class type
            Type type = typeof(MoodAnalyzer);

            // put a condition to verify the class 
            if (type.Name.Equals(classname) || type.FullName.Equals(classname))
            {

                // as classname and constructor name is same 
                // we are checking weather the constructorname is same as the value stored in the type varible
                if (type.Equals(Constructorname))
                {

                    // choose an array because constructor can be multiple
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });

                    // create a instance of mood analyser class by passing a parameter .
                    object instance = ctor.Invoke(new object[] {msg });
                    return instance;




                }
                else
                {
                    throw new CustomException(CustomException.ExceptionTYpe.No_Such_Method, "constructor is not found ");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionTYpe.No_Such_class, "class not found ");
            }
        }
    }
}
