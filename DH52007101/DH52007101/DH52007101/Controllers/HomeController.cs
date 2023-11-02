using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DH52007101.Models;

namespace DH52007101.Controllers {
    public class HomeController : Controller {
        //public string Index() {
        //    return "Hello from Index";
        //}

        public IActionResult Index(int id) {
            IndexModel model = new IndexModel();
            model.Message = "Chao cac ban " + id;
            ViewBag.n = "Hi ViewBag";
            //var n = Request.Form["ten"].ToString();

            return View(model);
        }

    }
}
