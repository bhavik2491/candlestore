using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_2.Models;
using System.IO;

namespace MVC_2.Controllers
{
    public class CandlesController : Controller
    {
        private candlestore db = new candlestore();

        // GET: Candles
        public ActionResult Index()
        {
            var candle = db.Candle.Include(c => c.catagories);
            return View(candle.ToList());
        }

        // GET: Candles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candles candles = db.Candle.Find(id);
            if (candles == null)
            {
                return HttpNotFound();
            }
            return View(candles);
        }

        // GET: Candles/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Candles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandlesId,catagory,name,photo,description,price,shortdecription,Updatedate,qty,CategoryId")] Candles candles)
        {
            if (ModelState.IsValid)
            {
                db.Candle.Add(candles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", candles.CategoryId);
            return View(candles);
        }

        // GET: Candles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candles candles = db.Candle.Find(id);
            if (candles == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", candles.CategoryId);
            return View(candles);
        }

        // POST: Candles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandlesId,catagory,name,photo,description,price,shortdecription,Updatedate,qty,CategoryId")] Candles candles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", candles.CategoryId);
            return View(candles);
        }

        // GET: Candles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candles candles = db.Candle.Find(id);
            if (candles == null)
            {
                return HttpNotFound();
            }
            return View(candles);
        }

        // POST: Candles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candles candles = db.Candle.Find(id);
            db.Candle.Remove(candles);
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
        [HttpPost]
        public ActionResult UploadImages(HttpPostedFileBase[] uploadImages,int id)
        {
            Candles cd = db.Candle.Find(id);
            if (uploadImages.Count() <= 1)
            {
                return RedirectToAction("");
            }

            foreach (var image in uploadImages)
            {
               // if (image.ContentLength > 0)
                //{
                    //byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(image.InputStream))
                    {
                        cd.photo = binaryReader.ReadBytes(image.ContentLength);
                 //   }

                   

                   // imageRepository.AddHeaderImage(headerImage);
                }
            }
            return RedirectToAction("BrowseImages");
        }

     /*   private class HeaderImage
        {
            public byte[] photo { get; set; }
            public bool IsActive { get; set; }
        }*/
    }
}
