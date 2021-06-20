using EBAUExercise.Repository;
using EBAUExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly DoWorkService _doWorkService;

        public TasksController(DoWorkService doWorkService)
        {
            _doWorkService = doWorkService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ReportService a = new ReportService(new SampleDataRepository());

            // Reset counter to 0
            Counter.Reset();

            // Increment counter
            Counter.Add();

            return Ok(new
            {
                IsDataSaved = _doWorkService.DoWork(),
                Count = Counter.GetCount() // return the current value of the counter here.
            });
        }
    }
}
