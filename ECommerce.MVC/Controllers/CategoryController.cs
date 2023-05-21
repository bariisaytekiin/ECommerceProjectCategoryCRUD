using ECommerce.BLL.AbstractService;
using ECommerce.DAL.Contex;
using ECommerce.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            
            return View(_categoryService.GetAllCategory());//Tolist vermediğimiz için hata verdi.Genel tipi verdi.
        }

        public IActionResult Creat() 
        {
        return View();
        }
        [HttpPost]
        public IActionResult Creat(Category category)
        {
            _categoryService.CreateCategory(category);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _categoryService.FindCategory(id);

            _categoryService.DeleteCategory(deleted);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var uptated=_categoryService.GetAllCategory().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }

    }
}
