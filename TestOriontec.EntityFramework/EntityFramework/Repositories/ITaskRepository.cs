using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriontec.Tasks;

namespace TestOriontec.EntityFramework.Repositories
{
    public interface ITaskRepository : IRepository<Tasks.Task, long>
    {
         List<Tasks.Task> GetAllWithPeople(int? assignedPersonId, TaskState? state);
    }
}
