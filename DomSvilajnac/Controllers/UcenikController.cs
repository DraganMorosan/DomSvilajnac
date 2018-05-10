using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomSvilajnac.Models;
using DbContext = DomSvilajnac.Models.DbContext;

namespace DomSvilajnac.Controllers
{
    public class UcenikController : Controller
    {
        private DbContext context;

        public UcenikController()
        {
              context = new DbContext();
        }
        // GET: DbContext
        public ActionResult Index()
        {
            return View(context.Ucenici.ToList());
        }

        // GET: DbContext/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Ucenici.FirstOrDefault(m => m.Id == id));
        }

        // GET: DbContext/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DbContext/Create
        [HttpPost]
        public ActionResult Create(Ucenik ucenik)
        {
            try
            {
                context.Ucenici.Add(ucenik);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DbContext/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DbContext/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ucenik ucenik)
        {
            try
            {
                context.Entry(ucenik).State = EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DbContext/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Ucenici.FirstOrDefault(m => m.Id == id));
        }

        // POST: DbContext/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Ucenik ucenik = context.Ucenici.FirstOrDefault(x => x.Id == id);
                context.Ucenici.Remove(ucenik);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
