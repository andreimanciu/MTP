﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laborator5.Models;

namespace Laborator5.Controllers
{
    public class ClientiController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Clienti
        public ActionResult Index(string nume)
        {
            var clienti = from c in db.Clienti
                          select c;
            if (!String.IsNullOrEmpty(nume))
            {
                clienti = clienti.Where(c => c.Nume.Contains(nume));
            }
            return View(clienti);
        }

        // GET: Clienti/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clienti.Find(id);

            // Data nasterii si varsta
            DateTime dataNasterii = new DateTime(Convert.ToInt32(client.CNP.Substring(1, 2)),
                                                 Convert.ToInt32(client.CNP.Substring(3, 2)),
                                                 Convert.ToInt32(client.CNP.Substring(5, 2)));
            int varsta = DateTime.Now.Year - dataNasterii.Year;

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Clienti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clienti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientId,Nume,CNP,Adresa,Telefon")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clienti.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Clienti/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clienti.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clienti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientId,Nume,CNP,Adresa,Telefon")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clienti/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clienti.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clienti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Clienti.Find(id);
            db.Clienti.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
