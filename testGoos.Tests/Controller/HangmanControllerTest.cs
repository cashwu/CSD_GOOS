using NUnit.Framework;
using System.Web.Mvc;
using testGoos.Controllers;
using testGoos.Models;

namespace testGoos.Tests.Controller
{
    public class HangmanControllerTest
    {
		[Test]
        public void Hangman_GameStart()
		{
		    var word = "cash";
            var controller = new HangmanController();
			
		    var result = controller.Index(word);

		    var viewResul = result as ViewResult;
		    var viewModel = viewResul.Model as HangmanViewModel;

			Assert.AreEqual(12, viewModel.Tries);
			Assert.AreEqual(4, viewModel.Length);
			Assert.AreEqual("AEIOU", viewModel.Used);
			Assert.AreEqual("_A__", viewModel.Discovered);
        }
    }
}
