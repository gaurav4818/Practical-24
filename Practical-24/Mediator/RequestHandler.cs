using MediatR;
using Practical_24.Models;
using Practical_24.Repository;
using Practical_24.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Practical_24.Mediator
{
    public class RequestHandler : IRequestHandler<GetEmployeeRequest, List<Employee>>,IRequestHandler<InsertEmployeeRequest,Employee>, IRequestHandler<DeleteEmployeeRequest, bool>,IRequestHandler<EditEmployeeRequest, Employee>
    {
        private readonly IEmployeeRepository employeeRepositories;

        public RequestHandler(IEmployeeRepository employeeRepositories)
        {
            this.employeeRepositories = employeeRepositories;
        }

        public Task<List<Employee>> Handle(GetEmployeeRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employeeRepositories.GetEmployee(request.EMP_ID));

        }

        public Task<Employee> Handle(InsertEmployeeRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employeeRepositories.Create(request.emp));
        }

        public Task<bool> Handle(DeleteEmployeeRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employeeRepositories.Delete(request.EMP_ID));
        }

        public Task<Employee> Handle(EditEmployeeRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employeeRepositories.Edit(request.employee));
        }
    }
}
