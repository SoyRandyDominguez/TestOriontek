using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOriontec.Tasks;
using TestOriontec.Tasks.Dtos;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {


        private readonly TaskAppService _service;
         
        public TasksController(TaskAppService service)
        {
            _service = service;
        }


        [HttpGet]
        public List<TaskDto> Get()
        {
            List<TaskDto> tasks = new List<TaskDto>();
            GetTasksInput input = new GetTasksInput();



            tasks = _service.GetTasks(input).Tasks;



            return tasks;
        }



    }
}
