using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        public string AnalyseMood(string Mood)
        {
            if (Mood.ToLower().Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
        }
    }
}
