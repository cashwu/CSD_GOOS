using System.Web.Mvc;
using testGoos.Models;

namespace testGoos.Controllers
{
    public class HangmanController : Controller
    {
        public ActionResult Index()
        {
            var model = new HangmanViewModel
            {
                Tries = 12,
                Length = 4,
                Used = "AEIOU",
                Discovered = "_A__"
            };

            return View(model);
        }
    }
}