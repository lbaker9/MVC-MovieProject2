using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalMovieProject.Models;

namespace FinalMovieProject.Controllers
{
    public class MoviesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Movies
        public ActionResult Index()
        {
            return View("~/Views/Movies/Index.cshtml");
        }

        public ActionResult getMovies(string searchString)
        {
            var movies = from m in db.Movies
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));

            }
           
            return Json(movies, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details()
        {
            return View("~/Views/Movies/Details.cshtml");
        }

        // GET: Movies/Details/5
        public ActionResult GetDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return Json(movie, JsonRequestBehavior.AllowGet);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View("~/Views/Movies/Create.cshtml");
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult PostCreate(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("~/Views/Movies/Index.cshtml");
        }

        public ActionResult Edit()
        {
            return View("~/Views/Movies/Edit.cshtml");
        }

        // GET: Movies/Edit/5
        public ActionResult GetEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            
            return Json(movie, JsonRequestBehavior.AllowGet);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult PostEdit( Movie movie)
        {

                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();


            
            
            return View("~/Views/Movies/Index.cshtml");
        }

        public ActionResult Delete()
        {
            return View("~/Views/Movies/Delete.cshtml");
        }

        // GET: Movies/Delete/5
        public ActionResult GetDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return Json(movie, JsonRequestBehavior.AllowGet);
        }

        // POST: Movies/Delete/5
        [HttpPost]
       
        public ActionResult PostDelete(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return View("~/Views/Movies/Index.cshtml");
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
