using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class RefactorConstructor
    {

        // field varibles
        private string msg;

        // no parametrised constructor

        public RefactorConstructor()
        {
            msg = "sad";
        }
        public RefactorConstructor(string message)
        {
            this.msg = message;
        }

        public string AnalyzeMood()
        {
            if (msg.Contains("sad"))
            {
                return "sad mood";
            }
            else
            {
                return "happy Mood";
            }
        }

    }
}
