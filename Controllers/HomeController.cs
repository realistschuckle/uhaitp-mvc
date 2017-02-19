using System.Collections.Generic;
using UhAitpMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace UhAitpMvc.Controllers
{
    public class HomeController : Controller
    {
        private static List<Human> humanDatabases;

        static HomeController()
        {
            humanDatabases = new List<Human>();
        }

        public IActionResult Index()
        {
            return View("Index", humanDatabases);
        }

        [HttpPost]
        public IActionResult Create(Human human)
        {
            humanDatabases.Add(human);
            return RedirectToAction("Index");
        }

        public IActionResult New()
        {
            return View("New");
        }

        public IActionResult Details(int id)
        {
            Human found = findHumanById(id);
            return View("Details", found);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Human found = findHumanById(id);
            humanDatabases.Remove(found);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Human found = findHumanById(id);
            return View("Edit", found);
        }

        [HttpPost]
        public IActionResult Update(int id, Human human)
        {
            Human found = findHumanById(id);
            found.Email = human.Email;
            found.Hobby = human.Hobby;
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }

        private Human findHumanById(int id)
        {
            Human found = null;
            foreach (Human human in humanDatabases)
            {
                if (human.Id == id)
                {
                    found = human;
                    break;
                }
            }
            return found;
        }
    }
}
