using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Data;
using RepositoryPattern.Interfaces.Manager;
using RepositoryPattern.Manager;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    public class ProductController : Controller
    {
        //private readonly ApplicationDbContext _context;
        //private readonly IProductManager _pManager;
        private readonly ProductManager _productManager;
        public ProductController(ProductManager productManager)
        {
            
            _productManager= productManager;
        }
        
        public IActionResult Index() 
        {
            var list= _productManager.GetAll();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product) //here product object
        {
            string msg = "";
            bool isSaved= _productManager.Add(product);
            if (isSaved)
            {
               
                return RedirectToAction("Index");
               
            }
            else
            {
                msg = "Product saved failed";
            }
            ViewBag.Mgs=msg;
            return View(product);
        }
        //edit get method
        public IActionResult Edit(int id)
        {
            var product = _productManager.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //edit post method
        [HttpPost]
        public IActionResult Edit(Product product) //here product object
        {
            bool isupdate = _productManager.Update(product);
            if (isupdate)
            {

                return RedirectToAction("Index");

            }      
            return View(product);
        }
        public IActionResult Details(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //delete get method
        public IActionResult Delete(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //Delete post method
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(Product product) //here product object
        {
            bool isdelete = _productManager.Delete(product);
            if (isdelete)
            {

                return RedirectToAction("Index");

            }
            return View(product);
        }
    }
}
