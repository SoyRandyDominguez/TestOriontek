﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriontec.People
{
    public class Person : Entity<long>
    {
        public virtual string Name { get; set; }
    }
}
