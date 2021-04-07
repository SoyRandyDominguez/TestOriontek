using Abp.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TestOriontec.Api.Controllers
{
    public class TaskController : AbpApiController
    {
        public TaskController()
        {
            LocalizationSourceName = "TaskController";
        }


        public IHttpActionResult GetProduct(int id)
        {
            var product = new { };
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


    }
}
