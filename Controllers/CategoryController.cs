using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2Crud.Models;

namespace WebApplication2Crud.Controllers
{
    public class CategoryController : Controller
    {
        CategoryDbContext database = new CategoryDbContext();
        // GET: Category
        public ActionResult Index()
        {
            return View(database.Categories.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var details = database.Categories.Where(x => x.id == id).FirstOrDefault();
            return View(details);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(Category Cata)
        {
            if (ModelState.IsValid)
            {
                database.Categories.Add(Cata);
                database.SaveChanges();

                return RedirectToAction("Index");
            }


            return View();

        }


        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var details = database.Categories.Where(x => x.id == id).FirstOrDefault();
            return View(details);
        }



        [HttpPost]
        public ActionResult Edit(Category data)
        {
            if (ModelState.IsValid)
            {
                database.Entry(data).State = System.Data.Entity.EntityState.Modified;
                database.SaveChanges();

                return RedirectToAction("Index");
            }


            return View();

        }


        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var details = database.Categories.Where(x => x.id == id).FirstOrDefault();
            return View(details);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                category = database.Categories.Where(x => x.id == id).FirstOrDefault();
                database.Categories.Remove(category);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
