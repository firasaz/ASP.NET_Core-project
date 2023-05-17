using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryController(ApplicationDBContext db)
        {
            _dbContext = db;
        }

        public IActionResult Index()
        {
            var cat_obj = _dbContext.Category.ToList();
            return View(cat_obj);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryModel obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString()) 
            {
                ModelState.AddModelError("CustomError", "Name and Display Order cannot be the same.");
            }
            if(ModelState.IsValid) 
            {
                _dbContext.Category.Add(obj);
                _dbContext.SaveChanges();
                TempData["success"] = "Category Created Succesfully!";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var cat_row = _dbContext.Category.Find(id);
            //var cat_row_First = _dbContext.Category.FirstOrDefault(u=>u.ID == id); // same syntax for SingleOrDefault.

            if(cat_row == null) { return NotFound(); }

            return View(cat_row);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryModel obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "Name and Display Order cannot be the same.");
            }
            if (ModelState.IsValid)
            {
                _dbContext.Category.Update(obj);
                _dbContext.SaveChanges();
                TempData["success"] = "Category Updated Succesfully!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var cat_row = _dbContext.Category.Find(id);
            //var cat_row_First = _dbContext.Category.FirstOrDefault(u=>u.ID == id); // same syntax for SingleOrDefault.

            if (cat_row == null) { return NotFound(); }

            return View(cat_row);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCat(int? id)
        {
            var obj = _dbContext.Category.Find(id);
            if(obj == null)
            {
                return NotFound();
            }

            _dbContext.Category.Remove(obj);
            _dbContext.SaveChanges();
            TempData["success"] = "Category Deleted Succesfully!";
            return RedirectToAction("Index");
        }
    }
}
