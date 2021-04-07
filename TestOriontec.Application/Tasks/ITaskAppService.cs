using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriontec.Tasks.Dtos;

namespace TestOriontec.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);
        void UpdateTask(UpdateTaskInput input);
        void CreateTask(CreateTaskInput input);
    }
}
