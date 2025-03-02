using MusiCodeWebApp.Areas.ManagerPanel.Filters;
using MusiCodeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusiCodeWebApp.Areas.ManagerPanel.Controllers
{
    [ManagerLoginRequiredFilter]
    public class CategoryController : Controller
    {
        DBModel db = new DBModel();
        public ActionResult Index()
        {
            return View(db.Categories.Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid) 
            {
                try 
                {
                    db.Categories.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Category");
                }
                catch
                {
                    ViewBag.Error = "Bir hata oluştu";
                }

            }
            return View(model);
        }
    }
}