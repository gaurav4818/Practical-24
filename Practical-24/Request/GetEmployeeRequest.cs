using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_24.Repository
{
    public class GetEmployeeRequest : MediatR.IRequest<List<Employee>>
    {
        public int? EMP_ID { get; set; }
      
    }
}
