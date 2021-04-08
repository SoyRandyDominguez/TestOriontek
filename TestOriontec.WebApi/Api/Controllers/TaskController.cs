using Abp.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TestOriontec.Tasks;
using TestOriontec.Tasks.Dtos;

namespace TestOriontec.Api.Controllers
{
    public class TaskController : AbpApiController
    {


        private readonly TaskAppService _service;
        public TaskController(TaskAppService service)
        {
            _service = service;
            LocalizationSourceName = "TaskController";
        }


        public IHttpActionResult GetAllTasks()
        {
            List<TaskDto> tasks = new List<TaskDto>();
            GetTasksInput input = new GetTasksInput();


            tasks = _service.GetTasks(input).Tasks;



            if (tasks == null )
            {
                return NotFound();
            }


            return Ok(tasks);
        }

        public IHttpActionResult CreateTasks([FromBody] CreateTaskInput input)
        {

            if (input == null)
            {
                return BadRequest("Invalid passed data");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _service.CreateTask(input);

            List<TaskDto> tasks = new List<TaskDto>();
            GetTasksInput task = new GetTasksInput();
            tasks = _service.GetTasks(task).Tasks;

            return Ok(tasks);
        }
         
    }
}
