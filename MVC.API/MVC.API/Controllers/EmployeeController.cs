using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC.API.Models;
namespace MVC.API.Controllers
{
    public class EmployeeController : ApiController
    {
        WebAppDbEntities7 db = new WebAppDbEntities7();

        public IEnumerable<Employee> Get()
        {
          
            return db.Employees.ToList();
        }
           
    }
}
