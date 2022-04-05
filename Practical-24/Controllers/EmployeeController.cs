using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practical_24.Models;
using Practical_24.Repository;
using Practical_24.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public Task<List<Employee>> GetEmployeeInfo(int? EmpId)
        {
          var result = mediator.Send(new GetEmployeeRequest() { EMP_ID = EmpId });
            if (result != null)
            {
                return result;
            }
            return null;
        }
        [HttpPost]
        public Task<Employee> AddemployeeInfo(Employee employee)
        {
            return mediator.Send(new InsertEmployeeRequest(){ emp=employee});
        }
        [HttpDelete("{id}")]
        public Task<bool> DeleteEmployeeInfo(int id)
        {
            return mediator.Send(new DeleteEmployeeRequest() { EMP_ID = id });
        }
        [HttpPut("EditEmployee/{id}")]
        public  Task<Employee> EditEmployee(int id, [FromBody] Employee emp)
        {
            if (id == emp.Id)
            {
                 var result = mediator.Send(new EditEmployeeRequest() {employee=emp});
                return result;

            }
            return null;
        }
    }
}
