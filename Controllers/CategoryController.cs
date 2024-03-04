using Batch47.Models;
using Microsoft.AspNetCore.Mvc;

namespace Batch47.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;
		public CategoryController(ApplicationDbContext db)
		{
			_db = db;
		}
		
		public IActionResult Index()
		{
			ViewData["Title"] = "Category";
			// ORM => Object Relational Mapping
			List<Category> categories = _db.Categories.ToList();
			return View(categories);
		}

		[HttpGet]
		public IActionResult Create()
		{
			// ViewData["Title"] = "Create New Category";
			ViewBag.Title = "Create New Company";
			return View();
		}

		[HttpPost]
		public IActionResult Create(Category cat)
		{
			_db.Categories.Add(cat);
			_db.SaveChanges();      // While INSERT/UPDATE/DELETE

			TempData["success"] = "Category added successfully";

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int? Id)
		{
			// select * from Categories where Id = 1 limit 1
			Category? cat = _db.Categories.Where(u => u.Id == Id).FirstOrDefault();
			ViewData["Title"] = "Update " + cat.Name + " details";
			return View(cat);
		}

		[HttpPost]
		public IActionResult Edit(Category cat)
		{
			_db.Categories.Update(cat);
			_db.SaveChanges();      // While INSERT/UPDATE/DELETE

			TempData["success"] = "Category updated successfully";
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Delete(int? Id)
		{
			// select * from Categories where Id = 1 limit 1
			Category? cat = _db.Categories.Where(u => u.Id == Id).FirstOrDefault();
			ViewData["Title"] = "Do you want delete " + cat.Name + " details?";
			return View(cat);
		}

		[HttpPost]
		public IActionResult Delete(Category cat)
		{
			_db.Categories.Remove(cat);
			_db.SaveChanges();      // While INSERT/UPDATE/DELETE

			TempData["success"] = "Category deleted successfully";

			// Sessions are SUPER GLOBAL VARIABLES
			// Short Time Session
			// Keeps data for the time of HTTP Request

			return RedirectToAction("Index");
		}
	}
}
