using EBAUExercise.Models;
using EBAUExercise.Repository;
using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : Controller
    {
        private readonly DoWorkService _doWorkService;
        private List<CustomerOrder> OrderList = new List<CustomerOrder>();

        //public TasksController(DoWorkService doWorkService)
        //{
        //    _doWorkService = doWorkService;

        //    SampleDataRepository db = new();
        //    OrderList = new(db.GetDataset);
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    // Reset counter to 0
        //    Counter.Reset();

        //    // Increment counter
        //    Counter.Add();

        //    //SampleDataRepository db = new();
        //    //ListModel<CustomerOrder> list = new(db.GetDataset);
        //    //ViewBag.CustomerOrders = list;

        //    return Ok(new
        //    {
        //        IsDataSaved = _doWorkService.DoWork(),
        //        Count = Counter.GetCount() // return the current value of the counter here.
        //    });
        //}



        // Get all orders and return them to the view
        //[HttpGet]
        //public ActionResult Index()
        //{
        //    if (OrderList == null)
        //    {
        //        // TODO: load real data from database
        //        SampleDataRepository db = new();
        //        OrderList = new(db.GetDataset);
        //    }

        //    return View(OrderList);
        //}
    }
}
