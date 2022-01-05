using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class NullMoodAnalyzer
    {
        private string msg;

        public NullMoodAnalyzer(string msg)
        {
            this.msg = msg;
        }
        public string AnalyzerMood()
        {
            try
            {
                if (msg.Contains("sad"))
                {
                    return "sad Mood";
                }
                else
                {
                    return "Happy Mood";
                }
            }
            catch
            {
                return "Happy Mood";

            }

        }
    }
}
