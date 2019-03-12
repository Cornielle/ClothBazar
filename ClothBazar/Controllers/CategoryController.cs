using ClothBazar.Entities;
using ClothBazar.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClothBazar.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoriesService categoryService = new CategoriesService();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
       {
            categoryService.SaveCategory(category);

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("Index"); 
        }
    }
}