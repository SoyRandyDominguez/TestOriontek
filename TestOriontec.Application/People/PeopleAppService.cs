﻿using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOriontec.People.Dtos;

namespace TestOriontec.People
{
    public class PeopleAppService : TestOriontecAppServiceBase, IPeopleAppService
    {

        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public PeopleAppService(IMapper mapper, IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            _mapper = mapper;

        }

        public GetPersonOutput CreatePeople(CreatePersonInput input)
        {
            Logger.Info("Creating a person for input: " + input);

            //Creating a new Task entity with given input's properties
            var person = new Person { Name = input.Name };

            //Saving entity with standard Insert method of repositories.
            int id = _personRepository.InsertAndGetId(person);

            var retorno = _personRepository.GetOneById(id);

            return new GetPersonOutput
            {
                person = new PersonDto() { Id = retorno.Id, Name = retorno.Name }
            };
        }

        public GetPeopleOutput GetPeople(GetPeopleInput input)
        {

            var people = _personRepository.GetAllWithName(input.Name);


            List<PersonDto> map = new List<PersonDto>();

            foreach (var item in people)
            {
                PersonDto ob = new PersonDto
                {
                    Id = item.Id,
                    Name = item.Name,
                };

                map.Add(ob);
            }


            return new GetPeopleOutput
            {
                People = map

            };
        }

        public GetPersonOutput UpdatePerson(UpdatePersonInput input)
        {
            throw new NotImplementedException();
        }
    }
}