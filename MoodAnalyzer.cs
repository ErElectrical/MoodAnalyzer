using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomEXception

{
    public class MoodAnalyzer
    {
        private string msg;

        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }
         
        public String AnalyzerMood()
        {
            try
            {
                if(this.msg.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionTYpe.Empty_Message, "Mood should not be empty");
                }
                if (this.msg.Contains("sad"))
                {
                    return "sad Mood";
                }
                else
                {
                    return "happy Moood";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionTYpe.Null_Message, "Mood should not be null");
            }
        }
    }
}
