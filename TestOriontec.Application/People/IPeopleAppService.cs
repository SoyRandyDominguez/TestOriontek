using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriontec.People.Dtos;

namespace TestOriontec.People
{
    public interface IPeopleAppService: IApplicationService
    {
        GetPeopleOutput GetPeople(GetPeopleInput input);
        GetPersonOutput UpdatePeople(UpdatePersonInput input);
        GetPersonOutput CreatePeople(CreatePersonInput input);
        

    }
}
