﻿using System.Web.Mvc;
using testGoos.Models;

namespace testGoos.Controllers
{
    public class HangmanController : Controller
    {
        public ActionResult Index(string word)
        {
            var model = new HangmanViewModel(word);

            return View(model);
        }
    }
}