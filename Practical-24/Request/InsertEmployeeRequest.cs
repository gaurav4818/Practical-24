using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Repository
{
    public class InsertEmployeeRequest:MediatR.IRequest<Employee>
    {
        public Employee emp { get; set; }
    }
}
