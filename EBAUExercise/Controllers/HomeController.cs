using EBAUExercise.Models;
using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
			Repository.SampleDataRepository db = new();
			OrderReports reports = new()
			{
				CustomerOrders = new(db.GetDataset),
				OrdersByCustomer = new(new ReportService(db).CustomerReport()),
				OrdersByDate = new(new ReportService(db).StoreDailyReport())
			};

			return View(reports);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
