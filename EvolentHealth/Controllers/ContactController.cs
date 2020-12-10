using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvolentHealth.AppDbContext;
using EvolentHealth.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvolentHealth.Controllers
{
    public class ContactController : Controller
    {
        private readonly EvolentHealthDbContext _db;
        public ContactController(EvolentHealthDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Contacts.ToList());
        }

        public IActionResult Create()
        {
            Contact contact = new Contact();
            return View(contact);
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _db.Add(contact);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var contact = _db.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            _db.Contacts.Remove(contact);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var contact = _db.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _db.Update(contact);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
        }
    }
}