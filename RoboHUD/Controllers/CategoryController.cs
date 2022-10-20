using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoboHUD.Data;
using RoboHUD.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoboHUD.Controllers
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
			IEnumerable<Category> objCategoryList = _db.Categories;
			return View(objCategoryList);
		}

		// GET: /<controller>/
		public IActionResult Create()
		{

			return View();
		}

		//POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Category obj)
		{
			if (obj.Name == obj.DisplayOrder.ToString())
			{
				ModelState.AddModelError("Name", "The DisplayOrder cannot exactly match the Name.");
			}

			if (ModelState.IsValid)
			{
				_db.Categories.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(obj);
		}
	}
}

