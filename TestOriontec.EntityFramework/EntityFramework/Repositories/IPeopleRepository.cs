using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriontec.EntityFramework.Repositories
{
    public interface IPeopleRepository : IRepository<People.Person, long>
    {

        List<People.Person> GetAllWithname(string PersonName );

    }

}

