using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CustomEXception
{
   public  class MoodAnalyzerFactory
    {
        public static Object CreateMoodAnalyser(string classname,string constructorname)
        {
            //create a regex pattern before constructor and class name 

            
            string Pattern = @"," + constructorname + "$";

            //checking class name with our regex pattern
            Match result= Regex.Match(Pattern, classname);

            if (result.Success)
            {
                try

                {
                    // Assembly class usese to get current excuting class
                    Assembly excuting = Assembly.GetExecutingAssembly();

                    // making an type varible to store the type of constructor the class have
                    Type MoodAnalyzer = excuting.GetType(constructorname);
                    
                    // cretae instance of the class and return it

                    return Activator.CreateInstance(MoodAnalyzer);

                }
                catch(ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionTYpe.No_Such_class, "class not found");

                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionTYpe.No_Such_Method, "Constructor is not found");
            }

            


        }
    }
}
