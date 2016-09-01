using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ForgingAhead.Models;

namespace ForgingAhead.Controllers
{

    public class CharacterController : Controller
    {
        // private gjør den kun tilgjengelig inni denne classen
        private readonly ApplicationDbContext _context;

        // Constructor injection
        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Constructor
        public CharacterController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            //ViewBag.Title = "Characters";
            ViewData["Title"] = "Characters";
            var model = _context.Characters.ToList(); // ToList() Gjør om Db-set til en List
            return View(model);
        }

        public ActionResult GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList(); // ToList() Gjør om Db-set til en List
            return View(model);
        }

        public ActionResult Details(string name)
        {
            var model = _context.Characters.FirstOrDefault(e => e.Name == name); // Returnere en enkelt karakter med Navn == navn
            return View(model);
        }

        public ActionResult Update(Character character)
        {
            _context.Entry(character).State = EntityState.Modified; // Forteller EF at dette er oppdatert / changed

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string name)
        {
            var original = _context.Characters.FirstOrDefault(e => e.Name == name); // Returnere en enkelt karakter med Navn == navn
            if (original != null)
            {
                _context.Characters.Remove(original);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        // GET: Character
        public ActionResult Create(Character character)
        {

            _context.Characters.Add(character);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}