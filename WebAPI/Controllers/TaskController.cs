using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);
            var result =_taskService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int StatusId)
        {
            var result = _taskService.GetById(StatusId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getbylocation")]
        public IActionResult GetAllByLocation(int LocationId)
        {
            Thread.Sleep(1000);
            var result = _taskService.GetAllByLocation(LocationId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbystatus")]
        public IActionResult GetAllByStatus(int StatusId)
        {
            Thread.Sleep(1000);
            var result = _taskService.GetAllByStatus(StatusId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Entities.Concrete.Task tasks)
        {
            var result = _taskService.Add(tasks);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("update")]
        //public IActionResult Update(Entities.Concrete.Task tasks)
        //{
        //    var result = _taskService.Update(tasks);
        //    if (result.Success) return Ok(result);

        //    return BadRequest(result);
        //}

        //[HttpPost("delete")]
        //public IActionResult Delete(Entities.Concrete.Task tasks)
        //{
        //    var result = _taskService.Delete(tasks);
        //    if (result.Success) return Ok(result);

        //    return BadRequest(result);
        //}





    }
}
