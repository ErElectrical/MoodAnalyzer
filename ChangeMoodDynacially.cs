using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CustomEXception
{
    public class ChangeMoodDynacially
    {
       

        // what we have do

        // we have to change the mood dynamically using reflection 
        //for which we create a static method setfield
        // using this method we are able to do using fieldname 
        public static string SetField(string message,string fieldname)
        {
            // create a instance of moodanalyser class
            try
            {



                MoodAnalyzer mood = new MoodAnalyzer(message);

                // geting the type of class moodanalyses
                Type type = typeof(MoodAnalyzer);

                //now we have to store the fieldinfo on Fieldinfo attributes
                //Specifies flags that control binding
                //and the way in which the search for members and types is conducted by reflection.

                //now we have field info
                // we have to set the field value using this field info varilbe

                FieldInfo field = type.GetField(fieldname, BindingFlags.Public | BindingFlags.Instance);

                //set value of field for mood analyzer 

                field.SetValue(mood, message);

                // return the output
                return mood.AnalyzerMood();

            }
            // in catch block we will sorted out the scenerio of null 
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionTYpe.No_Such_Field," field  not found ");

            }
        }
    }
}
