using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalyzer
    {
        public string AnalyzeMood(string msg)
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
    }
}
