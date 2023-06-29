using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnlyserProblem
{
    public class Mood
    {
        string message;
        public Mood(string Message)
        {
            this.message = Message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)  //Exception Handling
            {
                return "happy";
            }

        }
    }
}
