using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem");
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            Console.WriteLine(moodAnalyzer.AnalyzeMood());
        }

    }
}
