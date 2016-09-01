using ForgingAhead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForgingAhead.Controllers
{
    public class QuestController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor
        public QuestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public QuestController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var model = _context.Quests.Where(m => m.IsActive).ToList();
            ViewData["Title"] = "Quests away";
            return View(model);
        }

        // GET: Quest
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Quest quest)
        {
            //Save Quest to Database Here
            _context.Quests.Add(quest);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}