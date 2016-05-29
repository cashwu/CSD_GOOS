using System.Web.Mvc;
using testGoos.Models;

namespace testGoos.Controllers
{
    public class HangmanController : Controller
    {
        public ActionResult Index(string word)
        {
            var model = new HangmanViewModel
            {
                Tries = 12,
                Length = word.Length,
                Used = "AEIOU",
                Discovered = "_A__"
            };

            return View(model);
        }
    }
}