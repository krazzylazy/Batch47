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
			List<Category> categories = _db.Categories.ToList();
			return View(categories);
		}

		[HttpGet]
		public IActionResult Create()
		{
			ViewData["Title"] = "Create New Category";
			return View();
		}

		[HttpPost]
		public IActionResult Create(Category cat)
		{
			_db.Categories.Add(cat);
			_db.SaveChanges();		// While INSERT/UPDATE/DELETE
			return Redirect("Index");
		}

		public IActionResult Edit()
		{
			return View();
		}
	}
}
