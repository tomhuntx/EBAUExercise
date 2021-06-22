using EBAUExercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace EBAUExercise.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ViewOrders()
		{
			Repository.SampleDataRepository db = new();
			ListModel<CustomerOrder> orders = new(db.GetDataset);

			return View("Index", orders);
		}

		[HttpPost]
		public ActionResult ViewOrdersByCustomer()
		{
			Repository.SampleDataRepository db = new();
			ListModel<CustomerOrder> orders = new(db.GetDataset);

			return View("Index", orders);
		}

		[HttpPost]
		public ActionResult ViewOrdersByDate()
		{
			Repository.SampleDataRepository db = new();
			ListModel<CustomerOrder> orders = new(db.GetDataset);

			return View("Index", orders);
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
