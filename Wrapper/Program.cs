//
// Wrapper: breaks or wraps a string and words
//
namespace Wrapper
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Wrapper.
    /// </summary>
    public class Wrapper
    {
        /// <summary>
        /// Error message.
        /// </summary>
        private static readonly string error = "Invalid input!";

        /// <summary>
        /// Main function.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a word/sentence:");
            var word = Console.ReadLine();

            if (word == null || word.GetType() != typeof(string))
            {
                Console.WriteLine(error);
                return;
            }

            Console.WriteLine("Enter a integar:");
            var number = Console.ReadLine();

            if (number == null || int.TryParse(number, out int columnNumber) == false || columnNumber <= 0)
            {
                Console.WriteLine(error);
                return;
            }

            Console.Write(string.Join(Environment.NewLine, Wrap(word, columnNumber)));
        }

        /// <summary>
        /// Wraps/breaks the string and words based on column size
        /// </summary>
        /// <returns>A string.</returns>
        public static IEnumerable<string> Wrap(string word, int columnNumber)
        {            
            var result=new List<string>();
            var words = word.Split(' ');
            foreach (var w in words)
            {
                for (var i = 0; i < w.Length; i += columnNumber)
                {
                    result.Add(w.Substring(i, Math.Min(columnNumber, w.Length - i)));
                }
            }
            return result;
        }
    }
}
