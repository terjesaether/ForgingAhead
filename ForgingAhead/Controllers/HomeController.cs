using ForgingAhead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForgingAhead.Controllers
{
    public class HomeController : Controller
    {
        // private gjør den kun tilgjengelig inni denne classen
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = new context();
        //}

        // GET: Home
        public ActionResult Index()
        {
            var model = _context.Characters.Where(m => m.IsActive).ToList();
            return View(model);
        }
    }
}