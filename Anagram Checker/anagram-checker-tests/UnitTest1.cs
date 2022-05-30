using NUnit.Framework;

namespace anagram_checker_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBelowElbowIsAnagram()
        {
            var word1 = "below";
            var word2 = "elbow";

            var anagram = new AnagramHelper();
            Assert.True(anagram.isAnagram(word1, word2));
        }

        [Test]
        public void TestDesertStressedIsNotAnagram()
        {
            var word1 = "dessert";
            var word2 = "stressed";

            var anagram = new AnagramHelper();
            Assert.False(anagram.isAnagram(word1, word2));
        }

        [Test]
        public void TestDesertStresedIsAnagram()
        {
            var word1 = "dessert";
            var word2 = "stresed";

            var anagram = new AnagramHelper();
            Assert.True(anagram.isAnagram(word1, word2));
        }
    }
}