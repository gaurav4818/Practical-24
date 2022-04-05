
using Microsoft.EntityFrameworkCore;
using Practical_24.DataContext;
using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_24.Repository
{
   public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public  Employee Create(Employee emp)
        {
            if (emp.Id == 0)
            {
                 context.Employees.Add(emp);
                 context.SaveChanges();
                return emp;
            }
            return null;
        }
        public  List<Employee> GetEmployee(int? id)
        {

            if (id == null)
            {
                return context.Employees.Include(x => x.Department).ToList();
             }
            return context.Employees.Include(x => x.Department).Where(x => x.Id == id).ToList();
        }
        public  Employee Edit(Employee emp)
        {
            context.Employees.Update(emp);
             context.SaveChanges();
            return emp;
        }
        public  bool Delete(int id)
        {
            var employee =  context.Employees.Find(id);
            if (employee != null)
            {
                employee.Status = true;
                context.Employees.Update(employee);
                 context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
