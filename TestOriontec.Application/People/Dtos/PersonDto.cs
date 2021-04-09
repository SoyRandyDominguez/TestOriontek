using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriontec.People.Dtos
{
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format(
                "[Person Id={0}, Name={1}]",
                Id,
                Name
                );
        }
    }
}
