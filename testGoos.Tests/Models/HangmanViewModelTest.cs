using NUnit.Framework;
using testGoos.Models;

namespace testGoos.Tests.Models
{
    public class HangmanViewModelTest
    {
        [Test]
        public void GameStart()
        {
            var word = "cash";
            var model = new HangmanViewModel(word);

            Assert.AreEqual(12, model.Tries);
            Assert.AreEqual(4, model.Length);
            Assert.AreEqual("aeiou", model.Used);
            Assert.AreEqual("_a__", model.Discovered);
        }
    }
}
