using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBindingPage2.Controllers
{
    public class Items : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //TODO: Consum & Trinkets der na hinzufügen und views erstellen
        public IActionResult Consumables()
        {
            return View();
        }
        public IActionResult Trinkets()
        {
            return View();
        }
    }
}
