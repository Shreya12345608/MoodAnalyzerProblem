using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    /// <summary>
    /// MoodAnalysisException Class For Handling Exception.
    /// </summary>
    public class MoodAnalyzerCustomException : Exception
    {
        /// <summary>
        /// Enum for Exception Type.
        ///  An enum is a special "class" that represents a group of constants
        /// </summary>
        public enum ExceptionsType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
        }
        ////Creating 'type' variable of type ExceptionType
        public ExceptionsType type;
        /// <summary>
        /// Parameterized Constructor sets the Exception Type and message.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public MoodAnalyzerCustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
