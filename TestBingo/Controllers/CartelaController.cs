using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestBingo.Context;
using TestBingo.Models;

namespace TestBingo.Controllers
{
    public class CartelaController : Controller
    {
        private Random rand = new Random();
        private BingoContext db = new BingoContext();

        // GET: Cartela
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cartela/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cartela cartela = db.Cartela.Find(id);
            if (cartela == null)
            {
                return HttpNotFound();
            }
            return View(cartela);
        }

        public JsonResult GetSorteio(int quantidade)
        {
            List<Sorteio> listSorteio = new List<Sorteio>();
            Sorteio Sorteio = new Sorteio();
            for (int i = 0; i < quantidade; i++)
            {
                Sorteio = new Sorteio();
                Sorteio.Numero = rand.Next(5,70);
                listSorteio.Add(Sorteio);
            }

            return Json(listSorteio, JsonRequestBehavior.AllowGet);
        }

        // GET: Cartela/Create
        public ActionResult Create()
        {
            Cartela Cartela = new Cartela();
            List<Cartela> listCartela = new List<Cartela>();

            for (int i = 1; i <= 100; i++)
            {

                Cartela = new Cartela();

                Cartela.CodigoTabela = i;

                Cartela.Campo1 = rand.Next(1, 4);

                Cartela.Campo2 = rand.Next(4, 8);

                Cartela.Campo3 = rand.Next(8, 12);

                Cartela.Campo4 = rand.Next(12, 16);

                Cartela.Campo5 = rand.Next(16, 20);

                Cartela.Campo6 = rand.Next(20, 24);

                Cartela.Campo7 = rand.Next(24, 28);

                Cartela.Campo8 = rand.Next(28, 32);

                Cartela.Campo9 = rand.Next(32, 36);

                Cartela.Campo10 = rand.Next(36, 40);

                Cartela.Campo11 = rand.Next(40, 44);

                Cartela.Campo12 = rand.Next(44, 48);

                Cartela.Campo13 = rand.Next(48, 52);

                Cartela.Campo14 = rand.Next(52, 56);

                Cartela.Campo15 = rand.Next(56, 71);

                listCartela.Add(Cartela); 
            }
            
            return View(listCartela);
        }

        // POST: Cartela/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CartelaId,CodigoTabela,Campo1,Campo2,Campo3,Campo4,Campo5,Campo6,Campo7,Campo8,Campo9,Campo10,Campo11,Campo12,Campo13,Campo14,Campo15")] Cartela cartela)
        {
            if (ModelState.IsValid)
            {
                db.Cartela.Add(cartela);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartela);
        }

        // GET: Cartela/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cartela cartela = db.Cartela.Find(id);
            if (cartela == null)
            {
                return HttpNotFound();
            }
            return View(cartela);
        }

        // POST: Cartela/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CartelaId,CodigoTabela,Campo1,Campo2,Campo3,Campo4,Campo5,Campo6,Campo7,Campo8,Campo9,Campo10,Campo11,Campo12,Campo13,Campo14,Campo15")] Cartela cartela)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cartela).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cartela);
        }

        // GET: Cartela/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cartela cartela = db.Cartela.Find(id);
            if (cartela == null)
            {
                return HttpNotFound();
            }
            return View(cartela);
        }

        // POST: Cartela/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cartela cartela = db.Cartela.Find(id);
            db.Cartela.Remove(cartela);
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
