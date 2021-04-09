﻿using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriontec.People
{
    public interface IPersonRepository : IRepository<Person,long>
    {
         List<Person> GetAllWithName(string personName);
        Person GetOneById(int id);
    }
}
