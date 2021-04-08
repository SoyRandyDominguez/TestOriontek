using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriontec.People;
using TestOriontec.Tasks.Dtos;
using AutoMapper;

namespace TestOriontec.Tasks
{
    public class TaskAppService : TestOriontecAppServiceBase, ITaskAppService
    {
        //These members set in constructor using constructor injection.

        private readonly IMapper _mapper;
        private readonly ITaskRepository _taskRepository;
        private readonly IRepository<Person> _personRepository;

        /// <summary>
        ///In constructor, we can get needed classes/interfaces.
        ///They are sent here by dependency injection system automatically.
        /// </summary>
        public TaskAppService(IMapper mapper, ITaskRepository taskRepository, IRepository<Person> personRepository)
        {
            _mapper = mapper;
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);


            List<TaskDto> map = new List<TaskDto>();

            foreach (var item in tasks)
            {
                TaskDto ob = new TaskDto
                {
                    Id = item.Id,
                    AssignedPersonId = item.AssignedPersonId,
                    AssignedPersonName = item.AssignedPerson.Name,
                    CreationTime = item.CreationTime,
                    Description = item.Description,
                    State = (byte)item.State
                };

                map.Add(ob);
            }


            return new GetTasksOutput
            {
                Tasks = map

            };
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            Logger.Info("Updating a task for input: " + input);

            var task = _taskRepository.Get(input.TaskId);


            if (input.State.HasValue)
            {
                task.State = input.State.Value;
            }

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
            }

        }

        public void CreateTask(CreateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a task for input: " + input);

            //Creating a new Task entity with given input's properties
            var task = new Task { Description = input.Description };

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPersonId = input.AssignedPersonId.Value;
            }

            //Saving entity with standard Insert method of repositories.
            _taskRepository.Insert(task);
        }
    }
}
