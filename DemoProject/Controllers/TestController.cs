using DemoProject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var emplist = new List<Employee>() {
                new Employee(){ Name="MK", Address="Patna", Class="12th", Rollno=101},
                new Employee(){ Name="MK2", Address="Patna", Class="12th", Rollno=101},
                new Employee(){ Name="MK3", Address="Patna", Class="12th", Rollno=101},
                new Employee(){ Name="MK4", Address="Patna", Class="12th", Rollno=101}
                new Employee(){ Name="MK5", Address="Patna", Class="12th", Rollno=101}
                };
            return emplist;
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
