using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Request
{
    public class EditEmployeeRequest:MediatR.IRequest<Employee>
    {
        public Employee employee { get; set; }
    }
}
