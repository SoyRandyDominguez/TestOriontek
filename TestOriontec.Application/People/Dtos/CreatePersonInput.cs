using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriontec.People.Dtos
{
    public class CreatePersonInput
    {
        [Required]
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("[CreatePersonInput > Name = {0}]",Name);
        }
    }
}
