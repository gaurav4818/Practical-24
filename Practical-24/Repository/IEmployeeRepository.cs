
using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_24.Repository
{
    public interface IEmployeeRepository
    {
         Employee Create(Employee emp);
         List<Employee> GetEmployee(int? id);
         Employee Edit(Employee emp);
         bool Delete(int id);

    }
}
