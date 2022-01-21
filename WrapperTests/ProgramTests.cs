//
// WrapperTests
//
namespace Wrapper.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    /// <summary>
    /// The program tests.
    /// </summary>
    [TestClass()]
    public class WrapperTests
    {
        /// <summary>
        /// Does the not break words.
        /// </summary>
        [TestMethod()]
        public void ColumnsNumberGreaterThanWordLength()
        {
            var result = Wrapper.Wrap("repeat repeat", 8);            
            string[] baseline= { "repeat", "repeat" };
            Assert.IsTrue(Enumerable.SequenceEqual(baseline, result));
        }

        /// <summary>
        /// Breaks the words.
        /// </summary>
        [TestMethod()]
        public void ColumnsNumberLowerThanWordLength()
        {
            var result = Wrapper.Wrap("repeat repeat", 3);
            string[] baseline = { "rep", "eat", "rep", "eat" };
            Assert.IsTrue(Enumerable.SequenceEqual(baseline, result));
        }

        /// <summary>
        /// Columns the number lower than words in sentence length.
        /// </summary>
        [TestMethod()]
        public void ColumnsNumberLowerThanWordsInSentenceLength()
        {
            var result = Wrapper.Wrap("This is a test string.", 2);
            string[] baseline = { "Th", "is", "is", "a", "te", "st", "st", "ri", "ng", "." };
            Assert.IsTrue(Enumerable.SequenceEqual(baseline, result));
        }

        /// <summary>
        /// Columns the number greater than words in sentence length.
        /// </summary>
        [TestMethod()]
        public void ColumnsNumberGreaterThanWordsInSentenceLength()
        {
            var result = Wrapper.Wrap("This is a test string.", 7);
            string[] baseline = { "This", "is", "a", "test", "string."};
            Assert.IsTrue(Enumerable.SequenceEqual(baseline, result));
        }
    }
}