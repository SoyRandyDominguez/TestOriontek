using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriontec.People.Dtos
{
    public class UpdatePersonInput
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Custom validation method. It's called by ABP after data annotation validations.
        public void AddValidationErrors(CustomValidationContext context)
        {
            if (Id <= 0)
            {
                context.Results.Add(new ValidationResult("Id must be >= 1", new[] { "Id" }));
            }
        }

        public override string ToString()
        {
            return string.Format("[UpdatePersonInput > PersonId = {0}, Name = {1}]", Id, Name);
        }
    }
}
