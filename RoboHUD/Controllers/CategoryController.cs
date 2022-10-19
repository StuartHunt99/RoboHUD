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

		// GET: /<controller>/
		public IActionResult Index()
		{
			IEnumerable<Category> objCategoryList = _db.Categories;
			return View(objCategoryList);
		}
	}
}

